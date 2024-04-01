using CSharpFunctionalExtensions;

namespace Kurmann.Videoschnitt.ServiceCollectionIntegratedModule.Module.Queries;

public interface IQueryService<T>
{
    public Result<T> Execute();
}