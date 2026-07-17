using System.Collections.Generic;

namespace PluginManager.Api.Capabilities.Implementations.Storage;

public interface IStorage : ICapability
{
    string Read(string scope, string collection, string key);
    void Write(string scope, string collection, string key, string value);
    bool Delete(string scope, string collection, string key);
    List<string> Keys(string scope, string collection);
    Dictionary<string, string> ReadAll(string scope, string collection);
}
