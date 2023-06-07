using UnityEngine;

public static class Extensions
{
    public static Vector3 CopyVector(this Vector3 input)
    {
        return new Vector3(x: input.x, y: input.y, z: input.z);
    }
}