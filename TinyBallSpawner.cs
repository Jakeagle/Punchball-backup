using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TinyBallSpawner : MonoBehaviour {

    public GameObject TinyBall;

    public GameObject[] gos;

    public GameObject SpawnPos;


    public static TinyBallSpawner instance;

    [SerializeField]
    float spawnInterval;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartSpawningTinyBalls();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnTinyBalls()
    {

        gos = new GameObject[10];
        for (int i = 0; i < gos.Length; i++)
        {
            GameObject clone = (GameObject)Instantiate(TinyBall, Vector2.zero, Quaternion.identity);

            gos[i] = clone;
        }
    }


    IEnumerator TinySpawning()
    {
        yield return new WaitForSeconds(5.5f);

        while (true)
        {
            SpawnTinyBalls();

            yield return new WaitForSeconds(spawnInterval);
        }
    }


    public void StartSpawningTinyBalls()
    {
        StartCoroutine("TinySpawning");
    }

    public void StopSpawningTinyBalls()
    {
        StopCoroutine("TinySpawning");
    }
}
