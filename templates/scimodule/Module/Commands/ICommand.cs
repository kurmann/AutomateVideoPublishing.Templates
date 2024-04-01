using CSharpFunctionalExtensions;

namespace Kurmann.Videoschnitt.ServiceCollectionIntegratedModule.Module.Commands;

public interface ICommand<T>
{
    Result<T> Execute();
}