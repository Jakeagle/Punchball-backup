using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DestroyAsteroids");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {

        ScoreManager.instance.SniperBonus();

        Destroy(gameObject);

    }


    IEnumerator DestroyAsteroids()
    {
        yield return new WaitForSeconds(15f);

        Destroy(gameObject);
    }


}
