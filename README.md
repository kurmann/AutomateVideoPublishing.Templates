# Service Collection Integrated Module Template

Kurzname: **"SCI Module"**

`ServiceCollectionIntegratedModuleTemplate` ist ein Custom .NET Template zur schnellen Erstellung von Modulen, die nahtlos mit der `IServiceCollection` integriert werden können. Dieses Template erleichtert die Einhaltung unserer definierten Architekturprinzipien, indem es eine starke Grundstruktur für die Entwicklung von Modulen bietet, die direkt in .NET Core- oder ASP.NET Core-Anwendungen eingebunden werden können.

## Features

- **IServiceCollection Integration**: Jedes Modul ist so konzipiert, dass es Dienste über die IServiceCollection registriert, was die Dependency Injection erleichtert.
- **Modulare Architektur**: Konformität mit unseren Architekturprinzipien von hoher Kohäsion und loser Kopplung.
- **Event-Driven Design**: Einbeziehung von Event- und Delegate-Mustern zur Nachrichtenverarbeitung innerhalb des Moduls.
- **Ergebnistypen für Operationen**: Verwendung von Result<T> zur expliziten Handhabung von Erfolg und Fehlerfällen.
- **Einfache Integration**: Module können mit minimalem Aufwand in die Host-Anwendung integriert werden.

## Voraussetzungen

Um dieses Template zu verwenden, stellen Sie sicher, dass Sie die folgenden Voraussetzungen erfüllt haben:

- .NET 6.0 SDK oder höher

## Installation

Installieren Sie das Template `ServiceCollectionIntegratedModuleTemplate` mit dem folgenden Befehl:

```bash
dotnet new --install scimodule
```

Ersetzen Sie `YourModuleName` durch den gewünschten Namen Ihres Moduls. Stellen Sie zudem sicher, dass alle Links und Verweise auf Dateien wie die Lizenzdatei korrekt sind und mit den Dateien in Ihrem Repository übereinstimmen.

Dieser Befehl generiert ein neues Modul mit dem Namen YourModuleName, das bereits für die Integration mit der IServiceCollection vorbereitet ist.
