using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceScript : MonoBehaviour {

    BoxCollider gantiMaterial;
    Rigidbody buatForce;
    public PhysicMaterial bounceMaterial;
    bool shouldChange;

	// Use this for initialization
	void Start () {
        gantiMaterial = gameObject.GetComponent<BoxCollider>();
        buatForce = gameObject.GetComponent<Rigidbody>();
        shouldChange = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Environment") {
            if (shouldChange) {
                shouldChange = false;
                buatForce.AddForce(0, 0.001f, 0);
                gantiMaterial.material = bounceMaterial;
            }
            
        }
    }
}
