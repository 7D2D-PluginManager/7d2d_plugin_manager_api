using PluginManager.Api.Proxy;

namespace PluginManager.Api.Contracts;

public class ItemInfo(string name, string localizedName) : ProxyObject
{
    public string Name { get; } = name;
    public string LocalizedName { get; } = localizedName;
}
