using Application.Contract.Models.TodoItems;
using MediatR;

namespace Application.Services.TodoItems;

internal class TodoItemService : ServiceBase, ITodoItemService, ITodoItemInternalService
{
    public TodoItemService(IMediator mediator) : base(mediator) { }

    public async Task<ServiceResponse<CreateTodoItemResponse>> CreateAsync(CreateTodoItemRequest request)
    {
        return await SendRequest(request);
    }
}
