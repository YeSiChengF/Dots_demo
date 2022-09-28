using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class RotatingComponentSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref RotatingComponent rotatingComponet) => rotatingComponet.Rotate = new Vector3(Random.Range(1, 10),0,1)); 
    }
}
