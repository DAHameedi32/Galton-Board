using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid_Generator : MonoBehaviour
{
    
    public GameObject peg;
    public float X;

    float AltX = X-1;
    public float Y;
    public float lattice_constant;
    
    public float offset_x = 0;
    public float offset_y = 0;

    public Transform Origin;

    // Start is called before the first frame update
    void Start()
    {
        for (float y = 0; y<Y; y++)
        {
            if(y%2 == 1)
            {
                offset_x = 2.5f;
                //hex assym:
                X = X-1;
                //hex sym:
                //X = AltX;
            }
            else
            {
                offset_x = 0.0f;
                X = X;
            }
            for (float x = 0; x < X; x++)
            {
                Vector3 pos = new Vector3(  Origin.position.x + x * lattice_constant + offset_x,
                                            Origin.position.y + y * lattice_constant + offset_y, 
                                            Origin.position.z
                                        );

                GameObject Site = Instantiate(peg, pos, Quaternion.identity) as GameObject;
                Site.GetComponent<Transform>().Rotate(-90.0f, 0, 0);

                Site.transform.SetParent(this.transform);
            }
        }
    }
}
