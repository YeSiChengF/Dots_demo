using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCube : MonoBehaviour
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
        int y=0;
        for (int i = 0; i < CubeNum; i++)
        {
            GameObject temp= GameObject.Instantiate(cube,this.transform);
            int xIndex = i % LineNum;
            temp.transform.position = new Vector3(xIndex * 20, y);
            if (i % LineNum == 0)
                y += 20;
            temp.AddComponent<Rotating>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
