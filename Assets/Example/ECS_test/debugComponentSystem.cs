using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class debugComponentSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref debugComponent debug) => {
            Debug.Log(debug.Num);
            debug.Num += 1;
        });

    }
}
