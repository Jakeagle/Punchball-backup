using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebbieDowner : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<BoxCollider2D>())
        {

        }
    }

    private void OnMouseDown()
    {
       
        ScoreManager.instance.AddScore();
        Destroy(gameObject);


    }
 

}
