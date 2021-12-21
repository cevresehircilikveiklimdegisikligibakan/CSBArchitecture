using Application.Contract.Models.TodoLists;
using CSB.Core.Mappings;

namespace Application.Mappings;

public class TodoListProfile : MappingProfile
{
    public TodoListProfile()
    {
        CreateMap<CreateTodoListRequest, TodoList>();
        CreateMap<UpdateTodoListRequest, TodoList>();

        CreateMap<GetAllTodoListDto, GetTodoListByIdFromCacheResponse>();

        CreateMap<GetTodoListByIdFromCacheResponse, GetAllTodoListDto>();
    }
}
