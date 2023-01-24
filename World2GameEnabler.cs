using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class World2GameEnabler : MonoBehaviour
{
    public GameObject StartBall1;
    public GameObject StartBall2;
    public GameObject StartBall3;
    public GameObject StartBall4;
    public GameObject TimerText;
    public GameObject Labeltext;
    public GameObject Score1;
    public GameObject Score2;
    public GameObject HighScore;
    public GameObject CurrentScore;
    public GameObject VanillaBallSpawner;
   
   
  
    

    void Start()
    {
        StartBall1.SetActive(false);
        StartBall2.SetActive(false);
        StartBall3.SetActive(false);
        StartBall4.SetActive(false);
        TimerText.SetActive(false);
        Labeltext.SetActive(false);
        Score1.SetActive(false);
        Score2.SetActive(false);
        HighScore.SetActive(false);
        CurrentScore.SetActive(false);
        VanillaBallSpawner.SetActive(false);
      
      
        StartCoroutine("StartGame");


    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(4.2f);

        StartBall1.SetActive(true);
        StartBall2.SetActive(true);
        StartBall3.SetActive(true);
        StartBall4.SetActive(true);
        TimerText.SetActive(true);
        Labeltext.SetActive(true);
        Score1.SetActive(true);
        Score2.SetActive(true);
        HighScore.SetActive(true);
        CurrentScore.SetActive(true);
        VanillaBallSpawner.SetActive(true);
     
    }
}