using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shake : MonoBehaviour
{
    bool Up = true;
    bool repeat = true;
    bool repeat2 = true;
    private float times = 0f;
    private float seconds;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(waiter());
    }

    private void Update()
    {
        times += Time.deltaTime;
        seconds = Mathf.RoundToInt(times % 60);
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(100f);
        while (repeat)
        {
            while (repeat2)
            {
                if (Up)
                {
                    yield return new WaitForSeconds(.05f);
                    transform.Translate(0, 0.2f, 0);
                    Up = false;
                }
                else
                {
                    yield return new WaitForSeconds(.05f);
                    transform.Translate(0, -.2f, 0);
                    Up = true;
                }

            }
        }
    }
        
}