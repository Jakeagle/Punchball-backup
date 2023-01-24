using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperBall : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        StartSelfDestruct();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<BoxCollider2D>())
        {

        }
    }

    private void OnMouseDown()
    {

        ScoreManager.instance.SniperBonus();
        TimerScript.instance.AddTime();
        Destroy(gameObject);




    }

    IEnumerator DestroySniperBalls()
    {
        yield return new WaitForSeconds(20f);

        Destroy(gameObject);
        
    }

    public void StartSelfDestruct()
    {
        StartCoroutine("DestroySniperBalls");
    }

}