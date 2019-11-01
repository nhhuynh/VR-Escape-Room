using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour {
    public GameObject obj;
    //ContainerManager manager = new ContainerManager();
    GameObject manager;
    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("manager");
    }
    private void OnTriggerEnter(Collider col)
    {
        obj = col.gameObject;
        print("call");
        print(this.gameObject.name);
        if(string.Compare(this.gameObject.name ,"container1")== 0)
        {
            print("work");
            if (col.tag == "number")
            {
                manager.GetComponent<ContainerManager>().guess[0] = obj;
                //this.gameObject.GetComponent<BoxCollider>().isTrigger = false;
                manager.GetComponent<ContainerManager>().setContainer1(true);
                print(this.gameObject.name + " " + obj + " "+ manager.GetComponent<ContainerManager>().getContainer1());
            }
            
        }
        else if(string.Compare(this.gameObject.name, "container2") == 0)
        {
            if (col.tag == "number")
            {
                manager.GetComponent<ContainerManager>().guess[1] = obj;
                manager.GetComponent<ContainerManager>().setContainer2(true);
                //this.gameObject.GetComponent<BoxCollider>().isTrigger = false;

                print(this.gameObject.name+ " " + obj + " " + manager.GetComponent<ContainerManager>().getContainer2());
            }
        }
        else if(string.Compare(this.gameObject.name, "container3") == 0)
        {
            if (col.tag == "number")
            {
                manager.GetComponent<ContainerManager>().guess[2] = obj;
                manager.GetComponent<ContainerManager>().setContainer3(true);
                //this.gameObject.GetComponent<BoxCollider>().isTrigger = false;
                print(this.gameObject.name + " " + obj + " " + manager.GetComponent<ContainerManager>().getContainer3());
            }
        }
    }
}
