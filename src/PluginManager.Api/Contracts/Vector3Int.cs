using PluginManager.Api.Proxy;

namespace PluginManager.Api.Contracts;

public class Vector3Int(int x, int y, int z = 0) : ProxyObject
{
    public int X { get; } = x;
    public int Y { get; } = y;
    public int Z { get; } = z;

    public override bool Equals(object obj)
    {
        if (obj is not Vector3Int other)
            return false;

        return X == other.X && Y == other.Y && Z == other.Z;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 31 + X;
            hash = hash * 31 + Y;
            hash = hash * 31 + Z;
            return hash;
        }
    }
}