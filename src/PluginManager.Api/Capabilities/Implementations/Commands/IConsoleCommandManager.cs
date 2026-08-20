namespace PluginManager.Api.Capabilities.Implementations.Commands;

public interface IConsoleCommandManager : ICapability
{
    void RegisterCommand(IConsoleCommandDefinition definition);

    void DeregisterCommand(IConsoleCommandDefinition definition);
}
