using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnPoint : MonoBehaviour
{
    public GameObject objectToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomPoint();
    }

    void SpawnRandomPoint()
    {
        var randomPoint = Random.insideUnitCircle.normalized * 23.5f;
        var randomPosition = new Vector3(randomPoint.x, 1.0f, randomPoint.y); // + Random.insideUnitSphere * radius;
        var go = Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
        go.GetComponent<Rigidbody>().velocity = -randomPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 1000) == 5)
        {
            SpawnRandomPoint();
        }
    }
}