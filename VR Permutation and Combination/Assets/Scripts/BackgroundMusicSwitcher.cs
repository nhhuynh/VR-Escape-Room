using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicSwitcher : MonoBehaviour {


	public AudioSource jailAmbience;
	public AudioSource jailSounds;
	public AudioSource cubeAmbience;
	public AudioSource colloseumAmbience;
	public AudioSource fireworkSounds;
	public GameObject fireworks;

	private bool goal1;
	private bool goal2;


	void Start(){
		goal1 = false;
		goal2 = false;
		fireworks.SetActive (false);
	}

    // Update is called once per frame
    public void jailToCube () {
		if (goal1 == false) {
			jailAmbience.Stop ();
			jailSounds.Stop ();
			cubeAmbience.PlayDelayed (4);
		}
		goal1 = true;
	}
		
	public void cubeToColloseum(){
		if (goal2 == false) {
			cubeAmbience.Stop ();
			colloseumAmbience.PlayDelayed (4);
			fireworkSounds.Play ();
			fireworks.SetActive (true);
		}
		goal2 = true;
	}
}
