using PluginManager.Api.Contracts;
using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public sealed class PoiQuestLockedEvent(Vector3Int markerPosition, int[] ownerEntityIds) : ProxyObject, IGameEvent
{
    public string EventName => nameof(PoiQuestLockedEvent);

    public Vector3Int MarkerPosition { get; set; } = markerPosition;
    public int[] OwnerEntityIds { get; set; } = ownerEntityIds;
}
