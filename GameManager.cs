using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

   
    public string testScript = "Welcome home Jake";
    public GameObject YouWinPanel;
    public GameObject GameOverPanel;
    public int MinimumScore;

   
    
   
   



    public static GameManager instance;

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
        Debug.Log(testScript);
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
        }


        else if (ScoreManager.instance.score >= 0 & ScoreManager.instance.score < MinimumScore & TimerScript.instance.timeValue <= 0)
        {
            Lose();
        }
       
    }

    public void Win()
    {
        YouWinPanel.SetActive(true);
       
        DestroyBalls();
        DestroyBalls2();
        VanillaBallSpawner.instance.StopSpawningBalls();
        DebbieDownerLauncher.instance.StopSpawningBalls();
        BullyBallSpawnerScript.instance.StopSniping();
        SpaceBallSpawner.instance.StopReleasing();
        TinyBallSpawner.instance.StopSpawningTinyBalls();

    }

    public void Lose()
    {
        StartCoroutine("LoseButtons");
       
        //GameLost.SetActive(true);
        DestroyBalls();
        DestroyBalls2();
        //VanillaBallSpawner.instance.StopSpawningBalls();
        //FieldBallSpawner.instance.StopSpawningBalls();
        SpaceBallSpawner.instance.StopReleasing();
        TinyBallSpawner.instance.StopSpawningTinyBalls();
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
        
        
    }

}




