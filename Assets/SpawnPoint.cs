using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnPoint : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float startDelay = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPointsWithInterval());
        StartCoroutine(SpawnPointsWithInterval());
        StartCoroutine(SpawnPointsWithInterval());
        StartCoroutine(SpawnPointsWithInterval());
    }

    void SpawnRandomPoint()
    {
        var randomPoint = Random.insideUnitCircle.normalized * 23.5f;
        var randomPosition = new Vector3(randomPoint.x, 1.0f, randomPoint.y); // + Random.insideUnitSphere * radius;
        var go = Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
        go.GetComponent<Rigidbody>().velocity = -randomPosition;
    }

    IEnumerator SpawnPointsWithInterval()
    {
        SpawnRandomPoint();
        var spawnInterval = Random.Range(0.1f, 3f);

        yield return new WaitForSeconds(spawnInterval);
        StartCoroutine(SpawnPointsWithInterval());
    }
}