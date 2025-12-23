using PluginManager.Api.Contracts;

namespace PluginManager.Api.Capabilities.Implementations.Utils;

public interface IGamePrefsUtil : ICapability
{
    string GetString(GamePrefs property);
    float GetFloat(GamePrefs property);
    int GetInt(GamePrefs property);
    bool GetBool(GamePrefs property);
    object GetObject(GamePrefs property);
    GamePrefsType GetPrefType(GamePrefs property);
}