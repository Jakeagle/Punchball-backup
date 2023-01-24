using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialUIManagement : MonoBehaviour
{


    public static TutorialUIManagement instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    //objects for game introduction
    public GameObject WelcomeText;
    public GameObject Description;
    public GameObject IntroPanel;
    public GameObject GoalOfGame;
    public GameObject ScoreHighScorePanel;
    public GameObject TimePanel;

    //objects for gamefield explanation
    public GameObject GameFieldTitle;
    public GameObject GameFieldDescription;

    //objects for the outer border
    public GameObject OuterBorderUI;

    // Start is called before the first frame update
    void Start()
    {
       
        WelcomeText.SetActive(false);
        Description.SetActive(false);
        GoalOfGame.SetActive(false);
        GameFieldTitle.SetActive(false);
        GameFieldDescription.SetActive(false);
        ScoreHighScorePanel.SetActive(false);
        TimePanel.SetActive(false);
        OuterBorderUI.SetActive(false);


        StartCoroutine("WelcomeTextInitiate");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WelcomeTextInitiate()
    {
        yield return new WaitForSeconds(2f);
        WelcomeText.SetActive(true);

        yield return new WaitForSeconds(1.2f);
        Description.SetActive(true);

        yield return new WaitForSeconds(5f);
        GoalOfGame.SetActive(true);


        yield return new WaitForSeconds(6f);
        WelcomeText.SetActive(false);
        Description.SetActive(false);
        IntroPanel.SetActive(false);
        GoalOfGame.SetActive(false);
        StartNextEvent();

    }

    //Starts the gamefield title and description coroutine
    public void StartNextEvent()
    {
        StartCoroutine("StartGameFieldDescription");
    }

    IEnumerator StartGameFieldDescription()
    {
        yield return new WaitForSeconds(1.5f);
        GameFieldTitle.SetActive(true);
        yield return new WaitForSeconds(2f);
        GameFieldDescription.SetActive(true);
        yield return new WaitForSeconds(2f);
        isostarter();


    }

    IEnumerator TimeAndScore()
    {
        yield return new WaitForSeconds(1.3f);
        ScoreHighScorePanel.SetActive(true);
        yield return new WaitForSeconds(2f);
        TimePanel.SetActive(true);
        yield return new WaitForSeconds(5f);
        ScoreHighScorePanel.SetActive(false);
        TimePanel.SetActive(false);
        TutorialManagement.instance.StartOuterBorder();

    }
    //STARTS OUTERBORDER
    IEnumerator OuterBorderStart()
    {
        yield return new WaitForSeconds(1.5f);
        OuterBorderUI.SetActive(true);
    }

    public void OuterBorderStarter()
    {
        StartCoroutine("OuterBorderStart");
    }



    void isostarter()
    {
        TutorialManagement.instance.StartIso();
        GameFieldTitle.SetActive(false);
        GameFieldDescription.SetActive(false);


    }

    

    public void TimeAndScoreUI()
    {
        StartCoroutine("TimeAndScore");
    }





}
