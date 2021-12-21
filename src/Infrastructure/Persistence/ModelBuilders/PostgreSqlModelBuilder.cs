using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.ModelBuilders;

public static class PostgreSqlModelBuilder
{
    private const string SCHEME = "public";

    public static void Build(ref ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(SCHEME);
        BuildTodoList(ref modelBuilder);
    }

    private static void BuildTodoList(ref ModelBuilder modelBuilder)
    {
        modelBuilder.HasSequence<int>("todolist_id_seq")
                    .StartsAt(1)
                    .IncrementsBy(1);

        modelBuilder.Entity<TodoList>()
            .ToTable("TodoList", SCHEME)
            .HasKey(x => x.Id);

        modelBuilder.Entity<TodoList>()
            .Property(x => x.Id)
            .IsRequired()
            .HasColumnName("Id");
    }

    private static ModelBuilder BuildTodoItem(ref ModelBuilder modelBuilder)
    {
        modelBuilder.HasSequence<int>("SQ_TODOITEM_ID");

        modelBuilder.Entity<TodoItem>()
            .ToTable("TODOITEM")
            .HasKey(x => x.Id);

        modelBuilder.Entity<TodoItem>()
            .Property(x => x.Id)
            .IsRequired()
            .HasColumnName("ID");

        modelBuilder.Entity<TodoItem>()
            .Property(x => x.TodoListId)
            .IsRequired()
            .HasColumnName("TODOLISTID");

        modelBuilder.Entity<TodoItem>()
            .Property(x => x.Title)
            .IsRequired()
            .HasColumnName("TITLE");

        modelBuilder.Entity<TodoItem>()
            .Property(x => x.Note)
            .HasColumnName("NOTE");

        modelBuilder.Entity<TodoItem>()
            .Property(x => x.Done)
            .HasColumnName("DONE");

        modelBuilder.Entity<TodoItem>()
            .Property(x => x.PriorityLevel)
            .IsRequired()
            .HasColumnName("PRIORITYLEVEL");

        modelBuilder.Entity<TodoItem>()
            .Property(x => x.UserId)
            .IsRequired()
            .HasColumnName("USERID");

        return modelBuilder;
    }
}
