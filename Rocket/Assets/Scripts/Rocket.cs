using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    [SerializeField] public float ForceUpward = 100;
    [SerializeField] public float ForceTurning = 50;
    private Rigidbody rocketBody;
    // Use this for initialization
    void Start() {
        rocketBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Jump") > 0)
        {
            rocketBody.AddForce(new Vector3(0, ForceUpward, 0));
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            rocketBody.AddForceAtPosition(new Vector3(0, ForceTurning, 0), new Vector3(0,0,0));
        } else if (Input.GetAxis("Horizontal") < 0)
        {
            rocketBody.AddForceAtPosition(new Vector3(0, -ForceTurning, 0), new Vector3(0, 0, 0));
        }
    }
}
