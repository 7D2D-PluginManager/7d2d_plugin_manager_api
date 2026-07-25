namespace PluginManager.Api.Capabilities.Implementations.Utils;

public interface IBlockUtil : ICapability
{
    bool IsLandClaim(string blockName);
    bool IsBedroll(string blockName);
}
