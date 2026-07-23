using PluginManager.Api.Proxy;

namespace PluginManager.Api.Contracts;

public class DroppedBackpack(bool found, int ownerEntityId, string ownerId, int droppedWorldMinutes) : ProxyObject
{
    public bool Found { get; } = found;
    public int OwnerEntityId { get; } = ownerEntityId;
    public string OwnerId { get; } = ownerId;
    public int DroppedWorldMinutes { get; } = droppedWorldMinutes;
}
