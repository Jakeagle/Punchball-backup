using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class World4GameEnabler : MonoBehaviour
{
   
    public GameObject TimerText;
    public GameObject Labeltext;
    public GameObject Score1;
    public GameObject Score2;
    public GameObject HighScore;
    public GameObject CurrentScore;
   

    void Start()
    {
       
        TimerText.SetActive(false);
        Labeltext.SetActive(false);
        Score1.SetActive(false);
        Score2.SetActive(false);
        HighScore.SetActive(false);
        CurrentScore.SetActive(false);
      
        StartCoroutine("StartGame");


    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(4.2f);

       
        TimerText.SetActive(true);
        Labeltext.SetActive(true);
        Score1.SetActive(true);
        Score2.SetActive(true);
        HighScore.SetActive(true);
        CurrentScore.SetActive(true);
       


    }
}