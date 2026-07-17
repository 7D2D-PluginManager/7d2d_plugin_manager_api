using System.Collections.Generic;
using PluginManager.Api.Capabilities.Implementations.Storage;

namespace PluginManager.Api;

public sealed class PluginStorage
{
    private readonly IStorage _storage;
    private readonly string _scope;

    public PluginStorage(IStorage storage, string scope)
    {
        _storage = storage;
        _scope = scope;
    }

    public string Read(string collection, string key) => _storage.Read(_scope, collection, key);

    public void Write(string collection, string key, string value) => _storage.Write(_scope, collection, key, value);

    public bool Delete(string collection, string key) => _storage.Delete(_scope, collection, key);

    public List<string> Keys(string collection) => _storage.Keys(_scope, collection);

    public Dictionary<string, string> ReadAll(string collection) => _storage.ReadAll(_scope, collection);
}
