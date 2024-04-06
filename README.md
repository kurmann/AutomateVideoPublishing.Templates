# Videoschnitt Templates

Dieses Repository, "Videoschnitt Templates", ist eine Sammlung von benutzerdefinierten .NET Templates, die speziell darauf ausgelegt sind, die schnelle Entwicklung von Modulen und Anwendungen für das Videoschnitt Projekt zu erleichtern. Diese Templates dienen als strukturierte Grundlage für den Bau modularer, wartbarer und skalierbarer Lösungen, wobei sowohl .NET Core als auch ASP.NET Core Anwendungen unterstützt werden. Jedes Template wurde sorgfältig entworfen, um unseren Architekturprinzipien zu entsprechen und eine effiziente und konsistente Entwicklungserfahrung zu gewährleisten.

## Installation

Um die Videoschnitt Templates zu verwenden, beginnen Sie mit der Installation des gesamten Template-Pakets über die .NET CLI. Dies ermöglicht es Ihnen, neue Projekte mit den bereitgestellten Templates zu initialisieren. Die Installation kann mit dem folgenden Befehl durchgeführt werden:

```bash
dotnet new install Kurmann.Videoschnitt.Templates
```

Diese Aktion fügt alle Videoschnitt Templates Ihrem .NET CLI Tool hinzu, sodass Sie darauf zugreifen und sie für die Erstellung neuer Projekte nutzen können.

## Anwendung

Nach der Installation der Templates können Sie ein neues Projekt basierend auf einem der Videoschnitt Templates erstellen. Verwenden Sie dazu den Befehl `dotnet new` mit dem Kurznamen des gewünschten Templates, gefolgt vom `-n` Argument, um den Namen Ihres neuen Projekts anzugeben. Das Grundformat des Befehls sieht wie folgt aus:

```bash
dotnet new [TemplateShortName] -n Projektname
```

Dabei ist `[TemplateShortName]` durch den Kurznamen des Templates zu ersetzen, das Sie verwenden möchten, und `Projektname` durch den gewünschten Namen Ihres Projekts. Dieser Prozess initialisiert ein neues Projektverzeichnis, das auf der Struktur und den Voreinstellungen des ausgewählten Templates basiert.

Die Anwendung der Videoschnitt Templates ermöglicht es Ihnen, schnell mit der Entwicklung zu beginnen, indem sie eine vordefinierte Projektstruktur und Konfiguration bieten, die speziell auf die Anforderungen und Best Practices des Videoschnitt Projekts abgestimmt sind.

## Templates

### Videoschnitt Modul

Kurzname: **videoschnitt-module**

Das `VideoschnittModulTemplate` ist ein fundamentales Template dieser Sammlung, entworfen für die Erstellung von Modulen, die sich nahtlos in die .NET Core und ASP.NET Core Anwendungen einfügen. Diese Module können leicht mit der `IServiceCollection` für Dependency Injection integriert werden und legen einen starken Fokus auf Modularität, Event-Driven Design sowie klare Operationsergebnis-Typen.

#### Features Videoschnitt Modul

- **IServiceCollection Integration**: Vereinfacht die Registrierung von Diensten und deren Abhängigkeiten, was die Verwendung von Dependency Injection innerhalb des Moduls erleichtert.
- **Modulare Architektur**: Fördert die Entwicklung von klar definierten, unabhängigen Modulen, die sich durch hohe Kohäsion und lose Kopplung auszeichnen.
- **Event-Driven Design**: Unterstützt die Implementierung von Event-basierten Kommunikationsmustern zwischen den Komponenten des Moduls, um eine flexible und erweiterbare Architektur zu fördern.
- **Operationsergebnis-Typen**: Verwendung von `Result<T>` und ähnlichen Mustern für die explizite Handhabung von Erfolgs- und Fehlerfällen in Geschäftslogikoperationen.
- **Einfache Integration**: Entwickelt für die mühelose Eingliederung in bestehende Host-Anwendungen, was die Wiederverwendbarkeit und Skalierbarkeit von Modulen verbessert.
- **Namespace-Unterstützung**: Verwendet den Stammnamespace `Kurmann.Videoschnitt` und gewährleistet eine konsistente und klare Organisationsstruktur des Codes.
- **Konfigurationsmodell**: Vollständige Unterstützung des .NET `IOptions`-Pattern, einschließlich der Integration von .NET User Secrets für eine sichere und flexible Konfiguration.

#### Anwendung Videoschnitt Modul

Um ein neues Videoschnitt Modul zu erstellen, verwenden Sie den folgenden Befehl in Ihrem Terminal oder Command Prompt:

```bash
dotnet new videoschnitt-module -n IhrModulname -o src
```

Dieser Befehl generiert eine neue Modulstruktur im Verzeichnis `src` basierend auf dem VideoschnittModulTemplate, wobei `IhrModulname` der Name Ihres Moduls ist. Die resultierende Verzeichnisstruktur sieht beispielhaft wie folgt aus:

```text
Projektname/
├── .template.config/
├── Application/
│   ├── Commands/
│   ├── Queries/
│   ├── Services/
│   ├── Application.csproj
│   └── Program.cs
├── Module/
│   ├── Commands/
│   ├── Queries/
│   ├── Services/
│   ├── Module.csproj
│   ├── ModuleSettings.cs
│   └── ServiceCollection.cs
└── Projektname.sln
```

Dies spiegelt die modulare Trennung zwischen der Anwendungsebene und dem eigentlichen Modul wider, wobei `Commands`, `Queries` und `Services` jeweils für die Anwendung und das Modul dedizierte Verzeichnisse haben. Das Projekt wird durch eine Solution-Datei (`Projektname.sln`) an der Wurzel organisiert, die es ermöglicht, sowohl das Anwendungs- als auch das Modulprojekt in Entwicklungsumgebungen wie Visual Studio zu laden und zu verwalten.

Bei der Erstellung des Moduls mit dem `videoschnitt-module` Template wird also eine Struktur aufgebaut, die eine klare Trennung der Verantwortlichkeiten und eine saubere Organisation des Codes fördert.

### Videoschnitt Modul Workflow

Kurzname: **videoschnitt-module-wf**

Das `VideoschnittModulWorkflowTemplate` automatisiert den Build- und Veröffentlichungsprozess eines Videoschnitt Moduls mittels GitHub Actions. Dieses Template erstellt eine Konfigurationsdatei für einen Workflow, der bei jedem Push oder Pull Request gegen den `main` Branch aktiviert wird.

#### Features Videoschnitt Modul Workflow

- **Automatisierte CI/CD-Pipeline**: Ausführung von Build- und Pack-Schritten bei jedem Push oder Pull Request.
- **.NET Core Setup**: Einrichtung einer spezifischen .NET-Version.
- **Abhängigkeitsmanagement**: Stellt sicher, dass alle notwendigen Pakete vor dem Build-Vorgang wiederhergestellt werden.
- **NuGet-Paketierung**: Packt das Modul in ein NuGet-Paket, bereit zur Veröffentlichung.
- **NuGet-Veröffentlichung**: Veröffentlicht das Paket und zugehörige Symbolpakete auf NuGet.org unter Verwendung eines API-Keys.

#### Anwendung Videoschnitt Modul Workflow

Die Einrichtung der CI/CD-Pipeline erfolgt durch den folgenden Befehl:

```bash
dotnet new videoschnitt-module-wf -o .
```

Nach Ausführung dieses Befehls wird eine Workflow-Konfigurationsdatei im `.github/workflows`-Verzeichnis des Projekts erstellt. Die YAML-Datei könnte beispielsweise `dotnet-ci-cd.yml` heißen und enthält die Workflow-Definitionen, die Ihrem angegebenen Prozess entsprechen.

Die resultierende Datei sieht dann wie folgt aus:

```yaml
name: .NET CI/CD

on:
  push:
    branches: [ "main" ]
  pull_request:
    branches: [ "main" ]

jobs:
  build_and_pack:
    runs-on: ubuntu-latest

    steps:
    - uses: actions/checkout@v4

    - name: Setup .NET Core
      uses: actions/setup-dotnet@v4
      with:
        dotnet-version: '8.0.x'
        
    - name: Restore dependencies for Module
      run: dotnet restore src/Entities/Entities.csproj

    - name: Pack Entities
      run: dotnet pack src/Entities/Entities.csproj --output ./nupkgs

    # Veröffentlichen der NuGet-Pakete
    - name: Push NuGet and Symbol Packages
      run: |
        dotnet nuget push ./nupkgs/*.nupkg --api-key ${{ secrets.NUGET_API_KEY }} --source https://api.nuget.org/v3/index.json --skip-duplicate
        dotnet nuget push ./nupkgs/*.snupkg --api-key ${{ secrets.NUGET_API_KEY }} --source https://api.nuget.org/v3/index.json --skip-duplicate
```

Diese Workflow-Datei stellt sicher, dass Ihr Modul immer gebaut, verpackt und optional veröffentlicht wird, sobald Änderungen im `main`-Zweig gepusht oder Pull Requests eingereicht werden. Sie garantiert eine konsistente Build-Umgebung und eine verlässliche Bereitstellung der Module.