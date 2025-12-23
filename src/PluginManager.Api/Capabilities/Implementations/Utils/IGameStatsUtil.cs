using PluginManager.Api.Contracts;

namespace PluginManager.Api.Capabilities.Implementations.Utils;

public interface IGameStatsUtil : ICapability
{
    string GetString(GameStats property);
    float GetFloat(GameStats property);
    int GetInt(GameStats property);
    bool GetBool(GameStats property);
    object GetObject(GameStats property);
    GameStatsType GetStatType(GameStats property);
}