using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBallSpawner : MonoBehaviour
{

    [SerializeField]
    float maxX;

    [SerializeField]
    float spawnInterval;

    public GameObject TimeBall;

    public static TimeBallSpawner instance;

    public Transform TimeBallpos;

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
        GameObject TimeballSpawn = Instantiate(TimeBall, TimeBallpos.position, Quaternion.identity);
        Debug.Log("Spawned");

    }



    IEnumerator SpawnDeathballs()
    {
        yield return new WaitForSeconds(15f);

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
