using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullyBallSpawnerScript : MonoBehaviour
{

    public GameObject bullyBall;
    public Transform bullyBallPos;
    public float bullyballSpeed;

    [SerializeField]
    float snipeInterval;

    public static BullyBallSpawnerScript instance;

    // Start is called before the first frame update


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }



    void Start()
    {
        StartSniping();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FireSniperBall()
    {
        GameObject SniperBallSpawn = Instantiate(bullyBall, bullyBallPos.position, Quaternion.identity);

        SniperBallSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -bullyballSpeed);
    }


    IEnumerator SniperStarting()
    {
        yield return new WaitForSeconds(5f);

        while (true)
        {
            FireSniperBall();

            yield return new WaitForSeconds(snipeInterval);
        }
    }


    public void StartSniping()
    {
        StartCoroutine("SniperStarting");
    }

    public void StopSniping()
    {
        StopCoroutine("SniperStarting");
    }
}

