using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinationGenerator : MonoBehaviour {

	private int[] numbers = new int[3];

	// Use this for initialization
	void Start () {
		//Picking random colors using random numbers in randomNumbers ArrayList to guarantee no duplicates.
		ArrayList randomNumbers = new ArrayList{ 0, 1, 2, 3, 4, 5, 6, 7 };
		//Color materials in the mats array. Same size as randomNumbers.
		for (int i = 0; i < 3; i++) {
			
			int index = Random.Range (0, randomNumbers.Count);
			int number = (int) randomNumbers [index];
			randomNumbers.Remove (number);
			numbers [i] = number;

		}
	}

	public int[] getKey(){
		return numbers;
	}

}
