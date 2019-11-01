using UnityEngine;

public class ResetManager : MonoBehaviour {

    public GameObject[] digits;
    public GameObject[] guess;
    public GameObject ContainerManager;
    private Vector3[] positionArray = new Vector3[10];
    private Quaternion[] rotationArray = new Quaternion[10];
    private Vector3[] scaleArray = new Vector3[10];
    // Use this for initialization
    void Start()
    {
        int i = 0;
        foreach (GameObject digit in digits)
        {
            positionArray[i] = digit.transform.position;
            rotationArray[i] = digit.transform.rotation;
            scaleArray[i] = digit.transform.localScale;
            i++;
        }
        guess = ContainerManager.GetComponent<ContainerManager>().getGuess();

        /*
		foreach (GameObject cube in cubes) {
			print (positionArray [i]);
			i++;
		}
		*/
        
    }

    public void ResetDigits()
    {
        Debug.Log("Resetting all cubes to original positions.");
        ContainerManager.GetComponent<ContainerManager>().setContainer1(false);
        ContainerManager.GetComponent<ContainerManager>().setContainer2(false);
        ContainerManager.GetComponent<ContainerManager>().setContainer3(false);
        int i = 0;
        foreach (GameObject digit in digits)
        {
            digit.transform.position = positionArray[i];
            digit.transform.rotation = rotationArray[i];
            digit.transform.localScale = scaleArray[i];
            i++;
            digit.GetComponent<Rigidbody>().isKinematic = false;
        }
        for(int j = 0; j < guess.Length; j++){
            guess[j] = null;
        }

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
