using PluginManager.Api.Contracts;
using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public sealed class BlockPlacedEvent(int entityId, Vector3Int position, string blockName) : ProxyObject, IGameEvent
{
    public string EventName => nameof(BlockPlacedEvent);

    public int EntityId = entityId;
    public Vector3Int Position = position;
    public string BlockName = blockName;
}
