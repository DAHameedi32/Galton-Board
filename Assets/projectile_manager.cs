using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile_manager : MonoBehaviour
{
    
    public GameObject projectile;
    public GameObject Origin;

    public bool fire = false;
    void Update()
    {
        if (fire == true)
        {
            fire = false;
            Vector3 pos = new Vector3(Origin.transform.position.x + Random.Range(-0.1f, 0.1f), Origin.transform.position.y, Origin.transform.position.z);
            GameObject Bead = Instantiate(projectile, pos, Quaternion.identity) as GameObject;
            
        }
    }
}
