using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonB : MonoBehaviour {

    public GameObject reset;
    public GameObject teleportBox;
    public GameObject permutationText;
    public GameObject permutationKey;
    public GameObject container1, container2, container3;
    public GameObject text;
    private GameObject[] key;
    private GameObject[] guess;
    private GameObject[] digits;
    private TextMesh currentText;
    private bool container1fill;
    private bool container2fill;
    private bool container3fill;
    private int n;
    private int r;
    private int numberCorrect = 0;
    
	public GameObject SoundEffectManager;

    void Start () {
        teleportBox.SetActive(false);
        key = permutationKey.GetComponent<ContainerManager>().getKey();
        guess = permutationKey.GetComponent<ContainerManager>().getGuess();
        digits = permutationKey.GetComponent<ContainerManager>().digits;
        n = digits.Length;
        r = key.Length;
        //container1fill = permutationKey.GetComponent<ContainerManager>().getContainer1();
        //container2fill = permutationKey.GetComponent<ContainerManager>().getContainer2();
        //container3fill = permutationKey.GetComponent<ContainerManager>().getContainer3();
    }
    public void check()
    {
        text.GetComponent<TextMesh>().text = "";
        if (permutationKey.GetComponent<ContainerManager>().getContainer1() == true )
        {
            container1fill = true;
            Debug.Log("Container1 filled");
        }
        if (permutationKey.GetComponent<ContainerManager>().getContainer2() == true)
        {
            container2fill = true;
            Debug.Log("Container2 filled");
        }
        if (permutationKey.GetComponent<ContainerManager>().getContainer3() == true)
        {
            container3fill = true;
            Debug.Log("Container3 filled");
        }
        if (container1fill == false || container2fill == false || container3fill == false)
        {
            print("Containers not full");
            text.GetComponent<TextMesh>().text = "Not all the slots were filled.";
        }
        else
        {
            for (int i = 0; i < key.Length; i++)
            {
                if (string.Compare(key[i].name, guess[i].name) == 0)
                {
                    text.GetComponent<TextMesh>().text += guess[i].name + " is in the right location! \n";
                    numberCorrect++;

                    
                }
                else if(string.Compare(key[i].name, guess[i].name) < 0)
                {
                    text.GetComponent<TextMesh>().text += guess[i].name + " is too high. \n";
                }
                else if (string.Compare(key[i].name, guess[i].name) > 0)
                {
                    text.GetComponent<TextMesh>().text += guess[i].name + " is too low. \n";
                }
            }
            if (numberCorrect == 3)
            {
				SoundEffectManager.GetComponent<SoundEffectManager> ().playCorrectSound ();
                print("Correct Permuation");
				SoundEffectManager.GetComponent<SoundEffectManager> ().playPortal1AppearSound ();
                teleportBox.SetActive(true);
            }
            else
            {
				SoundEffectManager.GetComponent<SoundEffectManager> ().playIncorrectSound ();
                //text.GetComponent<TextMesh>().text = "Numbers in the right position:" + numberCorrect;
                
                container1.GetComponent<BoxCollider>().isTrigger = true;
                container2.GetComponent<BoxCollider>().isTrigger = true;
                container3.GetComponent<BoxCollider>().isTrigger = true;
                print(container1fill + ", " + container2fill + ", " + container3fill);
                print(permutationText.GetComponent<TextMesh>().text);

                //currentText.text = permutationText.GetComponent<TextMesh>().text; 
                permutationText.GetComponent<TextMesh>().text += "\n" + guess[0].name + ", " + guess[1].name + ", " + guess[2].name + ";" + " Number Correct:" + numberCorrect;
                numberCorrect = 0;
                reset.GetComponent<ResetManager>().ResetDigits();
            }
        }
        
        

    }
    
    
    // Update is called once per frame
    void Update () {
        //check();
        
	}
}
