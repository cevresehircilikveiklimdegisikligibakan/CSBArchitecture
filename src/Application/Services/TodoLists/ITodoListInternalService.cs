using Application.Contract.Models.TodoLists;

namespace Application.Services.TodoLists;

public interface ITodoListInternalService : IApplicationService
{
    Task<ServiceResponse<CreateTodoListResponse>> CreateAsync(CreateTodoListRequest request);
    Task<ServiceResponse<GetTodoListByIdResponse>> GetByIdAsync(GetTodoListByIdRequest request);
    Task<ServiceResponse<GetSameTodoListResponse>> GetSameAsync(GetSameTodoListRequest request);

    //[Cached("TodoListGetAll")]
    Task<ServiceResponse<GetAllTodoListResponse>> GetAllAsync(GetAllTodoListRequest request);

}
