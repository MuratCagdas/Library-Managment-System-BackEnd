using Application.Features.Authors.Queries.GetList;
using Application.Features.Locations.Queries.GetList;
using Domain.Enums;
using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Books.Queries.GetList;

public class GetListBookListItemDto : IDto
{
    public Guid Id { get; set; }
    public string ISBNCode { get; set; }
    public string BookTitle { get; set; }
    public int BookEdition { get; set; }
    public int ReleaseDate { get; set; }
    public int PageCount { get; set; }
    public string ImageUrl { get; set; }
    public string Status { get; set; }
    public string CategoryName { get; set; }
    public Guid PublisherId { get; set; }
    public string PublisherName { get; set; }

    public GetListLocationListItemDto Locations { get; set; }
    public List<GetListAuthorListItemDto> Authors { get; set; }
  
}