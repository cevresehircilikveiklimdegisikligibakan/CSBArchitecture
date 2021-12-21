namespace Application.Contract.Models.TodoLists;

public record GetAllTodoListFromApiRequest : IRequest<ServiceResponse<GetAllTodoListFromApiResponse>>
{
    public static GetAllTodoListFromApiRequest Create()
    {
        return new GetAllTodoListFromApiRequest();
    }
}
