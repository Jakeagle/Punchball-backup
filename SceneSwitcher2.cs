using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher2 : MonoBehaviour
{





    public static SceneSwitcher2 instance;

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

    public void SwitchToMainMenu()
    {
        SceneManager.LoadScene("Start");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Level-3");
    }

}