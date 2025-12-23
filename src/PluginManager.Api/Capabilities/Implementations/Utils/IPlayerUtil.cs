using System.Collections.Generic;
using PluginManager.Api.Contracts;

namespace PluginManager.Api.Capabilities.Implementations.Utils;

public interface IPlayerUtil : ICapability
{
    void Kick(int entityId, string reason = "");
    void Teleport(int entityId, Vector3 position);
    void PlaySound(int entityId, string soundName, int distance);
    void PrintToChat(int entityId, string message);
    bool IsPlayer(int entityId);
    bool IsPlayerInVehicle(int entityId);
    Vector3 GetPlayerPosition(int entityId);
    LandClaimOwner GetClaimOwner(int entityId, Vector3Int position);
    ClientInfo GetClientInfoByEntityId(int entityId);
    IEnumerable<ClientInfo> GetClientInfoList();
}