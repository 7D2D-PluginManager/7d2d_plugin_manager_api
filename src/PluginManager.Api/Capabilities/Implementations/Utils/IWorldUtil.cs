using PluginManager.Api.Contracts;

namespace PluginManager.Api.Capabilities.Implementations.Utils;

public interface IWorldUtil : ICapability
{
    int GetTerrainHeight(int worldX, int worldZ);
    bool CanPlayerSpawnAt(Vector3 position);
    bool IsWaterAt(Vector3 position);
}
