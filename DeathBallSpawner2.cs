using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBallSpawner2 : MonoBehaviour
{

    [SerializeField]
    float maxX;

    [SerializeField]
    float spawnInterval;

    public GameObject DeathBalls;

    public static DeathBallSpawner2 instance;

    public Transform deathBallpos;

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
       GameObject DeatballSpawn = Instantiate(DeathBalls, deathBallpos.position, Quaternion.identity);
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
