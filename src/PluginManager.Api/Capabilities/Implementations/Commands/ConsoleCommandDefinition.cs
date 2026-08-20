using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Commands;

public class ConsoleCommandDefinition : ProxyObject, IConsoleCommandDefinition
{
    public string Name { get; }
    public string Description { get; }
    public string Help { get; }
    public int DefaultPermissionLevel { get; }
    public DelegateProxy Callback { get; }

    public ConsoleCommandDefinition(string name, string description, string help, int defaultPermissionLevel,
        DelegateProxy callback)
    {
        Name = name;
        Description = description;
        Help = help;
        DefaultPermissionLevel = defaultPermissionLevel;
        Callback = callback;
    }
}
