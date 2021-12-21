using Application.Contract.Models.TodoLists;
using MediatR;

namespace Application.Services.TodoLists;

internal class TodoListService : ServiceBase, ITodoListService, ITodoListInternalService
{
    public TodoListService(IMediator mediator)
        : base(mediator) { }

    public async Task<ServiceResponse<CreateTodoListResponse>> CreateAsync(CreateTodoListRequest request)
    {
        return await SendRequest(request);
    }
    public async Task<ServiceResponse<CreateTodoListWithDefaultItemResponse>> CreateAsync(CreateTodoListWithDefaultItemRequest request)
    {
        return await SendRequest(request);
    }

    public async Task<ServiceResponse<UpdateTodoListResponse>> UpdateAsync(UpdateTodoListRequest request)
    {
        return await SendRequest(request);
    }

    public async Task<ServiceResponse<DeleteTodoListResponse>> DeleteAsync(DeleteTodoListRequest request)
    {
        return await SendRequest(request);
    }

    public async Task<ServiceResponse<GetTodoListByIdResponse>> GetByIdAsync(GetTodoListByIdRequest request)
    {
        return await SendRequest(request);
    }

    public async Task<ServiceResponse<GetTodoListByIdFromCacheResponse>> GetByIdFromCacheAsync(GetTodoListByIdFromCacheRequest request)
    {
        return await SendRequest(request);
    }

    public async Task<ServiceResponse<GetSameTodoListResponse>> GetSameAsync(GetSameTodoListRequest request)
    {
        return await SendRequest(request);
    }

    public async Task<ServiceResponse<GetAllTodoListFromApiResponse>> GetAllFromApiAsync(GetAllTodoListFromApiRequest request)
    {
        return await SendRequest(request);
    }

    public async Task<ServiceResponse<GetAllTodoListResponse>> GetAllAsync(GetAllTodoListRequest request)
    {
        return await SendRequest(request);
    }
}
