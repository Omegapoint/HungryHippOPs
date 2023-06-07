using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Vector3 origin = new Vector3(0, 1f, 0); // Vector3.zero;
    public float radius = 10;


    // Start is called before the first frame update
    void Start()
    {
        var randomPosition = origin; //+ Random.insideUnitSphere * radius;

        Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
        Debug.Log("================= " + objectToSpawn.transform.position);
        randomPosition.y = 0.5f;
        randomPosition.x += 10f;
    }

    // Update is called once per frame
    void Update()
    {
    }
}