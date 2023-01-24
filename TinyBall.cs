using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TinyBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
      
        ScoreManager.instance.TinyBallBonus();
      
        Destroy(gameObject);

    }
  

}
