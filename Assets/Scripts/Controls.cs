using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {



	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            print("Forward!");
            GetComponent<Rigidbody>().AddForce(transform.forward * 15);
        }


        if (Input.GetKey(KeyCode.S))
        {
            print("Back!");
            GetComponent<Rigidbody>().AddForce(transform.forward * -10);
        }

        if (Input.GetKey(KeyCode.D))
        {
            print("Right!");
            GetComponent<Rigidbody>().AddRelativeTorque(Vector3.up * 15);
        }

        if (Input.GetKey(KeyCode.A))
        {
            print("Left!");
            GetComponent<Rigidbody>().AddRelativeTorque(Vector3.up * -15);
        }

    }
}

