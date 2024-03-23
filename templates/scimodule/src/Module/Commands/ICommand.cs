using CSharpFunctionalExtensions;

namespace ServiceCollectionIntegratedModule.Module.Commands;

public interface ICommand<T>
{
    Result<T> Execute();
}