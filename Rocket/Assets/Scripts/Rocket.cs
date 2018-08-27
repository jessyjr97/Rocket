using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    [SerializeField] public float ForceUpward = 50;
    [SerializeField] public float ForceTurning = 0.05f;
    public float rocketNose = 2.35f;
    private Rigidbody rocketBody;
    // Use this for initialization
    void Start() {
        rocketBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Jump") > 0)
        {
            rocketBody.AddRelativeForce(new Vector3(0, ForceUpward, 0), ForceMode.Force);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            rocketBody.AddForceAtPosition(new Vector3(ForceTurning, 0, 0), new Vector3(0, rocketNose, 0));
        } else if (Input.GetAxis("Horizontal") < 0)
        {
            rocketBody.AddForceAtPosition(new Vector3(-ForceTurning, 0, 0), new Vector3(0, rocketNose, 0));
        }
    }
}
