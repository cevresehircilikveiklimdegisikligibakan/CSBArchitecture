using Application.Contract.Models.TodoLists;
using Domain.Constants;
using FluentValidation;

namespace Application.Services.TodoLists.Commands.CreateTodoList;

public class CreateTodoListCommandValidator : AbstractValidator<CreateTodoListRequest>
{
    private readonly ITodoListInternalService _todoListService;
    public CreateTodoListCommandValidator(ITodoListInternalService todoListService)
    {
        _todoListService = todoListService;

        RuleFor(x => x.Title)
            .NotEmpty().WithMessage(Messages.TodoList.Validate_Title_BosOlamaz)
            .MustAsync(BeUniqueTitle).WithMessage(string.Format(Messages.KayitSistemdeVar, "Liste"));
    }

    public async Task<bool> BeUniqueTitle(string title, CancellationToken cancellationToken)
    {
        var sameTodoListResponse =
            await _todoListService.GetSameAsync(GetSameTodoListRequest.Create(title));
        if (sameTodoListResponse.IsSuccess == false)
            return false;
        if (sameTodoListResponse.Data != null)
            return false;
        return true;
    }
}
