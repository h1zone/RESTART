using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCalculation : MonoBehaviour
{
    public GameObject respawnPrefab;
    public GameObject[] respawns;

    private Dictionary<GameObject, float> distances = new Dictionary<GameObject, float>();

    void Start()
    {
    //    if (respawns == null)
            respawns = GameObject.FindGameObjectsWithTag("MapObj");

        foreach (GameObject respawn in respawns)
        {
            //     Debug.Log(respawn.name);

            var dist = Vector3.Distance(respawn.transform.position, this.transform.position);

            distances.Add(respawn, dist);

                //  print("Внесенно расстояние от " + this.ToString() + " до " + respawn.ToString() + " = " + dist);
        }
    }


    void Update()
    {
        
    }
}
