using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid_Generator : MonoBehaviour
{
    
    public GameObject peg;
    public float X;

    public float Y;
    public float lattice_constant;

    public Transform Origin;

    // Start is called before the first frame update
    void Start()
    {
        for (float y = 0; y<Y; y++)
        {
            for (float x = 0; x < X; x++)
            {
                Vector3 pos = new Vector3(  Origin.position.x + x * lattice_constant,
                                            Origin.position.y + y * lattice_constant, 
                                            Origin.position.z
                                        );

                GameObject Site = Instantiate(peg, pos, Quaternion.identity) as GameObject;
                Site.GetComponent<Transform>().Rotate(-90.0f, 0, 0);

                Site.transform.SetParent(this.transform);
            }
        }
    }
}
