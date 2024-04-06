using CSharpFunctionalExtensions;

namespace Kurmann.Videoschnitt.ModuleName.Commands;

public interface ICommand<T>
{
    Result<T> Execute();
}