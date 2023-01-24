using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullyBallScript : MonoBehaviour
{

    int BullyBall;




    private BullyBallScript instance;


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
        int BullyBall = GameObject.FindGameObjectsWithTag("BullyBall").Length;
        StartCoroutine("DestroyBalls");
        StartCoroutine("AddPlusFourBonus");

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {
        Destroy(gameObject);
        TimerScript.instance.SubtractTime();

    }


    IEnumerator DestroyBalls()
    {
        yield return new WaitForSeconds(30f);
        Destroy(gameObject);
    }





    IEnumerator AddPlusFourBonus()
    {
        yield return new WaitForSeconds(30f);

        if (GameObject.FindGameObjectsWithTag("BullyBall").Length == 5)
        {
            ScoreManager.instance.TinyBallBonus();
        } 


        else
        {
            ScoreManager.instance.SubtractScore();
        }
    }
}
