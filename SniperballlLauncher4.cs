using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperballlLauncher4 : MonoBehaviour
{

    public GameObject sniperBall;
    public Transform sniperBallPos;
    public float SniperBallSpeed;

    [SerializeField]
    float snipeInterval;

    // Start is called before the first frame update
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
        GameObject SniperBallSpawn = Instantiate(sniperBall, sniperBallPos.position, Quaternion.identity);

        SniperBallSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2(-SniperBallSpeed, SniperBallSpeed);
    }


    IEnumerator SniperStarting()
    {
        yield return new WaitForSeconds(10f);

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

