using PluginManager.Api.Contracts;
using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public class TileEntityAccessAttemptEvent(
    int entityId,
    TileEntity tileEntity
) : ProxyObject, IGameEvent
{
    public string EventName => nameof(TileEntityAccessAttemptEvent);

    public int EntityId { get; set; } = entityId;
    public TileEntity TileEntity { get; set; } = tileEntity;
}