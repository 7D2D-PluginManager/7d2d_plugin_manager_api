using PluginManager.Api.Proxy;

namespace PluginManager.Api.Contracts;

public class LandClaim(Vector3Int position, string ownerId) : ProxyObject
{
    public Vector3Int Position { get; } = position;
    public string OwnerId { get; } = ownerId;
}
