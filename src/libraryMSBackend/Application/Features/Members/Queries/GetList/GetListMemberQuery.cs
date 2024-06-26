using Application.Features.Members.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.Members.Constants.MembersOperationClaims;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Members.Queries.GetList;

public class GetListMemberQuery : IRequest<GetListResponse<GetListMemberListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListMembers({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetMembers";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListMemberQueryHandler : IRequestHandler<GetListMemberQuery, GetListResponse<GetListMemberListItemDto>>
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;

        public GetListMemberQueryHandler(IMemberRepository memberRepository, IMapper mapper)
        {
            _memberRepository = memberRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListMemberListItemDto>> Handle(GetListMemberQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Member> members = await _memberRepository.GetListAsync(
                 include: b => b.IgnoreQueryFilters() // Soft delete filtrelerini atlar
                 .Include(b => b.BookIssues).ThenInclude(b => b.Book).ThenInclude(b => b.Location)
                 .Include(b => b.BookIssues).ThenInclude(b => b.Book).ThenInclude(b => b.Category)
                 .Include(b => b.BookIssues).ThenInclude(b => b.Book).ThenInclude(b => b.Publisher)
                 .Include(b => b.BookIssues).ThenInclude(b => b.Book).ThenInclude(b => b.BookAuthors).ThenInclude(b => b.Author)
                 .Include(b => b.BookIssues).ThenInclude(b => b.FineDues)
                 .Include(b=>b.FinePayments)
                 .Include(b=>b.FavoriteBooks).ThenInclude(b=>b.Book),
                 index: request.PageRequest.PageIndex,
                 size: request.PageRequest.PageSize,
                 cancellationToken: cancellationToken
             );

            GetListResponse<GetListMemberListItemDto> response = _mapper.Map<GetListResponse<GetListMemberListItemDto>>(members);
            return response;
        }
    }
}