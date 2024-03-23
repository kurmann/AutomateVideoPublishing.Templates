using CSharpFunctionalExtensions;

namespace ServiceCollectionIntegratedModule.Module.Queries;

public interface IQueryService<T>
{
    public Result<T> Execute();
}