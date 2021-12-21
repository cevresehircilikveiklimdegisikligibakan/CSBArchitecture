namespace Application.Contract.Models.TodoLists;

public record CreateTodoListRequest : IRequest<ServiceResponse<CreateTodoListResponse>>
{
    public string Title { get; set; }
}
