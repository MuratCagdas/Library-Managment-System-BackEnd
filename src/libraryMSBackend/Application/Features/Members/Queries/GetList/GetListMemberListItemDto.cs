using Application.Features.BookIssues.Queries.GetList;
using Application.Features.Books.Queries.GetList;
using Application.Features.FavoriteBooks.Queries.GetList;
using Application.Features.FineDues.Queries.GetList;
using Application.Features.FinePayments.Queries.GetList;
using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Members.Queries.GetList;

public class GetListMemberListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string ImageUrl { get; set; }
    public bool Subscribe { get; set; }

    public List<GetListBookListItemDto> Books { get; set; }
    public List<GetListFavoriteBookListItemDto> Favorites { get; set; }
    public List<GetListFineDueListItemDto> FineDues { get; set; }
    public List<GetListFinePaymentListItemDto> FinePayments { get; set; }
    public List<GetListBookIssueListItemDto> BookIssues { get; set; }
}