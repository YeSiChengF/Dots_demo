using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public struct RotatingComponent : IComponentData
{
    public Vector3 Rotate;
}
