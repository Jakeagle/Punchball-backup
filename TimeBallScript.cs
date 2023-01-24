using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBallScript : MonoBehaviour
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
        TimerScript.instance.AddSuperTime();

        Destroy(gameObject);

    }

    IEnumerator DestroyBalls()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }

}
