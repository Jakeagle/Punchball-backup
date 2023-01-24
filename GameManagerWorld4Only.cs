using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerWorld4Only : MonoBehaviour
{
    public GameObject YouWinPanel;
    public GameObject GameOverPanel;
    public int MinimumScore;






    public static GameManagerWorld4Only instance;

    public Text Score2;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    void Start()
    {

    }


    public void StartGame()
    {


    }

    // Update is called once per frame
    void Update()
    {


        if (ScoreManager.instance.score >= MinimumScore & TimerScript.instance.timeValue == 0)

        {

            Win();
            Debug.Log("Win Activated");



        }


        else if (ScoreManager.instance.score <= 0 & ScoreManager.instance.score < MinimumScore & TimerScript.instance.timeValue <= 0)
        {

            Lose();
            Debug.Log("Lose Activated");





        }

    }










    public void Win()
    {
        YouWinPanel.SetActive(true);
        Debug.Log("Win Complete");

        DestroyBalls();
        DestroyBalls2();
        VanillaBallSpawner.instance.StopSpawningBalls();
        DebbieDownerLauncher.instance.StopSpawningBalls();
        BullyBallSpawnerScript.instance.StopSniping();
        SpaceBallSpawner.instance.StopReleasing();

    }

    public void Lose()
    {
        StartCoroutine("LoseButtons");
        Debug.Log("Lose in progress");
        //GameLost.SetActive(true);
        DestroyBalls();
        DestroyBalls2();
        //VanillaBallSpawner.instance.StopSpawningBalls();
        //FieldBallSpawner.instance.StopSpawningBalls();


    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");

        ScoreManager.instance.ResetScore();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Start");
        ScoreManager.instance.ResetScore();
    }

    public void DestroyBalls()
    {
        var clones = GameObject.FindGameObjectsWithTag("Clone");
        foreach (var clone in clones)
        {
            Destroy(clone);
        }
    }


    public void DestroyBalls2()
    {
        var BullyBall = GameObject.FindGameObjectsWithTag("BullyBall");
        foreach (var clone in BullyBall)
        {
            Destroy(clone);
        }
    }


    IEnumerator LoseButtons()
    {
        yield return new WaitForSeconds(1.5f);
        GameOverPanel.SetActive(true);
        Debug.Log("Lose Complete");

    }

}