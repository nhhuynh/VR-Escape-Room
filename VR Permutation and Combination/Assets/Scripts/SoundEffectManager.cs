using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectManager : MonoBehaviour {

	public AudioSource correctSound;
	public AudioSource incorrectSound;
	public AudioSource pingSound;
	public AudioSource menuSound;
	public AudioSource portal1AppearSound;
	public AudioSource teleportSound;
	public AudioSource portal2AppearSound;
	public AudioSource rumblingSound;

	public void playCorrectSound(){
		correctSound.Play ();
	}

	public void playIncorrectSound(){
		incorrectSound.Play ();
	}

	public void playPingSound(){
		pingSound.Play ();
	}

	public void playMenuSound(){
		menuSound.Play ();
	}

	public void playPortal1AppearSound(){
		portal1AppearSound.PlayDelayed (2);
	}

	public void playPortal2AppearSound(){
		portal2AppearSound.PlayDelayed (2);
	}

	public void playTeleportSound(){
		teleportSound.Play ();
	}

	public void playRumblingSound(){
        rumblingSound.PlayDelayed(100);
	}

    private void Start()
    {
        playRumblingSound();
    }


}
