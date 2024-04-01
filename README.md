# Videoschnitt Templates

Dieses Repository, "Videoschnitt Templates", ist eine Sammlung von benutzerdefinierten .NET Templates, die darauf ausgelegt sind, die schnelle Entwicklung von Modulen und Anwendungen innerhalb des Videoschnitt Projekts zu erleichtern. Jedes Template hält sich an unsere Architekturprinzipien und bietet eine strukturierte Grundlage für den Bau modularer, wartbarer und skalierbarer Lösungen in .NET Core und ASP.NET Core Anwendungen.

## Installation

```bash
dotnet new install Kurmann.Videoschnitt.Templates
```

## Anwendung

Nach der Installation können Sie ein neues Projekt basierend auf einem Template erstellen mit:

```bash
dotnet new [TemplateShortName] -n Projektname
```

## Verfügbare Templates

### Service Collection Integrated Module (SCI Module)

Kurzname: **scimodule**

Das `ServiceCollectionIntegratedModuleTemplate` ist das erste Template in dieser Sammlung, entworfen für die nahtlose Erstellung von Modulen, die einfach mit der `IServiceCollection` für Dependency Injection integriert werden können. Dieses Template legt Wert auf Modularität, Event-Driven Design und klare Operationsergebnis-Typen, um den Entwicklungsprozess zu vereinfachen und Konsistenz über Module hinweg zu gewährleisten.

#### Features SCI Module

- **IServiceCollection Integration**: Erleichtert die Registrierung von Diensten mit der IServiceCollection, was die Dependency Injection verbessert.
- **Modulare Architektur**: Hält sich an unsere Prinzipien von hoher Kohäsion und loser Kopplung.
- **Event-Driven Design**: Beinhaltet Event- und Delegate-Muster für die Nachrichtenverarbeitung innerhalb des Moduls.
- **Operationsergebnis-Typen**: Nutzt `Result<T>` für die explizite Handhabung von Erfolgs- und Fehlerfällen.
- **Einfache Integration**: Entwickelt für die mühelose Eingliederung in Host-Anwendungen.
- **Namespace-Unterstützung**: Der Stammnamespace `Kurmann.Videoschnitt` wird korrekt angewandt.

#### Anwendung SCI Module

```bash
dotnet new scimodule -n MediaFileWatcher -o src
```

ergibt ein Modul im "src"-Verzeichnis mit den .NET-Projekten

- `Kurmann.Videoschnitt.MediaFileWatcher.Application`
- `Kurmann.Videoschnitt.MediaFileWatcher.Module`
- `Kurmann.Videoschnitt.MediaFileWatcher.Entities`
- `Kurmann.Videoschnitt.MediaFileWatcher.Tests`

### SCI Module GitHub Workflow

Kurzname: **scimodule-github-workflow**

#### Features SCI GitHub Workflow

Das Template erzeugt eine GitHub Actions Workflow-Konfiguration (`YAML`-Datei), die für das Publizieren eines Service Collection Integrated Modules auf NuGet.org ausgelegt ist.

#### Anwendung SCI GitHub Workflow

```bash
dotnet new scimodule-github-workflow -o .
```

erzeugt folgende Verzeichnisstruktur im Arbeitsverzeichnis

```text
working-directory/
└── .github/
    └── workflows/
        └── dotnet.yml
```

Hinweis: Die **Namensgebung des Projektes** mit `-n` Parameter hat keinen Einfluss auf die YAML-Datei und kann somit **verzichtet** werden.

### SCI Module Visual Studio Code Debug Configuration

Kurzname: **scimodule-vscode-debugconfig**

#### Features SCI Module VS Code Config

Dieses Modul bietet eine vordefinierte Debug-Konfiguration für die Entwicklung eines Service Collection Integrated Modules in Visual Studio Code. Es umfasst sowohl `launch.json` als auch `tasks.json`, um das Debuggen und Ausführen von Aufgaben innerhalb der VSCode-Umgebung zu erleichtern.

#### Anwendung SCI Module VS Code Config

```bash
dotnet new scimodule-vscode-debugconfig -n Projektname -o .
```

erzeugt folgende Verzeichnisstruktur im Arbeitsverzeichnis

```text
scimodule-vscode-debugconfig/
└── .vscode/
    └── launch.json
    └── tasks.json
```

### Entity Library Template

Kurzname: **entitylib**

Das `Entity Library Template` wurde entwickelt, um die Erstellung von Class-Libraries für die Domänenlogik in .NET-Projekten zu vereinfachen. Durch die Verwendung der C# Functional Extensions Library als `Result`-Typ, fördert dieses Template einen funktionalen Programmieransatz und verbessert die Handhabung von Operationsergebnissen.

#### Features Entity Library

- **C# Functional Extensions**: Verwendet die C# Functional Extensions Library, um `Result`-Typen für die Rückgabe von Operationsergebnissen zu ermöglichen.
- **Fokussiert auf Domänenlogik**: Ideal für die Entwicklung von Bibliotheken, die Geschäftslogik und Domänenmodelle enthalten.
- **Test-Projekt Integration**: Erstellt automatisch ein zugehöriges Test-Projekt, um die Qualität und Funktionalität der Domänenlogik sicherzustellen.
- **.NET Class-Library Basis**: Bietet eine solide Grundlage für die Entwicklung von wiederverwendbaren .NET Class-Libraries.
- **Modularer Aufbau**: Fördert die Entwicklung von sauber strukturierten, modularen und wartbaren Code-Basen.
- **Namespace-Unterstützung**: Passt sich nahtlos an den Stammnamespace `Kurmann.Videoschnitt` an und gewährleistet eine konsistente Namensgebung.

#### Anwendung Entity Library

```bash
dotnet new entitylib -n DomainLogic -o src
```

ergibt eine Class-Library im "src"-Verzeichnis mit den .NET-Projekten

- `Kurmann.Videoschnitt.DomainLogic`
- `Kurmann.Videoschnitt.DomainLogic.Tests`

Dieses Setup ist optimal für Entwickler, die sich auf die Implementierung von Domänenlogik mit einem klaren Fokus auf funktionale Programmierprinzipien und testgetriebene Entwicklung konzentrieren möchten.

## Empfehlungen

Zum Erstellen eines kompletten Service Collection Integrated Moduls mitsamt Repository-Struktur wird die kombination der Templates `scimodule`, `scimodule-github-workflow` und `scimodule-vscode-debugconfig` empfohlen.

Bitte vorher zum **Wurzelverzeichnis** des neu erstellte GitHub-**Repositorys** wechseln.

Erstellt ein Service Collection Integrated Modul um "src"-Verzeichnis und erzeugt eine passende GitHub Actions Workflow-Konfiguration und eine passende vordefinierte Debug-Konfiguration für Visual Studio Code.

```bash
export PROJEKTNAME="MeinProjekt"
dotnet new scimodule -n $PROJEKTNAME -o src
dotnet new scimodule-github-workflow -o .
dotnet new scimodule-vscode-debugconfig -n $PROJEKTNAME -o .

```
