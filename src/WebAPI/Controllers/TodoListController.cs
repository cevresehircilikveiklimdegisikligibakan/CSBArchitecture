using Application.Contract.Models.TodoLists;
using Application.Services.TodoLists;

namespace WebAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class TodoListController : ControllerBase, ITodoListController
{
    private readonly ITodoListService _todoListService;

    public TodoListController(ITodoListService todoListService)
    {
        _todoListService = todoListService;
    }

    [HttpPost]
    [Route("create")]
    public async Task<ServiceResponse<CreateTodoListResponse>> Create(CreateTodoListRequest request)
    {
        var response = await _todoListService.CreateAsync(request);
        return response;
    }

    [HttpPost]
    [Route("createwithdefaultitem")]
    public async Task<ServiceResponse<CreateTodoListWithDefaultItemResponse>> CreateWithDefaultItem(CreateTodoListWithDefaultItemRequest request)
    {
        var response = await _todoListService.CreateAsync(request);
        return response;
    }

    [HttpPost]
    [Route("update")]
    public async Task<ServiceResponse<UpdateTodoListResponse>> Update(UpdateTodoListRequest request)
    {
        var response = await _todoListService.UpdateAsync(request);
        return response;
    }

    [HttpPost]
    [Route("delete")]
    public async Task<ServiceResponse<DeleteTodoListResponse>> Delete(DeleteTodoListRequest request)
    {
        var response = await _todoListService.DeleteAsync(request);
        return response;
    }

    [HttpGet]
    [Route("getall")]
    public async Task<ServiceResponse<GetAllTodoListResponse>> GetAll(GetAllTodoListRequest request)
    {
        var response = await _todoListService.GetAllAsync(request);
        return response;
    }

    [HttpGet]
    [Route("getallapi")]
    public async Task<ServiceResponse<GetAllTodoListFromApiResponse>> GetAllFromApi(GetAllTodoListFromApiRequest request)
    {
        var response = await _todoListService.GetAllFromApiAsync(request);
        return response;
    }

    [HttpGet]
    [Route("getbyid")]
    public async Task<ServiceResponse<GetTodoListByIdFromCacheResponse>> GetById([FromBody] GetTodoListByIdFromCacheRequest request)
    {
        var d = new GetTodoListByIdFromCacheResponse() { Id = request.Id + 1, Title = "Todo List Title " + request.Id };
        var response = new ServiceResponse<GetTodoListByIdFromCacheResponse>(true, d);
        return response;
    }
}
