namespace Application.Contract.Models.TodoLists
{
    public record CreateTodoListWithDefaultItemResponse
    {
        public int Id { get; init; }

        private CreateTodoListWithDefaultItemResponse() { }

        public static CreateTodoListWithDefaultItemResponse Create(int id)
        {
            return new CreateTodoListWithDefaultItemResponse { Id = id };
        }
    }
}
