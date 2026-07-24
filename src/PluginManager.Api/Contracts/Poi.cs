using PluginManager.Api.Proxy;

namespace PluginManager.Api.Contracts;

public class Poi(
    Vector3Int boundingBoxPosition,
    Vector3Int boundingBoxSize,
    string name,
    bool hasQuestLock,
    bool isQuestLockActive,
    bool questLockElapsed,
    int[] questOwnerEntityIds,
    ulong lockedOutUntil) : ProxyObject
{
    public Vector3Int BoundingBoxPosition { get; } = boundingBoxPosition;
    public Vector3Int BoundingBoxSize { get; } = boundingBoxSize;
    public string Name { get; } = name;
    public bool HasQuestLock { get; } = hasQuestLock;
    public bool IsQuestLockActive { get; } = isQuestLockActive;
    public bool QuestLockElapsed { get; } = questLockElapsed;
    public int[] QuestOwnerEntityIds { get; } = questOwnerEntityIds;
    public ulong LockedOutUntil { get; } = lockedOutUntil;
}
