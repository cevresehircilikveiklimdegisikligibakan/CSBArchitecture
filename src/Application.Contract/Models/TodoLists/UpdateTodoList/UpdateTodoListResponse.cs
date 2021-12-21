namespace Application.Contract.Models.TodoLists
{
    public record UpdateTodoListResponse
    {
        private UpdateTodoListResponse() { }

        public static UpdateTodoListResponse Create()
        {
            return new UpdateTodoListResponse();
        }
    }
}
