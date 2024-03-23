namespace ServiceCollectionIntegratedModule.Module;

public class ModuleSettings
{
    /// <summary>
    /// Der Pfad zur Mediathek, dessen Metadaten verwaltet werden sollen.
    /// </summary>
    public string? MediaLibraryPath { get; set; }

    /// <summary>
    /// Die Dateiendungen, die überwacht werden sollenÍ
    /// </summary>
    public List<string> ExtensionsToWatch { get; set; } = [".m4v", ".mp4v", ".mov", ".jpg", ".jpeg", ".png", ".nfo", ".xml", ".srt", ".idx", ".sub"];
}