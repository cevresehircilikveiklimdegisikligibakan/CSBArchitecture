using Application.Contract.Models.TodoLists;
using Domain.Constants;

namespace Application.Services.TodoLists.Queries.GetTodoListByIdFromCache;

internal class GetTodoListByIdFromCacheQueryHandler : RequestHandlerBase<GetTodoListByIdFromCacheRequest, ServiceResponse<GetTodoListByIdFromCacheResponse>>
{
    private ITodoListInternalService _todoListService;
    private IMappingService _mappingService;

    public GetTodoListByIdFromCacheQueryHandler(ITodoListInternalService todoListService,
                                                IMappingService mappingService)
    {
        _todoListService = todoListService;
        _mappingService = mappingService;
    }

    public override async Task<ServiceResponse<GetTodoListByIdFromCacheResponse>> Handle(GetTodoListByIdFromCacheRequest request, CancellationToken cancellationToken)
    {
        var todoListsResponse = await _todoListService.GetAllAsync(GetAllTodoListRequest.Create());
        if (todoListsResponse.IsSuccess == false)
            return ServiceResponse<GetTodoListByIdFromCacheResponse>.Fail(todoListsResponse.Message);

        var todoList = todoListsResponse.Data.TodoLists.Where(l => l.Id == request.Id).SingleOrDefault();
        if (todoList == null)
            return ServiceResponse<GetTodoListByIdFromCacheResponse>.Fail(string.Format(Messages.KayitSistemdeYok, "Todolist"));

        var response = _mappingService.Map<GetTodoListByIdFromCacheResponse>(todoList);

        return ServiceResponse<GetTodoListByIdFromCacheResponse>.Success(response);

    }
}
