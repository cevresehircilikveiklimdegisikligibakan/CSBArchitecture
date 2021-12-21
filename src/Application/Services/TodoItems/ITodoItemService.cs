using Application.Contract.Models.TodoItems;

namespace Application.Services.TodoItems;

public interface ITodoItemService
{
    Task<ServiceResponse<CreateTodoItemResponse>> CreateAsync(CreateTodoItemRequest request);
}
