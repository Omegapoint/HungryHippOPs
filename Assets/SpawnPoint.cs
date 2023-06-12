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
        Vector3 velocityTowardsCenter = -randomPosition.normalized * Constants.POINT_INITIAL_SPEED_MAGNITUDE;
        float randomAngleOffset = Random.Range(-Constants.POINT_INITIAL_ANGLE_OFFSET_MAX, Constants.POINT_INITIAL_ANGLE_OFFSET_MAX);
        Vector3 velocityRotatedRandomly = Quaternion.Euler(0, randomAngleOffset, 0) * velocityTowardsCenter;
        go.GetComponent<Rigidbody>().velocity = velocityRotatedRandomly;
    }

    IEnumerator SpawnPointsWithInterval()
    {
        SpawnRandomPoint();
        var spawnInterval = Random.Range(0.1f, 3f);

        yield return new WaitForSeconds(spawnInterval);
        StartCoroutine(SpawnPointsWithInterval());
    }
}