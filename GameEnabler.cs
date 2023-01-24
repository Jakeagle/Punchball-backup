using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEnabler : MonoBehaviour
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
    public GameObject DeathBallSpawner;
    public GameObject FieldBallSpawner1;
    public GameObject FieldBallSpawner2;
    public GameObject FieldBallSpawner3;
    public GameObject FieldBallSpawner4;

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
        DeathBallSpawner.SetActive(false);
        FieldBallSpawner1.SetActive(false);
        FieldBallSpawner2.SetActive(false);
        FieldBallSpawner3.SetActive(false);
        FieldBallSpawner4.SetActive(false);
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
        DeathBallSpawner.SetActive(true);
        FieldBallSpawner1.SetActive(true);
        FieldBallSpawner2.SetActive(true);
        FieldBallSpawner3.SetActive(true);
        FieldBallSpawner4.SetActive(true);
    }
}