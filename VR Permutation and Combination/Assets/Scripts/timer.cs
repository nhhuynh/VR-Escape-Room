using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class timer : MonoBehaviour {

    public Text timeText;
    private float times = 0f;
    public GameObject gameover;
    // Use this for initialization
	void Start () {
        gameover.SetActive(false);
	}
	
    void Update()
    {
        times += Time.deltaTime;
        float minutes = Mathf.Floor(times / 60);
        float seconds = Mathf.RoundToInt(times % 60);
        string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);

        timeText.text = niceTime;
        if(Mathf.Approximately(minutes ,5f)){
            gameover.SetActive(true);
        }
    }



    IEnumerator delayTime(){
        yield return new WaitForSeconds(3);
    }
}
