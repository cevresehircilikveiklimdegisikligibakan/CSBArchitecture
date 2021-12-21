namespace Application.Contract.Models.TodoLists;

public record CreateTodoListWithDefaultItemRequest : IRequest<ServiceResponse<CreateTodoListWithDefaultItemResponse>>
{
    public string Title { get; set; }
}
