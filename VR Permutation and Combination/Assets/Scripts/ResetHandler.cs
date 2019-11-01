using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetHandler : MonoBehaviour {
	public GameObject[] cubes;
	private Vector3[] positionArray = new Vector3[8];
	private Quaternion[] rotationArray = new Quaternion[8];
	private Vector3[] scaleArray = new Vector3[8];
	// Use this for initialization
	void Start () {
		int i = 0;
		foreach (GameObject cube in cubes) {
			positionArray [i] = cube.transform.position;
			rotationArray [i] = cube.transform.rotation;
			scaleArray [i] = cube.transform.localScale;
			i++;
		}
		i = 0;
		/*
		foreach (GameObject cube in cubes) {
			print (positionArray [i]);
			i++;
		}
		*/
	}

	public void ResetCubes()
	{
		Debug.Log ("Resetting all cubes to original positions.");
		int i = 0;
		foreach (GameObject cube in cubes) {
			cube.transform.position = positionArray [i];
			cube.transform.rotation = rotationArray [i];
			cube.transform.localScale = scaleArray [i];
			i++;
			cube.GetComponent<Rigidbody> ().isKinematic = false;
		}
		i = 0;
		/*
		foreach (GameObject cube in cubes) {
			print (positionArray [i]);
			i++;
		}
		*/
	}
	// Update is called once per frame
	void Update () {
		
	}
}
