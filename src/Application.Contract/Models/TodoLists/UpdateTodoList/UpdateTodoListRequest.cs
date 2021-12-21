namespace Application.Contract.Models.TodoLists;

public record UpdateTodoListRequest : IRequest<ServiceResponse<UpdateTodoListResponse>>
{
    public int Id { get; set; }
    public string Title { get; set; }
}
