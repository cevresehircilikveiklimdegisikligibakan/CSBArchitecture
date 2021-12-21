using Application.Contract.Models.TodoItems;
using Application.Contract.Models.TodoLists;
using Application.Services.TodoItems;

namespace Application.Services.TodoLists.Commands.CreateTodoListWithDefaultItem;

internal class CreateTodoListWithDefaultItemCommand : RequestHandlerBase<CreateTodoListWithDefaultItemRequest, ServiceResponse<CreateTodoListWithDefaultItemResponse>>
{
    private readonly ITodoListInternalService _todoListService;
    private readonly ITodoItemInternalService _todoItemService;

    public CreateTodoListWithDefaultItemCommand(ITodoListInternalService todoListService,
                                                ITodoItemInternalService todoItemService)
    {
        _todoListService = todoListService;
        _todoItemService = todoItemService;
    }

    public override async Task<ServiceResponse<CreateTodoListWithDefaultItemResponse>> Handle(CreateTodoListWithDefaultItemRequest request, CancellationToken cancellationToken)
    {
        var createTodoListRequest = new CreateTodoListRequest
        {
            Title = request.Title
        };
        var createTodoListResponse = await _todoListService.CreateAsync(createTodoListRequest);
        if (!createTodoListResponse.IsSuccess)
            return ServiceResponse<CreateTodoListWithDefaultItemResponse>.Fail(createTodoListResponse.Message);

        var createTodoItemRequest = new CreateTodoItemRequest
        {
            Title = "Item 1",
            Note = "",
            PriorityLevel = 1,
            TodoListId = createTodoListResponse.Data.Id
        };

        var createTodoItemResponse = await _todoItemService.CreateAsync(createTodoItemRequest);
        if (!createTodoItemResponse.IsSuccess)
            return ServiceResponse<CreateTodoListWithDefaultItemResponse>.Fail(createTodoItemResponse.Message);


        return ServiceResponse<CreateTodoListWithDefaultItemResponse>.Success(CreateTodoListWithDefaultItemResponse.Create(createTodoListResponse.Data.Id));
    }
}