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
- **Konfigurationsmodell**: Vollständige Unterstützung des .NET `IOptions`-Pattern einschliesslich Beispiel-Integration von .NET User Secrets.

#### Anwendung SCI Module

```bash
dotnet new scimodule -n Projektname -o src
```

ergibt ein Modul im "src"-Verzeichnis mit den .NET-Projekten

```text
working-directory/
└── src/
    └── Kurmann.Videoschnitt.Projektname
    └── Kurmann.Videoschnitt.Projektname.Application
```

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
dotnet new entitylib -n EntityLibName -o src
```

ergibt eine Class-Library im "src"-Verzeichnis mit den .NET-Projekten

```text
working-directory/
└── src/
    └── Kurmann.Videoschnitt.EntityLibName
    └── Kurmann.Videoschnitt.EntityLibName.Tests
```

Dieses Setup ist optimal für Entwickler, die sich auf die Implementierung von Domänenlogik mit einem klaren Fokus auf funktionale Programmierprinzipien und testgetriebene Entwicklung konzentrieren möchten.

### Entity Library GitHub Workflow

Kurzname: **entitylib-github-workflow**

Das `Entity Library GitHub Workflow` Template erweitert die Sammlung von .NET Templates um eine automatisierte CI/CD Pipeline speziell für die `Entity Library`. Es generiert eine GitHub Actions Workflow-Konfiguration, die spezifisch für das Bauen, Testen und optional das Veröffentlichen einer .NET Class-Library, welche die Domänenlogik beinhaltet, auf NuGet.org ausgelegt ist.

#### Features Entity Library GitHub Workflow

- **Automatisierte CI/CD Pipeline**: Konfiguriert GitHub Actions für das automatische Bauen und Testen der Entity Library bei jedem Push oder Pull Request.
- **NuGet-Veröffentlichung**: Ermöglicht die automatische Veröffentlichung der gebauten Library auf NuGet.org, abhängig von spezifischen Triggern oder Tags.
- **Angepasste Workflow-Events**: Unterstützt verschiedene GitHub Event-Typen wie `push`, `pull_request` oder manuell ausgelöste Workflows.
- **Testautomatisierung**: Führt automatisch alle definierten Unit- und Integrationstests als Teil des CI-Prozesses aus.
- **Flexibilität und Anpassbarkeit**: Ermöglicht einfache Anpassungen der Workflow-Schritte, um spezifische Anforderungen oder Projektkonfigurationen zu berücksichtigen.

#### Anwendung Entity Library GitHub Workflow

```bash
dotnet new entitylib-github-workflow -o .
```

erzeugt folgende Verzeichnisstruktur im Arbeitsverzeichnis

```text
working-directory/
└── .github/
    └── workflows/
        └── entitylib-ci-cd.yml
```

Die Konfigurationsdatei `entitylib-ci-cd.yml` ist so voreingestellt, dass sie die Entity Library bei jedem `push` auf den `main`-Zweig oder bei jedem `pull_request` gegen den `main`-Zweig baut und testet. Optional kann die Konfiguration so erweitert werden, dass erfolgreiche Builds automatisch auf NuGet.org veröffentlicht werden, sobald ein neuer Release-Tag gepusht wird.

Dieses Template ist eine essenzielle Erweiterung für Teams, die die Entity Library in ihre Entwicklungspipeline integrieren möchten, um eine kontinuierliche Qualitätssicherung und -verbesserung der Domänenlogik zu gewährleisten.

## Empfehlungen

### NuGet API Key

Um die automatische Veröffentlichung Ihrer NuGet-Pakete über die GitHub Actions Workflow zu ermöglichen, ist es notwendig, den `NUGET_API_KEY` in den GitHub Secrets jedes Repositories zu hinterlegen. Dieser API-Key ermöglicht es GitHub Actions, die Pakete in Ihrem Namen auf NuGet.org zu veröffentlichen. Sie können den API-Key von Ihrem NuGet.org-Konto erhalten und sollten diesen sicher im Abschnitt Settings > Secrets > Actions Ihres GitHub-Repositories speichern. Durch das Setzen dieses Secrets stellen Sie sicher, dass Ihre CI/CD Pipeline die Pakete erfolgreich auf NuGet.org pushen kann, ohne Ihren API-Key offenlegen zu müssen.

### Komplette Erstellung eines SCI Modul Repository

Zum Erstellen eines kompletten Service Collection Integrated Moduls mitsamt Repository-Struktur wird die kombination der Templates `scimodule`, `scimodule-github-workflow` und `scimodule-vscode-debugconfig` empfohlen.

Bitte vorher zum **Wurzelverzeichnis** des neu erstellte GitHub-**Repositorys** wechseln.

Erstellt ein Service Collection Integrated Modul um "src"-Verzeichnis und erzeugt eine passende GitHub Actions Workflow-Konfiguration und eine passende vordefinierte Debug-Konfiguration für Visual Studio Code.

```bash
export PROJEKTNAME="MeinProjekt"
dotnet new scimodule -n $PROJEKTNAME -o src
dotnet new scimodule-github-workflow -o .
dotnet new scimodule-vscode-debugconfig -n $PROJEKTNAME -o .

```

### Konfiguration von Modulen

Wenn Sie ein Modul über unser .NET-Template erstellen, wird die Konfiguration des Moduls durch eine dedizierte Sektion in der Konfigurationsdatei ermöglicht. Diese Sektion ist nach dem Muster `Kurmann.Videoschnitt.YourModuleName` benannt, wobei `YourModuleName` der Name Ihres spezifischen Moduls ist. 

#### Anpassung der Moduleinstellungen

Innerhalb jeder Modul-Konfigurationssektion können Sie die `ModuleSettings`-Klasse anpassen, um verschiedene Konfigurationswerte zu definieren. Diese Werte können Sie dann einfach in der `appsettings.json` oder durch Umgebungsvariablen konfigurieren.

#### Beispiel

Für ein Modul namens `VideoEditor` würden Sie eine Sektion `Kurmann.Videoschnitt.VideoEditor` in Ihrer `appsettings.json` hinzufügen:

```json
{
  "Kurmann.Videoschnitt.VideoEditor": {
    "OutputPath": "/path/to/output"
  }
}
```

Anschließend passen Sie die `ModuleSettings`-Klasse in Ihrem Modul an, um den `OutputPath` als Konfigurationseinstellung zu definieren:

```csharp
public class ModuleSettings
{
    public string OutputPath { get; set; } = "Standardwert";
}
```

#### Nutzung in Ihrer Anwendung

Durch die Anwendung des `IOptions`-Patterns können Sie diese Konfigurationswerte leicht in Ihrem Modul abrufen und verwenden. Dies bietet Ihnen eine flexible und starke Typisierung für die Verwaltung von Konfigurationseinstellungen.

#### Vorteile

- **Flexibilität:** Jedes Modul kann unabhängig konfiguriert werden, was die Anpassung und Erweiterung erleichtert.
- **Einfachheit:** Die Verwendung der `ModuleSettings`-Klasse zusammen mit dem `IOptions`-Pattern macht den Zugriff auf Konfigurationswerte klar und einfach.
- **Anpassbarkeit:** Sie können Konfigurationswerte leicht ändern, ohne den Code des Moduls anpassen zu müssen, sei es durch Bearbeitung der `appsettings.json` oder Setzen von Umgebungsvariablen.

Diese Struktur ermöglicht es Ihnen, Ihre Anwendung modular und flexibel zu gestalten, mit klaren und einfachen Konfigurationsmechanismen für jedes Modul.
