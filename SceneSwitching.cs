using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitching : MonoBehaviour
{





    public static SceneSwitching instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
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

    public void StartGameAndRestart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Level3loader()
    {
        SceneManager.LoadScene("Level-3");
    }

    public void RestartLevel2()
    {
        SceneManager.LoadScene("Level-2");
    }

    public void SwitchToMainMenu()
    {
        SceneManager.LoadScene("Start");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Level-2");
    }

    public void Level2GameOverRestart()
    {
        SceneManager.LoadScene("Level-2");
    }

    public void Level4Loader()
    {
        SceneManager.LoadScene("Level-4");
    }

    public void Level3Restart()
    {
        SceneManager.LoadScene("Level-3");
    }

    public void Level5Loader()
    {
        SceneManager.LoadScene("Level-5");
    }

    public void Level4Restart()
    {
        SceneManager.LoadScene("Level-4");
    }

    public void Level6Loader()
    {
        SceneManager.LoadScene("Level-6");
    }

    public void level5Restart()
    {
        SceneManager.LoadScene("Level-5");
    }

    public void Level7Loader()
    {
        SceneManager.LoadScene("Level-7");
    }

    public void level6Restart()
    {
        SceneManager.LoadScene("level-6");
    }

    public void Level8Loader()
    {
        SceneManager.LoadScene("Level-8");

    }

    public void Level7Restart()
    {
        SceneManager.LoadScene("Level-7");
    }

    public void Level9Loader()
    {
        SceneManager.LoadScene("Level-9");
    }

    public void Level8Restart()
    {
        SceneManager.LoadScene("Level-8");
    }


    public void Level10Loader()
    {
        SceneManager.LoadScene("Level-10");
    }

    public void Level9Restart()
    {
        SceneManager.LoadScene("Level-9");
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene(1);
    }

    public void Level1Loader()
    {
        SceneManager.LoadScene("Game");
    }

    public void Level11loader()
    {
        SceneManager.LoadScene(11);
    }

    public void ResetHighScore()
    {
        ScoreManager.instance.ResetHighScore();
    }

}