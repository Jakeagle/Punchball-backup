using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DestroyBalls");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {

        ScoreManager.instance.SubtractScore();
        Destroy(gameObject);


    }

    IEnumerator DestroyBalls()
    {
        yield return new WaitForSeconds(9.5f);
        Destroy(gameObject);
    }
}
