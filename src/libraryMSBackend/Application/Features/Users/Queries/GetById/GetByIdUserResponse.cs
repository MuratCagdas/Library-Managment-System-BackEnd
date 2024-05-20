namespace Application.Features.Users.Queries.GetById;

public class GetByIdUserResponse : NArchitecture.Core.Application.Responses.IResponse
{
    public Guid Id { get; set; }
    public Guid MemberId { get; set; }
    public Guid LibraryStaffId { get; set; }

    public string Email { get; set; }

    public GetByIdUserResponse()
    {

        MemberId = Guid.Empty;
        LibraryStaffId = Guid.Empty;
        Email = string.Empty;
    }

    public GetByIdUserResponse(Guid id, Guid memberId, string email,Guid libraryStaffId)
    {
        Id = id;
        MemberId = memberId;
        LibraryStaffId = libraryStaffId;
        Email = email;
    }
}
