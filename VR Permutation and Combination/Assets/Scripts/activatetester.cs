using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activatetester : MonoBehaviour {
    public GameObject teleportBox;
	// Use this for initialization
	void Start () {
        teleportBox.SetActive(false);
	}

    private void OnTriggerEnter(Collider other){
        teleportBox.SetActive(true);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
