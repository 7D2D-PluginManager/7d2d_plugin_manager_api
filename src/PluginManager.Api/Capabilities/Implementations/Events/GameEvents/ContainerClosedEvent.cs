using PluginManager.Api.Contracts;
using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public sealed class ContainerClosedEvent(int entityId, Vector3Int position) : ProxyObject, IGameEvent
{
    public string EventName => nameof(ContainerClosedEvent);

    public int EntityId { get; set; } = entityId;
    public Vector3Int Position { get; set; } = position;
}
