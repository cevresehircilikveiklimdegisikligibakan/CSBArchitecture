namespace Application.Contract.Models.TodoLists;

public record GetSameTodoListRequest : IRequest<ServiceResponse<GetSameTodoListResponse>>
{
    public int Id { get; set; }
    public string Title { get; set; }

    public static GetSameTodoListRequest Create(int id, string title)
    {
        return new GetSameTodoListRequest
        {
            Id = id,
            Title = title
        };
    }

    public static GetSameTodoListRequest Create(string title)
    {
        return new GetSameTodoListRequest
        {
            Id = 0,
            Title = title
        };
    }
}
