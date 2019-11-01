using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerManager : MonoBehaviour {
    public GameObject container1;
    public GameObject container2;
    public GameObject container3;
    public GameObject[] key = new GameObject[3];
    public GameObject[] guess = new GameObject[3];
    public GameObject[] digits = new GameObject[10];
    public bool container1filled = false;
    public bool container2filled = false;
    public bool container3filled = false;

    //public GameObject digit1,digit2,digit3,digit4,digit5,digit6,digit7,digit8,digit9,digit0;
    public GameObject[] getKey()
    {
        return key;
    }
    public GameObject[] getGuess()
    {
        return guess;
    }
    public bool getContainer1()
    {
        return container1filled;
    }
    public bool getContainer2()
    {
        return container2filled;
    }
    public bool getContainer3()
    {
        return container3filled;
    }
    public void setContainer1(bool container1)
    {
        container1filled = container1;
    }
    public void setContainer2(bool container2)
    {
        container2filled = container2;
    }
    public void setContainer3(bool container3)
    {
        container3filled = container3;
    }
    // Use this for initialization
    void Start () {
        
        int key1 = Random.Range(0,9);
        int key2 = Random.Range(0, 9);
        while (key2 == key1)
        {
            key2 = Random.Range(0, 9);
        }
        int key3 = Random.Range(0, 9);
        while (key3 == key1 || key3 == key2)
        {
            key3 = Random.Range(0, 9);
        }
        //print(key1);
        //print(key2);
        //print(key3);
        switch (key1)
        {
            case 0:
                key[0] = digits[0];
                break;
            case 1:
                key[0] = digits[1];
                break;
            case 2:
                key[0] = digits[2];
                break;
            case 3:
                key[0] = digits[3];
                break;
            case 4:
                key[0] = digits[4];
                break;
            case 5:
                key[0] = digits[5];
                break;
            case 6:
                key[0] = digits[6];
                break;
            case 7:
                key[0] = digits[7];
                break;
            case 8:
                key[0] = digits[8];
                break;
            case 9:
                key[0] = digits[9];
                break;
        }
        switch (key2)
        {
            case 0:
                key[1] = digits[0];
                break;
            case 1:
                key[1] = digits[1];
                break;
            case 2:
                key[1] = digits[2];
                break;
            case 3:
                key[1] = digits[3];
                break;
            case 4:
                key[1] = digits[4];
                break;
            case 5:
                key[1] = digits[5];
                break;
            case 6:
                key[1] = digits[6];
                break;
            case 7:
                key[1] = digits[7];
                break;
            case 8:
                key[1] = digits[8];
                break;
            case 9:
                key[1] = digits[9];
                break;
        }
        switch (key3)
        {
            case 0:
                key[2] = digits[0];
                break;
            case 1:
                key[2] = digits[1];
                break;
            case 2:
                key[2] = digits[2];
                break;
            case 3:
                key[2] = digits[3];
                break;
            case 4:
                key[2] = digits[4];
                break;
            case 5:
                key[2] = digits[5];
                break;
            case 6:
                key[2] = digits[6];
                break;
            case 7:
                key[2] = digits[7];
                break;
            case 8:
                key[2] = digits[8];
                break;
            case 9:
                key[2] = digits[9];
                break;
        }
        for (int i = 0; i < key.Length; i++)
        {
            print(key[i].name);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
