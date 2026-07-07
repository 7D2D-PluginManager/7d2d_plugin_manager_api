using PluginManager.Api.Contracts;

namespace PluginManager.Api.Capabilities.Implementations.Utils;

public interface IClaimUtil : ICapability
{
    int GetClaimSize();
    LandClaim[] GetLandClaims();
}
