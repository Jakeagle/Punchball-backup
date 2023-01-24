using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DestroySpaceBalls");
        Debug.Log("active");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);

        ScoreManager.instance.AddScore();
    }

    IEnumerator DestroySpaceBalls()
    { 
        yield return new WaitForSeconds(6f);


        Destroy(gameObject);
    }
}
