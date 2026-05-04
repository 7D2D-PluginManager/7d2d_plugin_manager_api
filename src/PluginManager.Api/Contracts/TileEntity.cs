using PluginManager.Api.Proxy;

namespace PluginManager.Api.Contracts;

public class TileEntity(int id, TileEntityType type, Vector3Int position) : ProxyObject
{
    public int Id { get; } = id;
    public TileEntityType Type { get; } = type;
    public Vector3Int Position { get; } = position;
}