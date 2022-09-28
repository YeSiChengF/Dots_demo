using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class RotatingEntity : MonoBehaviour,IConvertGameObjectToEntity
{
    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        dstManager.AddComponentData<RotatingComponent>(entity, new RotatingComponent { Rotate = Vector3.left });
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
