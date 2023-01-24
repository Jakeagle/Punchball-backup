using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBallSpawner : MonoBehaviour
{

    [SerializeField]
    float maxX;

    [SerializeField]
    float spawnInterval;

    public GameObject[] DeathBalls;

    public static DeathBallSpawner instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start()
    {

        

        StartDeathBalls();

    }

    // Update is called once per frame
    void Update()
    {

    }


    void SpawnCandy()
    {
        int rand = Random.Range(0, DeathBalls.Length);

        float randomX = Random.Range(-maxX, maxX);

        Vector3 randomPos = new Vector3(randomX, transform.position.y, transform.position.z);

        Instantiate(DeathBalls[rand], randomPos, transform.rotation);
    }



    IEnumerator SpawnDeathballs()
    {
        yield return new WaitForSeconds(4.5f);

        while (true)
        {
            SpawnCandy();

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    public void StartDeathBalls()
    {
        StartCoroutine("SpawnDeathballs");
    }

    public void StopSpawningCandies()
    {
        StopCoroutine("SpawnDeathballs");
    }

}
