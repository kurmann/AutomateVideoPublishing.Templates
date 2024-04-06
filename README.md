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
