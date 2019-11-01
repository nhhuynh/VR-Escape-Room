using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SecondTeleport : MonoBehaviour {
	//public GameObject ui;
	public GameObject objectToTeleport;
	public Transform teleportLocation;

	// Use this for initialization
	void Start () {
		//ui.SetActive (false);
	}

	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
		//ui.SetActive (true);
		objectToTeleport.transform.position = teleportLocation.transform.position;
	}

	void onTriggerExit(){
		//ui.SetActive (false);
	}
}
