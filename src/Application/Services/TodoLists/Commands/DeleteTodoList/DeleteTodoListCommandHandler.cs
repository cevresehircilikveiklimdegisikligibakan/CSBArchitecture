using Application.Contract.Models.TodoLists;
using Application.Infrastructure.Persistence;

namespace Application.Services.TodoLists.Commands.DeleteTodoList;

internal class DeleteTodoListCommandHandler : RequestHandlerBase<DeleteTodoListRequest, ServiceResponse<DeleteTodoListResponse>>
{
    private readonly IApplicationDbContext _context;

    public DeleteTodoListCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public override async Task<ServiceResponse<DeleteTodoListResponse>> Handle(DeleteTodoListRequest request, CancellationToken cancellationToken)
    {
        var entity = _context.TodoList.Where(l => l.Id == request.Id).FirstOrDefault();
        _context.TodoList.Remove(entity);
        await _context.SaveChangesAsync();
        return ServiceResponse<DeleteTodoListResponse>.Success(DeleteTodoListResponse.Create());
    }
}
