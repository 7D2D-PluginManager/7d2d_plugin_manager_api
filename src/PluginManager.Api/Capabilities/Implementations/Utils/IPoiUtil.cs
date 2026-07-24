using PluginManager.Api.Contracts;

namespace PluginManager.Api.Capabilities.Implementations.Utils;

public interface IPoiUtil : ICapability
{
    Poi GetPoiAt(Vector3 position);
}
