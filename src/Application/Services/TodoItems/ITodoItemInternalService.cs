using Application.Contract.Models.TodoItems;

namespace Application.Services.TodoItems;

internal interface ITodoItemInternalService
{
    Task<ServiceResponse<CreateTodoItemResponse>> CreateAsync(CreateTodoItemRequest request);
}

