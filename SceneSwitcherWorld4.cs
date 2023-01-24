using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcherWorld4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


   public void World41loader()
    {
        SceneManager.LoadScene(32);
    }

    public void World42loader()
    {
        SceneManager.LoadScene(33);

    }

    public void World43loader()
    {
        SceneManager.LoadScene(34);
    }

    public void World44loader()
    {
        SceneManager.LoadScene(35);
    }

    public void World45Loader()
    {
        SceneManager.LoadScene(36);
    }

    public void World46loader()
    {
        SceneManager.LoadScene(37);

    }

    public void World47Loader()
    {
        SceneManager.LoadScene(38);
    }

    public void World48loader()
    {
        SceneManager.LoadScene(39);

    }

    public void World49Loader()
    {
        SceneManager.LoadScene(40);

    }

    public void World50Loader()
    {
        SceneManager.LoadScene(41);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void ResetHighScore()
    {
        ScoreManager.instance.ResetHighScore();

    }
}
