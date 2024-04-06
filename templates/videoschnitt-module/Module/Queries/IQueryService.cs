using CSharpFunctionalExtensions;

namespace Kurmann.Videoschnitt.ModuleName.Queries;

public interface IQueryService<T>
{
    public Result<T> Execute();
}