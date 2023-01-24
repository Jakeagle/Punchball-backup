using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnablerWorld5 : MonoBehaviour
{

   
    public GameObject TimerText;
    public GameObject Labeltext;
    public GameObject Score1;
    public GameObject Score2;
    public GameObject HighScore;
    public GameObject CurrentScore;
    public GameObject TractorTower;
    public GameObject SpaceBall1;
    public GameObject SpaceBall2;
    public GameObject SpaceBall3;
    public GameObject SpaceBall4;












    // Start is called before the first frame update
    void Start()
    {
        
      
        SpaceBall1.SetActive(false);
        SpaceBall2.SetActive(false);
        SpaceBall3.SetActive(false);
        SpaceBall4.SetActive(false);
        TractorTower.SetActive(false);
        TimerText.SetActive(false);
        Labeltext.SetActive(false);
        Score1.SetActive(false);
        Score2.SetActive(false);
        HighScore.SetActive(false);
        CurrentScore.SetActive(false);
        StartCoroutine("StartGame");

    }

    // Update is called once per frame
    void Update()
    {

    }




    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(4.2f);
       
        SpaceBall1.SetActive(true);
        SpaceBall2.SetActive(true);
        SpaceBall3.SetActive(true);
        SpaceBall4.SetActive(true);
        TractorTower.SetActive(true);
        TimerText.SetActive(true);
        Labeltext.SetActive(true);
        Score1.SetActive(true);
        Score2.SetActive(true);
        HighScore.SetActive(true);
        CurrentScore.SetActive(true);


    }
}
