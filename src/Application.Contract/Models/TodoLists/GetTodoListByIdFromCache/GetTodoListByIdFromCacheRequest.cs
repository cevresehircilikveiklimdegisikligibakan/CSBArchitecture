namespace Application.Contract.Models.TodoLists;

public record GetTodoListByIdFromCacheRequest : IRequest<ServiceResponse<GetTodoListByIdFromCacheResponse>>
{
    public int Id { get; set; }
}
