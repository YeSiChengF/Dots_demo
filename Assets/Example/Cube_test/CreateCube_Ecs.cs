using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using Unity.Transforms;

public class CreateCube_Ecs : MonoBehaviour
{
    [SerializeField]
    private int CubeNum;
    [SerializeField]
    private int LineNum;
    private GameObject cube;


    // Start is called before the first frame update
    void Start()
    {
        cube=Resources.Load<GameObject>("Cube");
        GameObjectConversionSettings gameObjectConversionSettings = GameObjectConversionSettings.FromWorld(World.DefaultGameObjectInjectionWorld, null);
        Entity tempEntityPrefab = GameObjectConversionUtility.ConvertGameObjectHierarchy(cube, gameObjectConversionSettings);
        EntityManager entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        int y=0;
        for (int i = 0; i < CubeNum; i++)
        {
            Entity tempCube= entityManager.Instantiate(tempEntityPrefab);
            Translation translation = entityManager.GetComponentData<Translation>(tempCube);
            int xIndex = i % LineNum;
            entityManager.SetComponentData<Translation>(tempCube, new Translation { Value = new Vector3(xIndex * 20, y) });
            if (i % LineNum == 0)
                y += 20;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
