using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{


    public static ScoreManager instance;
    public int score;
    public int highScore;
    public Text Score;
    public Text HighScore;

   
    

    private void Awake()
    {
        instance = this;
           
        

        if (PlayerPrefs.HasKey("HighScore"))
        {


            highScore = PlayerPrefs.GetInt("HighScore");
            HighScore.text = highScore.ToString();
        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore()
    {
        score++;
        Score.text = score.ToString();
        UpdateHighScore();

        
    }

    public void SubtractScore()
    {
        score--;
        Score.text = score.ToString();
        UpdateHighScore();
    }

    public void UpdateHighScore()
    {
        if (score > highScore) 
        {
            highScore = score;
            HighScore.text = highScore.ToString();

            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }
    public void ResetScore()
    {
        score = 0;
        Score.text = score.ToString();
    }


    public void ResetHighScore()
    {
        PlayerPrefs.DeleteKey("HighScore");
        highScore = 0;
        HighScore.text = highScore.ToString();

    }

    public void SniperBonus()
    {
        score += 5;
        Score.text = score.ToString();
        UpdateHighScore();
    }


    public void TinyBallBonus()
    {
        score += 2;
        Score.text = score.ToString();
        UpdateHighScore();

    }

    public void QuiteAnAwesomeBonus()
    {
        score += 10;
        Score.text = score.ToString();
        UpdateHighScore();

    }
}
   