using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcherWorld3 : MonoBehaviour
{

    public static SceneSwitcherWorld3 instance;


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

    public void level21loader()
    {
        SceneManager.LoadScene(22);
    }

    public void level22lloader()
    {
        SceneManager.LoadScene(23);
    }

    public void level23loader()
    {
        SceneManager.LoadScene(24);
    }

    public void level24loader()
    {
        SceneManager.LoadScene(25);
    }


    public void level25loader()
    {
        SceneManager.LoadScene(26);
    }

    public void level26loader()
    {
        SceneManager.LoadScene(27);
    }

    public void level27loader()
    {
        SceneManager.LoadScene(28);
    }

    public void level28loader()
    {
        SceneManager.LoadScene(29);
    }

    public void level29loader()
    {
        SceneManager.LoadScene(30);
    }

    public void level30loader()
    {
        SceneManager.LoadScene(31);
    }

    public void World4loader()
    {
        SceneManager.LoadScene(32);
    }


    public void MainMenuLoaders()
    {
        SceneManager.LoadScene(0);
    }

    public void ResetHighScoreButton()
    {
        ScoreManager.instance.ResetHighScore();
    }
}
