using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Data_Dumper : MonoBehaviour
{
    public string fileName = "data.txt"; // Name of the text file to write to
    
    public bool Collect_Data = false;

    void Update()
    {
        if(Collect_Data == true)
        {
            Collect_Data = false;
            // Path to the file
            string filePath = Path.Combine(Application.persistentDataPath, fileName);

             // Open a stream writer to write to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                //get all gameObjects with tag projectile:
                GameObject[] beads = GameObject.FindGameObjectsWithTag("Projectile");
                // Write data to the file
                writer.WriteLine("total beads: " + beads.Length);
                foreach (GameObject a in beads)
                {
                    writer.WriteLine(a.transform.position.x);
                }
            }
        Debug.Log("Data dumped to file: " + filePath);

        }
    }
}
