using PluginManager.Api.Contracts;

namespace PluginManager.Api.Capabilities.Implementations.Utils;

public interface IContainerUtil : ICapability
{
    string GetSignText(Vector3Int position);
    int[] GetContainerItemTypes(Vector3Int position);
    Vector3Int[] GetContainersInArea(Vector3Int min, Vector3Int max);
    int MoveItemType(Vector3Int source, Vector3Int target, int itemType);
}
