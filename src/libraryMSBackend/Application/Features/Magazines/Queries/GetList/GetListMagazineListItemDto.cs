using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Magazines.Queries.GetList;

public class GetListMagazineListItemDto : IDto
{
    public Guid Id { get; set; }
    public string ISSNCode { get; set; }
    public string MagazineTitle { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int Number { get; set; }
    public Guid PublisherId { get; set; }
    public int? CategoryId { get; set; }
    public string PublisherName { get; set; }
    public string CategoryName { get; set; }


}