using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManagement : MonoBehaviour
{
    public static TutorialManagement instance;

    Animation anim;

   public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    public GameObject OuterBorder;
    public GameObject TimerText;
    public GameObject LabelText;
    public GameObject HighScore;
    public GameObject CurrentScore;
    public GameObject Score1;
    public GameObject Score2;
    public GameObject PauseButton;
    public GameObject Iso1;
    public GameObject Iso2;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
        OuterBorder.SetActive(false);
        TimerText.SetActive(false);
        LabelText.SetActive(false);
        HighScore.SetActive(false);
        CurrentScore.SetActive(false);
        Score1.SetActive(false);
        Score2.SetActive(false);
        PauseButton.SetActive(false);
        Iso1.SetActive(false);
        Iso2.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator IsolationStart()
    {
        yield return new WaitForSeconds(1f);
        Iso1.SetActive(true);
        Iso2.SetActive(true);
        yield return new WaitForSeconds(1f);
        TimerText.SetActive(true);
        LabelText.SetActive(true);
        HighScore.SetActive(true);
        CurrentScore.SetActive(true);
        Score1.SetActive(true);
        Score2.SetActive(true);
        yield return new WaitForSeconds(3f);
        TutorialUIManagement.instance.TimeAndScoreUI();
        yield return new WaitForSeconds(8f);
        Iso1.SetActive(false);
        Iso2.SetActive(false);


    }



    
    IEnumerator OuterBorderStart()
    {
        yield return new WaitForSeconds(2f);
        OuterBorder.SetActive(true);
        TutorialUIManagement.instance.OuterBorderStarter();
        yield return new WaitForSeconds(1.5f);
        anim.Stop("LevelSlideIn");
        
      
       
    }

    public void StartOuterBorder()
    {
        StartCoroutine("OuterBorderStart");
    }

    public void StartIso()
    {
        StartCoroutine("IsolationStart");
    }

   
}
