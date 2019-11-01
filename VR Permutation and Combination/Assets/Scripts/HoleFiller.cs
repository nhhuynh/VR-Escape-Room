using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleFiller : MonoBehaviour {

	public GameObject SoundEffectManager;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		//Debug.Log ("attaching cube to hole");
		//other is cube
		//make cube position same as hole
		//other.transform.position = transform.position;
		//other.transform.rotation  = transform.rotation;
		//other.transform.localScale = transform.localScale;
		if (other.tag == "cube") {
			gameObject.GetComponent<MeshRenderer> ().material = other.GetComponent<MeshRenderer> ().material;
			Debug.Log ("Moving cube.");
			other.transform.Translate( -10f,0, 0);
            other.GetComponent<Rigidbody>().isKinematic = true;
			SoundEffectManager.GetComponent<SoundEffectManager> ().playPingSound ();
        }

	}
}
		