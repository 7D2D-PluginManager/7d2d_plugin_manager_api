using System.Collections.Generic;
using PluginManager.Api.Contracts;

namespace PluginManager.Api.Capabilities.Implementations.Commands;

public interface IConsoleCommandContext
{
    IReadOnlyList<string> Args { get; }
    ClientInfo Sender { get; }
    void Reply(string message);
}
