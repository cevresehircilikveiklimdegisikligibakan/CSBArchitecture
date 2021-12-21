namespace Application.Contract.Models.TodoItems;

public record CreateTodoItemRequest : IRequest<ServiceResponse<CreateTodoItemResponse>>
{
    public int TodoListId { get; set; }
    public string Title { get; set; }
    public string Note { get; set; }
    public int PriorityLevel { get; set; }
}
