using Application.Contract.Models.TodoItems;
using Application.Infrastructure.Persistence;
using Domain.Enums;

namespace Application.Services.TodoItems.Commands.CreateTodoItem;

internal class CreateTodoItemCommandHandler : RequestHandlerBase<CreateTodoItemRequest, ServiceResponse<CreateTodoItemResponse>>
{
    private readonly IApplicationDbContext _context;

    public CreateTodoItemCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public override async Task<ServiceResponse<CreateTodoItemResponse>> Handle(CreateTodoItemRequest request, CancellationToken cancellationToken)
    {
        TodoItem todoItem = new TodoItem();
        todoItem.Title = request.Title;
        todoItem.Note = request.Note;
        todoItem.PriorityLevel = (PriorityLevel)request.PriorityLevel;
        todoItem.Done = false;
        todoItem.TodoListId = request.TodoListId;
        todoItem.UserId = 1;
        var addResult = _context.TodoItem.Add(todoItem);
        _context.SaveChanges();
        int result = addResult.Entity.Id;

        return ServiceResponse<CreateTodoItemResponse>.Success(CreateTodoItemResponse.Create(result));
    }
}
