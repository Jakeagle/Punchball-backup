using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneSwitcherWorld2 : MonoBehaviour
{

    public static SceneSwitcherWorld2 instance;
    public Button NextLevel;

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

    public void ResetHighScoreButton()
    {
        ScoreManager.instance.ResetHighScore();
        Debug.Log("High Score Reset");
    }

    public void MainMenuSelect()
    {
        SceneManager.LoadScene(0);
    }
    public void Level11loader()
    {
        SceneManager.LoadScene(12);
    }

    public void Level12loader()
    {
        SceneManager.LoadScene(13);
    }
   
    public void Level13loader()
    {
        SceneManager.LoadScene(14);
    }

    public void Level14Loader()
    {
        SceneManager.LoadScene(15);
    }

    public void Level15Loader()
    {
        SceneManager.LoadScene(16);
    }

    public void Level16Loader()
    {
        SceneManager.LoadScene(17);
    }

    public void Level17Loader()
    {
        SceneManager.LoadScene(18);
    }

    public void Level18Loader()
    {
        SceneManager.LoadScene(19);
    }

    public void Level19Loader()
    {
        SceneManager.LoadScene(20);
    }

    public void Level20Loader()
    {
        SceneManager.LoadScene(21);
    }

    public void NextWorldLoader()
    {
        SceneManager.LoadScene(22);
    }
}
