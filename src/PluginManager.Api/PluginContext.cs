namespace PluginManager.Api;

public sealed class PluginContext
{
    public string Id { get; }
    public string RootDirectory { get; }

    public PluginContext(string id, string rootDirectory)
    {
        Id = id;
        RootDirectory = rootDirectory;
    }
}
