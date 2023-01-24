using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcherWorld5 : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenuButton5()
    {
        SceneManager.LoadScene(0);
    }

    public void ResetHighScore5()
    {
        ScoreManager.instance.ResetHighScore();
        Debug.Log("Score reset");
    }
    public void level51loader()
    {
        SceneManager.LoadScene(42);
    }

    public void level52loader()
    {
        SceneManager.LoadScene(43);

    }

    public void level53loader()
    {
        SceneManager.LoadScene(44);

    }

    public void level54loader()
    {
        SceneManager.LoadScene(45);

    }

    public void level55loader()
    {
        SceneManager.LoadScene(46);

    }

    public void level56loader()
    {
        SceneManager.LoadScene(47);

    }

    public void level57loader()
    {
        SceneManager.LoadScene(48);

    }

    public void level58loader()
    {
        SceneManager.LoadScene(49);
    }

    public void level59loader()
    {
        SceneManager.LoadScene(50);

    }

    public void level60loader()
    {
        SceneManager.LoadScene(51);

    }
}
