using CSharpFunctionalExtensions;

namespace Kurmann.Videoschnitt.ServiceCollectionIntegratedModule.Queries;

public interface IQueryService<T>
{
    public Result<T> Execute();
}