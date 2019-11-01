using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class teleport : MonoBehaviour {
	//public GameObject ui;
	public GameObject objectToTeleport;
	public Transform teleportLocation;
	public GameObject SoundEffectManager;
	public GameObject BackgroundMusicSwitcher;
	private int numTeleports;


	// Use this for initialization
	void Start () {
		//ui.SetActive (false);
		numTeleports = 0;
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
		//ui.SetActive (true);
		SoundEffectManager.GetComponent<SoundEffectManager> ().playTeleportSound ();
		StartCoroutine("delay");
		if (numTeleports == 0) {
			BackgroundMusicSwitcher.GetComponent<BackgroundMusicSwitcher> ().jailToCube ();
		} else  {
			BackgroundMusicSwitcher.GetComponent<BackgroundMusicSwitcher> ().cubeToColloseum ();
		}
		objectToTeleport.transform.position = teleportLocation.transform.position;
        objectToTeleport.transform.rotation = teleportLocation.transform.rotation;
        numTeleports++;
	}

	IEnumerator delay(){
		yield return new WaitForSecondsRealtime (5);
	}


	void onTriggerExit(){
		//ui.SetActive (false);
	}
}
