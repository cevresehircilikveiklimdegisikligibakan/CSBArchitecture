using Application.Contract.Models.TodoLists;
using Application.Infrastructure.Persistence;

namespace Application.Services.TodoLists.Commands.UpdateTodoList;

internal class UpdateTodoListCommandHandler : RequestHandlerBase<UpdateTodoListRequest, ServiceResponse<UpdateTodoListResponse>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMappingService _mappingService;

    public UpdateTodoListCommandHandler(IApplicationDbContext context,
                                        IMappingService mappingService)
    {
        _context = context;
        _mappingService = mappingService;
    }

    public override async Task<ServiceResponse<UpdateTodoListResponse>> Handle(UpdateTodoListRequest request, CancellationToken cancellationToken)
    {
        TodoList todoList = _mappingService.Map<TodoList>(request);
        todoList.Title = request.Title;
        await _context.SaveChangesAsync();
        return ServiceResponse<UpdateTodoListResponse>.Success(UpdateTodoListResponse.Create());
    }
}
