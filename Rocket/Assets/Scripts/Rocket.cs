using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    [SerializeField] public float ForceUpward = 2000;
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
	}
}
