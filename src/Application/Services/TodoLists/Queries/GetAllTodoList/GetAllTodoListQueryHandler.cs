using Application.Contract.Models.TodoLists;
using Application.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.TodoLists.Queries.GetAllTodoList;

internal class GetAllTodoListQueryHandler : RequestHandlerBase<GetAllTodoListRequest, ServiceResponse<GetAllTodoListResponse>>
{
    private readonly IApplicationDbContext _context;

    public GetAllTodoListQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public override async Task<ServiceResponse<GetAllTodoListResponse>> Handle(GetAllTodoListRequest request, CancellationToken cancellationToken)
    {
        var response = await (from l in _context.TodoList
                              orderby l.Title
                              select new GetAllTodoListDto
                              {
                                  Id = l.Id,
                                  Title = l.Title
                              }).ToListAsync();
        return ServiceResponse<GetAllTodoListResponse>.Success(GetAllTodoListResponse.Create(response));
    }
}
