using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempButton : MonoBehaviour {
	public GameObject reset;
	public GameObject teleportBox;
    public GameObject combinationText;
	public GameObject combinationKey;
	public GameObject slot1, slot2, slot3;
	public GameObject text;
	private Material[] materials = new Material[8];
	private int[] combination;
	public Material red, orange, yellow, green, blue, purple, black, white, cyan;
	private int numberCorrect = 0;
	public GameObject SoundEffectManager;

	// Use this for initialization
	void Start () {
		materials = new[] { red, orange, yellow, green, blue, purple, black, white };
        teleportBox.SetActive (false);
		Debug.Log ("Fetching combination");
		combination = combinationKey.GetComponent<CombinationGenerator> ().getKey ();
		Debug.Log ("TempButton: Colors needed to complete puzzle:");
		for (int j = 0; j < 3; j++) {
			//Debug.Log ("iteration " + j);
			Debug.Log ("Color " + j + ":" + materials [combination [j]]);
		}
	}

	//This needs to change to a VR controller event
	public void check(){
		bool slot1Filled = false, slot2Filled = false, slot3Filled = false;
		Debug.Log ("Checking materials...");
		if (slot1.GetComponent<MeshRenderer> ().sharedMaterial == cyan) {
			//Debug.Log ("Slot 1 is Cyan.");
		} else {
			//Debug.Log ("Slot 1 is not Cyan.");
			slot1Filled = true;
		}
		if (slot2.GetComponent<MeshRenderer> ().sharedMaterial == cyan) {
			//Debug.Log ("Slot 2 is Cyan.");
		} else {
			//Debug.Log ("Slot 2 is not Cyan.");
			slot2Filled = true;
		}
		Debug.Log ("Comparing " + slot3.GetComponent<MeshRenderer> ().sharedMaterial.name + " and " + cyan);
		if (slot3.GetComponent<MeshRenderer> ().sharedMaterial == cyan) {
			//Debug.Log ("Slot 3 is Cyan.");
		} else {
			//Debug.Log ("Slot 3 is not Cyan.");
			slot3Filled = true;
		}

		//Not all the slots are filled.
		if (!slot1Filled || !slot2Filled || !slot3Filled) {
			Debug.Log ("Not all the slots were filled.");
			text.GetComponent<TextMesh> ().text = "Not all the slots were filled.";

			//All the slots are filled.
		} else {
			bool uniqueColors = true;
			Debug.Log ("All the slots are filled!");
			//Check if the combinations are unique colours.
			int numberCorrect = 0;
			Debug.Log (slot1.GetComponent<MeshRenderer> ().sharedMaterial.name);
			Debug.Log (slot2.GetComponent<MeshRenderer> ().sharedMaterial.name);
			Debug.Log (slot3.GetComponent<MeshRenderer> ().sharedMaterial.name);
			if (string.Equals (slot1.GetComponent<MeshRenderer> ().sharedMaterial.name, slot2.GetComponent<MeshRenderer> ().sharedMaterial.name)) {
				uniqueColors = false;
			}
			if (string.Equals (slot2.GetComponent<MeshRenderer> ().sharedMaterial.name, slot3.GetComponent<MeshRenderer> ().sharedMaterial.name)) {
				uniqueColors = false;
			}
			if (string.Equals (slot3.GetComponent<MeshRenderer> ().sharedMaterial.name, slot1.GetComponent<MeshRenderer> ().sharedMaterial.name)) {
				uniqueColors = false;
			}
			if(uniqueColors == false){
				text.GetComponent<TextMesh> ().text = "All slots must contain different colors.";
			} else {
				//Check if the combination is correct.
				
				for (int i = 0; i < 3; i++) {
					Debug.Log (materials [combination [i]].name);
				}
				for (int i = 0; i < 3; i++) {
					if (string.Equals (slot1.GetComponent<MeshRenderer> ().sharedMaterial.name, materials [combination [i]].name + " (Instance)")) {
						Debug.Log ("Color match!");
						numberCorrect++;
						break;
					}
				}
				for (int i = 0; i < 3; i++) {
					if (string.Equals (slot2.GetComponent<MeshRenderer> ().sharedMaterial.name, materials [combination [i]].name + " (Instance)")) {
						Debug.Log ("Color match!");
						numberCorrect++;
						break;
					}
				}
				for (int i = 0; i < 3; i++) {
					Debug.Log ("Comparing " + slot3.GetComponent<MeshRenderer> ().sharedMaterial.name + " and " + materials [combination [i]].name + " (Instance)");
					if (string.Equals (slot3.GetComponent<MeshRenderer> ().sharedMaterial.name, materials [combination [i]].name + " (Instance)")) {
						Debug.Log ("Color match!");
						numberCorrect++;
						break;
					}
				}

				if (numberCorrect == 3) {
					text.GetComponent<TextMesh> ().text = "Correct Combination!";
					string guess = "\n" + slot1.GetComponent<MeshRenderer> ().sharedMaterial.name + ", " + slot2.GetComponent<MeshRenderer> ().sharedMaterial.name + ", "
					                          + slot3.GetComponent<MeshRenderer> ().sharedMaterial.name + "; Colors Correct: " + numberCorrect;
					string guessEdit = guess.Replace ("(Instance)", "");
					combinationText.GetComponent<TextMesh> ().text += guessEdit;
					SoundEffectManager.GetComponent<SoundEffectManager> ().playCorrectSound ();
					SoundEffectManager.GetComponent<SoundEffectManager> ().playPortal2AppearSound ();
					teleportBox.SetActive (true);
				} else {
					text.GetComponent<TextMesh> ().text = "Number Correct: " + numberCorrect;
					SoundEffectManager.GetComponent<SoundEffectManager> ().playIncorrectSound ();
				
					string guess = "\n" + slot1.GetComponent<MeshRenderer> ().sharedMaterial.name + ", " + slot2.GetComponent<MeshRenderer> ().sharedMaterial.name + ", "
					                          + slot3.GetComponent<MeshRenderer> ().sharedMaterial.name + "; Colors Correct: " + numberCorrect;
					string guessEdit = guess.Replace ("(Instance)", "");
					combinationText.GetComponent<TextMesh> ().text += guessEdit;

					numberCorrect = 0;
                
				}
			}

			//Reset to Cyan.
			slot1.GetComponent<MeshRenderer> ().material = cyan;
			slot2.GetComponent<MeshRenderer> ().material = cyan;
			slot3.GetComponent<MeshRenderer> ().material = cyan;

		}

		//Reset all the cubes to their original position.
		reset.GetComponent<ResetHandler> ().ResetCubes ();

	}

}
