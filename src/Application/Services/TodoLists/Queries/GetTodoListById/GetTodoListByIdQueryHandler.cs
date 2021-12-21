using Application.Contract.Models.TodoLists;
using Application.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.TodoLists.Queries.GetTodoListById;

internal class GetTodoListByIdQueryHandler : RequestHandlerBase<GetTodoListByIdRequest, ServiceResponse<GetTodoListByIdResponse>>
{
    private readonly IApplicationDbContext _context;

    public GetTodoListByIdQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public override async Task<ServiceResponse<GetTodoListByIdResponse>> Handle(GetTodoListByIdRequest request, CancellationToken cancellationToken)
    {
        var response = await (from l in _context.TodoList
                              where l.Id == request.Id
                              select new GetTodoListByIdResponse
                              {
                                  Id = l.Id,
                                  Title = l.Title
                              }).SingleOrDefaultAsync();
        return ServiceResponse<GetTodoListByIdResponse>.Success(response);
    }
}
