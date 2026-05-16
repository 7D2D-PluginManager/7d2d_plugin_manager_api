using PluginManager.Api.Contracts;
using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public sealed class GameMessageEvent(GameMessages type, int mainEntity, int secondaryEntity) : ProxyObject, IGameEvent
{
    public string EventName => nameof(GameMessageEvent);

    public GameMessages Type { get; set; } = type;
    public int MainEntity { get; set; } = mainEntity;
    public int SecondaryEntity { get; set; } = secondaryEntity;
}