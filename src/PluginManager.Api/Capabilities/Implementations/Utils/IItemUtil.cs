using PluginManager.Api.Contracts;

namespace PluginManager.Api.Capabilities.Implementations.Utils;

public interface IItemUtil : ICapability
{
    ItemInfo GetItem(string name);
    bool SpawnItemInInventory(int entityId, string name, int count);
}
