using Application.Contract.Models.TodoLists;
using Application.Infrastructure.Persistence;
using CSB.Core.Application.Attributes;

namespace Application.Services.TodoLists;

public interface ITodoListService : IApplicationService
{
    //[ClearCache("TodoListGetAll")]
    Task<ServiceResponse<CreateTodoListResponse>> CreateAsync(CreateTodoListRequest request);

    //[ClearCache("TodoListGetAll")]
    [Transaction(typeof(IApplicationDbContext))]
    Task<ServiceResponse<CreateTodoListWithDefaultItemResponse>> CreateAsync(CreateTodoListWithDefaultItemRequest request);

    //[ClearCache("TodoListGetAll")]
    Task<ServiceResponse<UpdateTodoListResponse>> UpdateAsync(UpdateTodoListRequest request);

    //[ClearCache("TodoListGetAll")]
    Task<ServiceResponse<DeleteTodoListResponse>> DeleteAsync(DeleteTodoListRequest request);

    //[Cached("TodoListGetAll")]
    Task<ServiceResponse<GetAllTodoListResponse>> GetAllAsync(GetAllTodoListRequest request);

    Task<ServiceResponse<GetTodoListByIdResponse>> GetByIdAsync(GetTodoListByIdRequest request);
    Task<ServiceResponse<GetAllTodoListFromApiResponse>> GetAllFromApiAsync(GetAllTodoListFromApiRequest request);
    Task<ServiceResponse<GetTodoListByIdFromCacheResponse>> GetByIdFromCacheAsync(GetTodoListByIdFromCacheRequest request);
}
