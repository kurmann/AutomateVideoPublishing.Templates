using CSharpFunctionalExtensions;

namespace Kurmann.AutomateVideoPublishing.ServiceCollectionIntegratedModule.Module.Queries;

public interface IQueryService<T>
{
    public Result<T> Execute();
}