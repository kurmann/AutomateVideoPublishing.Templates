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

### Videoschnitt Modul Debug Konfiguration

Kurzname: **videoschnitt-module-debug**

Das `VideoschnittModulDebugTemplate` ist eine essentielle Hilfe für Entwickler, um schnell eine funktionierende Debug-Umgebung in Visual Studio Code für das Videoschnitt Modul einzurichten. Es generiert die `launch.json` und `tasks.json`, die für das Ausführen und Debuggen des Moduls in Visual Studio Code nötig sind.

#### Features Videoschnitt Modul Debug

- **Angepasste .NET Core Launch Konfiguration**: Ermöglicht das Debuggen der Anwendung mit detaillierten Einstellungen.
- **Vorkonfigurierte Build- und Watch-Tasks**: Unterstützt die Entwicklung mit Aufgaben zum Bauen und Beobachten des Projekts in Echtzeit.
- **Einfache Integration in den Workflow**: Durch die Voreinstellungen kann sofort mit dem Debuggen begonnen werden, ohne zusätzliche Konfigurationen vornehmen zu müssen.

#### Anwendung Videoschnitt Modul Debug

Nach Erstellung des Videoschnitt Moduls können Sie die Debug-Konfiguration hinzufügen:

```bash
dotnet new videoschnitt-module-debug -n IhrModulname -o .
```

Dieser Befehl platziert die entsprechenden Dateien in einem `.vscode`-Verzeichnis an der Wurzel des Projekts. Die resultierenden Dateien `launch.json` und `tasks.json` werden auf Ihr spezifisches Modul zugeschnitten sein.

Die `launch.json` Datei könnte so aussehen:

```json
{
    "version": "0.2.0",
    "configurations": [
        {
            "name": ".NET Core Launch (console)",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build",
            "program": "${workspaceFolder}/src/Application/bin/Debug/net8.0/Kurmann.Videoschnitt.ModuleName.Application.dll",
            "args": [],
            "cwd": "${workspaceFolder}",
            "stopAtEntry": false,
            "console": "internalConsole",
            "env": {
                "ASPNETCORE_ENVIRONMENT": "Development"
            }
        }
    ]
}
```

Und die `tasks.json` Datei stellt die notwendigen Aufgaben für den Build und das Watchen des Projekts bereit:

```json
{
    "version": "2.0.0",
    "tasks": [
        {
            "label": "build",
            "command": "dotnet",
            "type": "process",
            "args": [
                "build",
                "${workspaceFolder}/src/Application/Application.csproj",
                "/property:GenerateFullPaths=true",
                "/consoleloggerparameters:NoSummary;ForceNoAlign"
            ],
            "problemMatcher": "$msCompile"
        },
        {
            "label": "publish",
            "command": "dotnet",
            "type": "process",
            "args": [
                "publish",
                "${workspaceFolder}/src/Application/Application.csproj",
                "/property:GenerateFullPaths=true",
                "/consoleloggerparameters:NoSummary;ForceNoAlign"
            ],
            "problemMatcher": "$msCompile"
        },
        {
            "label": "watch",
            "command": "dotnet",
            "type": "process",
            "args": [
                "watch",
                "run",
                "--project",
                "${workspaceFolder}/src/Application/Application.csproj"
            ],
            "problemMatcher": "$msCompile"
        }
    ]
}
```

Mit dieser Konfiguration können Entwickler direkt in Visual Studio Code das Projekt bauen, veröffentlichen und in Echtzeit Veränderungen beobachten, was den Entwicklungsprozess erheblich vereinfacht und beschleunigt.

### Videoschnitt Entity Library

Kurzname: **videoschnitt-entitylib**

Das `VideoschnittEntityLibraryTemplate` ist speziell dafür entworfen worden, um die schnelle Erstellung von Class-Libraries zu unterstützen, die die Domänenlogik innerhalb des Videoschnitt Projekts repräsentieren. Es fördert einen funktionalen Ansatz durch die Verwendung der C# Functional Extensions Library und verbessert dadurch die Handhabung von Operationsergebnissen.

#### Features Videoschnitt Entity Library

- **C# Functional Extensions Nutzung**: Ermöglicht die Verwendung von erweiterten funktionalen Konzepten und Mustern, wie z.B. `Result<T>`.
- **Fokussierung auf Domänenlogik**: Ideal für die Entwicklung von Bibliotheken, die Geschäftslogik und Domänenmodelle enthalten.
- **Testprojekt Integration**: Generiert automatisch ein Testprojekt zur Sicherstellung der Qualität und Funktionalität der Domänenlogik.
- **.NET Class-Library Basis**: Bietet eine solide Grundlage und ein konsistentes Layout für .NET Class-Libraries.
- **Modularer Aufbau**: Unterstützt die Schaffung einer sauber strukturierten, modularen Codebasis.
- **Namespace-Konformität**: Gewährleistet eine konsistente Verwendung des `Kurmann.Videoschnitt` Stammbereichs für die Namensgebung.

#### Anwendung Videoschnitt Entity Library

Um die Entity Library zu erstellen, nutzen Sie den folgenden Befehl:

```bash
dotnet new videoschnitt-entitylib -n EntityLibName -o src
```

Daraufhin wird eine neue Class-Library im `src`-Verzeichnis erzeugt. Die resultierende Verzeichnisstruktur sowie die .csproj- und Code-Dateien sind speziell für die Anforderungen von Entitäten innerhalb des Videoschnitt Projekts ausgerichtet.

Auf Basis der bereitgestellten Struktur für das Entity Library Template und unter Anwendung des neuen Namensschemas wird die Verzeichnisstruktur wie folgt aussehen:

```text
EntityLibName/
├── .template.config/
├── Entities/
│   ├── Entities.csproj
│   └── SampleEntity.cs
├── Tests/
│   ├── GlobalUsings.cs
│   ├── SampleEntityTest.cs
│   └── Tests.csproj
└── EntityLibName.sln
```

Innerhalb des `Entities/`-Ordners finden Sie das Projekt für die Bibliothek, das die Entitätsklassen enthält, in diesem Fall repräsentiert durch `SampleEntity.cs`. Die `Tests/`-Ordnerstruktur ist für das zugehörige Testprojekt vorgesehen, wobei `SampleEntityTest.cs` als ein Beispiel für einen Unit-Test dient. 

`GlobalUsings.cs` in der Teststruktur könnte dazu verwendet werden, global verfügbare `using`-Direktiven für das gesamte Testprojekt zu definieren, um die Notwendigkeit wiederholter Direktiven in jedem Test zu vermeiden.

`EntityLibName.sln` ist die zugehörige Solution-Datei, welche beide Projekte (die Entitätsbibliothek und das Testprojekt) für eine einfachere Verwaltung in Entwicklungs-Tools wie Visual Studio zusammenfasst.

Diese Konfiguration gewährleistet eine klare Trennung zwischen der Implementierung der Geschäftslogik und den Tests, was für eine saubere Codebasis und leichtere Wartbarkeit sorgt.

### Videoschnitt Entity Library GitHub Workflow

Kurzname: **videoschnitt-entitylib-wf**

Das `VideoschnittEntityLibraryWorkflowTemplate` schafft eine CI/CD-Pipeline mittels GitHub Actions für das automatische Bauen, Testen und Veröffentlichen von Entity Libraries des Videoschnitt Projekts auf NuGet.org.

#### Features Videoschnitt Entity Library GitHub Workflow

- **Automatisierte CI/CD-Pipeline**: Konfiguriert GitHub Actions für die Automatisierung des Build- und Pack-Prozesses.
- **.NET Core Setup**: Einrichtung und Verwendung einer spezifischen .NET-Version für den Build-Prozess.
- **Abhängigkeitsmanagement**: Wiederherstellung der benötigten Pakete vor dem Build.
- **NuGet-Paketierung**: Erstellt NuGet-Pakete aus dem Class-Library-Projekt.
- **NuGet-Veröffentlichung**: Stellt die erstellten Pakete auf NuGet.org bereit und verwendet dabei GitHub Secrets, um den NuGet API-Key sicher zu handhaben.

#### Anwendung Videoschnitt Entity Library GitHub Workflow

Die Einrichtung der CI/CD-Pipeline für die Entity Library erfolgt durch den folgenden Befehl:

```bash
dotnet new videoschnitt-entitylib-wf -o .
```

Durch diesen Befehl wird eine `dotnet.yml` Workflow-Datei im `.github/workflows`-Verzeichnis des Projekts erstellt, die folgende Schritte für den CI/CD-Prozess vorsieht:

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

Diese Konfiguration sorgt dafür, dass Ihre Entity Library automatisch gebaut und verpackt wird, und bei Bedarf – wenn zum Beispiel ein Tag gepusht wird – auf NuGet.org veröffentlicht wird. Durch den Einsatz von `--skip-duplicate` wird verhindert, dass bereits existierende Paketversionen zu Konflikten führen.

Die CI/CD-Pipeline ist ein wichtiger Bestandteil moderner Softwareentwicklungsprozesse und stellt sicher, dass Ihre Bibliothek immer nach den neuesten Änderungen neu gebaut, getestet und veröffentlicht wird.

## Empfehlungen

Für eine effiziente Nutzung der Videoschnitt Templates und zur Sicherstellung eines reibungslosen Entwicklungsprozesses sind folgende Praktiken ratsam:

### NuGet API-Key Verwaltung

Es ist entscheidend, den `NUGET_API_KEY` sicher in den GitHub Secrets des Repositories zu speichern, um die Automatisierung der Paketveröffentlichung auf NuGet.org zu ermöglichen. Dieser Schlüssel sollte niemals öffentlich gemacht werden und kann vertraulich über `Settings > Secrets > Actions` im Repository hinterlegt werden.

### Strukturierte Modulerstellung

Die kombinierte Verwendung der Templates `scimodule`, `scimodule-github-workflow` und `scimodule-vscode-debugconfig` wird empfohlen, um eine kohärente Entwicklungsumgebung zu etablieren. Die Konfiguration der Module sollte durch dedizierte Abschnitte in der `appsettings.json` erfolgen, was die Flexibilität bei der Verwaltung der Konfigurationseinstellungen erhöht.

### Modulkonfiguration

Durch die Anwendung des `IOptions`-Patterns lässt sich eine klare und einfache Handhabung der Konfigurationswerte erreichen. Die `ModuleSettings`-Klasse dient dabei als Basis für die Konfiguration und ermöglicht eine einfache Anpassung und Erweiterung.

## Lizenz

Dieses Projekt steht unter der Apache 2.0 Lizenz. Details finden Sie in der [LICENSE](LICENSE) Datei.

## Mitwirken

Während eine aktive Beteiligung nicht erwartet wird, sind Interessierte, die zum Projekt beitragen möchten, herzlich eingeladen, sich bei mir zu melden.
