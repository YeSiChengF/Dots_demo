using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class debugEntity : MonoBehaviour,IConvertGameObjectToEntity
{
    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        dstManager.AddComponentData<debugComponent>(entity, new debugComponent { Num = 0 });
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
