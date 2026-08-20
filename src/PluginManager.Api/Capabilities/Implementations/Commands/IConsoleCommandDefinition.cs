using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Commands;

public interface IConsoleCommandDefinition
{
    string Name { get; }
    string Description { get; }
    string Help { get; }
    int DefaultPermissionLevel { get; }
    DelegateProxy Callback { get; }
}
