using Application.Contract.Models.TodoLists;
using Application.Infrastructure.Persistence;

namespace Application.Services.TodoLists.Commands.CreateTodoList;

internal class CreateTodoListCommand : RequestHandlerBase<CreateTodoListRequest, ServiceResponse<CreateTodoListResponse>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMappingService _mappingService;

    public CreateTodoListCommand(IApplicationDbContext context,
                                        IMappingService mappingService)
    {
        _context = context;
        _mappingService = mappingService;
    }

    public override async Task<ServiceResponse<CreateTodoListResponse>> Handle(CreateTodoListRequest request, CancellationToken cancellationToken)
    {
        TodoList todoList = _mappingService.Map<TodoList>(request);
        todoList.UserId = 1;

        var response = await _context.TodoList.AddAsync(todoList);
        await _context.SaveChangesAsync();
        return ServiceResponse<CreateTodoListResponse>.Success(CreateTodoListResponse.Create(response.Entity.Id));
    }
}
