using Application.Contract.Models.TodoLists;
using CSB.Core.Application.Contract.Controllers;
using Refit;

namespace Application.Contract.Controllers;

//[Headers("Content-Type: application/json")]
public interface ITodoListController : IAPIController
{
    [Post("/TodoList/create")]
    Task<ServiceResponse<CreateTodoListResponse>> Create(CreateTodoListRequest request);
    [Post("/TodoList/update")]
    Task<ServiceResponse<UpdateTodoListResponse>> Update(UpdateTodoListRequest request);
    [Post("/TodoList/Delete")]
    Task<ServiceResponse<DeleteTodoListResponse>> Delete(DeleteTodoListRequest request);
    [Get("/TodoList/getall")]
    Task<ServiceResponse<GetAllTodoListResponse>> GetAll(GetAllTodoListRequest request);
    [Get("/TodoList/getallfromapi")]
    Task<ServiceResponse<GetAllTodoListFromApiResponse>> GetAllFromApi(GetAllTodoListFromApiRequest request);
    [Get("/todolist/getbyid")]
    Task<ServiceResponse<GetTodoListByIdFromCacheResponse>> GetById([Body] GetTodoListByIdFromCacheRequest request);
}
