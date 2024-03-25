# Automate Video Publishing Templates

Dieses Repository, "Automate Video Publishing Templates", ist eine Sammlung von benutzerdefinierten .NET Templates, die darauf ausgelegt sind, die schnelle Entwicklung von Modulen und Anwendungen innerhalb des Automate Video Publishing Projekts zu erleichtern. Jedes Template hält sich an unsere Architekturprinzipien und bietet eine strukturierte Grundlage für den Bau modularer, wartbarer und skalierbarer Lösungen in .NET Core und ASP.NET Core Anwendungen.

## Verfügbare Templates

### Service Collection Integrated Module (SCI Module)

Kurzname: **scimodule**

Das `ServiceCollectionIntegratedModuleTemplate` ist das erste Template in dieser Sammlung, entworfen für die nahtlose Erstellung von Modulen, die einfach mit der `IServiceCollection` für Dependency Injection integriert werden können. Dieses Template legt Wert auf Modularität, Event-Driven Design und klare Operationsergebnis-Typen, um den Entwicklungsprozess zu vereinfachen und Konsistenz über Module hinweg zu gewährleisten.

#### Features

- **IServiceCollection Integration**: Erleichtert die Registrierung von Diensten mit der IServiceCollection, was die Dependency Injection verbessert.
- **Modulare Architektur**: Hält sich an unsere Prinzipien von hoher Kohäsion und loser Kopplung.
- **Event-Driven Design**: Beinhaltet Event- und Delegate-Muster für die Nachrichtenverarbeitung innerhalb des Moduls.
- **Operationsergebnis-Typen**: Nutzt Result<T> für die explizite Handhabung von Erfolgs- und Fehlerfällen.
- **Einfache Integration**: Entwickelt für die mühelose Eingliederung in Host-Anwendungen.
- **Namespace-Unterstützung**: Der Stammnamespace `Kurmann.AutomateVideoPublishing` wird korrekt angewandt.

## Installation

```bash
dotnet new install Kurmann.AutomateVideoPublishing.Templates
```

## Anwendung

Nach der Installation können Sie ein neues Projekt basierend auf einem Template erstellen mit:

```bash
dotnet new [TemplateShortName] -n IhrModulName
```