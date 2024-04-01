using CSharpFunctionalExtensions;

namespace Kurmann.Videoschnitt.ServiceCollectionIntegratedModule.Commands;

public interface ICommand<T>
{
    Result<T> Execute();
}