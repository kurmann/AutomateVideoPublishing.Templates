using CSharpFunctionalExtensions;

namespace Kurmann.AutomateVideoPublishing.ServiceCollectionIntegratedModule.Module.Commands;

public interface ICommand<T>
{
    Result<T> Execute();
}