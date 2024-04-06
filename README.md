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

### Videoschnitt Modul

Kurzname: **videoschnitt-module**

Das `VideoschnittModulTemplate` ist speziell für die schnelle Erstellung von Modulen konzipiert, die nahtlos mit der `IServiceCollection` für Dependency Injection integriert werden können, mit einem starken Fokus auf Modularität und Event-Driven Design.

#### Features Videoschnitt Modul

- **IServiceCollection Integration**
- **Modulare Architektur**
- **Event-Driven Design**
- **Operationsergebnis-Typen**
- **Einfache Integration**
- **Namespace-Unterstützung**: `Kurmann.Videoschnitt`
- **Konfigurationsmodell**

#### Anwendung Videoschnitt Modul

```bash
dotnet new videoschnitt-module -n Projektname -o src
```

ergibt ein Modul im "src"-Verzeichnis mit dem Namespace `Kurmann.Videoschnitt.Projektname`.

### Videoschnitt Modul Workflow

Kurzname: **videoschnitt-module-wf**

Erzeugt eine GitHub Actions Workflow-Konfiguration, speziell für das Bauen und Publizieren eines Videoschnitt Moduls auf NuGet.org.

#### Features Videoschnitt Modul Workflow

- **Automatisierte CI/CD Pipeline für Videoschnitt Module**

#### Anwendung Videoschnitt Modul Workflow

```bash
dotnet new videoschnitt-module-wf -o .
```

erzeugt eine passende GitHub Actions Workflow-Konfiguration im `.github/workflows/` Verzeichnis.

### Videoschnitt Modul Debug Konfiguration

Kurzname: **videoschnitt-module-debug**

Bietet eine vorkonfigurierte Debug-Umgebung für die Entwicklung eines Videoschnitt Moduls in Visual Studio Code.

#### Features Videoschnitt Modul Debug

- **Vordefinierte Debug- und Task-Konfigurationen** für VSCode

#### Anwendung Videoschnitt Modul Debug

```bash
dotnet new videoschnitt-module-debug -n Projektname -o .
```

erzeugt eine Debug-Konfiguration im `.vscode/` Verzeichnis des Projekts.

### Videoschnitt Entity Library

Kurzname: **videoschnitt-entitylib**

Entwickelt, um die Erstellung von Class-Libraries zu erleichtern, die Geschäftslogik und Domänenmodelle enthalten, mit einem Schwerpunkt auf funktionaler Programmierung und Testautomatisierung.

#### Features Videoschnitt Entity Library

- **C# Functional Extensions**
- **Fokussiert auf Domänenlogik**
- **Test-Projekt Integration**
- **.NET Class-Library Basis**
- **Modularer Aufbau**
- **Namespace-Unterstützung**: `Kurmann.Videoschnitt`

#### Anwendung Videoschnitt Entity Library

```bash
dotnet new videoschnitt-entitylib -n EntityLibName -o src
```

ergibt eine Class-Library im "src"-Verzeichnis unter `Kurmann.Videoschnitt.EntityLibName`.

### Empfehlungen

Für eine effiziente und sichere Veröffentlichung Ihrer Pakete auf NuGet.org, vergessen Sie nicht, den `NUGET_API_KEY` in den GitHub Secrets zu hinterlegen. Darüber hinaus wird die Kombination der Templates `videoschnitt-module`, `videoschnitt-module-wf` und `videoschnitt-module-debug` für eine umfassende Entwicklungsumgebung empfohlen. Die Konfiguration der Module erfolgt über dedizierte Abschnitte in der `appsettings.json`, was die Flexibilität und Anpassungsfähigkeit der Modulentwicklung erheblich erhöht.