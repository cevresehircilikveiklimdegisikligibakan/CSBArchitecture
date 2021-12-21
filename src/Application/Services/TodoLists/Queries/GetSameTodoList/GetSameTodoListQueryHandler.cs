using Application.Contract.Models.TodoLists;
using Application.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.TodoLists.Queries.GetSameTodoList;

internal class GetSameTodoListQueryHandler : RequestHandlerBase<GetSameTodoListRequest, ServiceResponse<GetSameTodoListResponse>>
{
    private readonly IApplicationDbContext _context;

    public GetSameTodoListQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public override async Task<ServiceResponse<GetSameTodoListResponse>> Handle(GetSameTodoListRequest request, CancellationToken cancellationToken)
    {
        var response = await (from l in _context.TodoList
                              where 1 == 1
                                    && (request.Id == 0 || l.Id == request.Id)
                                    && l.Title == request.Title
                              select new GetSameTodoListResponse
                              {
                                  Id = l.Id,
                                  Title = l.Title
                              }).FirstOrDefaultAsync();
        return ServiceResponse<GetSameTodoListResponse>.Success(response);
    }
}

