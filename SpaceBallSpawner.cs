using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceBallSpawner : MonoBehaviour
{

    public static SpaceBallSpawner instance;

 

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    public GameObject spaceBall;
    public Transform spaceBallPos;

    [SerializeField]
    float ReleaseInterval;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("WaitTime");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FireSpaceBall()
    {
        GameObject SpaceBallSpawn = Instantiate(spaceBall, spaceBallPos.position, Quaternion.identity);
        Debug.Log("Spawned");

    }



    IEnumerator FiringSpaceballs()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            FireSpaceBall();

            yield return new WaitForSeconds(ReleaseInterval);
        }


    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(4.2f);

        StartCoroutine("FiringSpaceballs");
    }


    public void StartReleasing()
    {
        StartCoroutine("FiringSpaceballs");
    }


    public void StopReleasing()
    {
        StopCoroutine("FiringSpaceBalls");
    }

}
