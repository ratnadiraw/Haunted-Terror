using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpawner : MonoBehaviour {

    public GameObject trapSpawnable;
    public float radius = 0.001f;
    public AudioClip trapClip;
    AudioSource currentAudio;                     // Reference to the audio source.

    // Use this for initialization
    void Start () {
        currentAudio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Environment") {
            currentAudio.clip = trapClip;
            currentAudio.Play();
            GameObject clone;
            Vector3 randomVector;
            Quaternion rotationStraight = Quaternion.Euler(0, 0, 0);
            Destroy(gameObject);


            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = randomVector.y + 1;
            clone = Instantiate(trapSpawnable, randomVector, rotationStraight);
            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = randomVector.y + 1;
            GameObject clone1;
            clone1 = Instantiate(trapSpawnable, randomVector, rotationStraight);
            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = randomVector.y + 1;
            GameObject clone2;
            clone2 = Instantiate(trapSpawnable, randomVector, rotationStraight);
            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = randomVector.y + 1;
            GameObject clone3;
            clone3 = Instantiate(trapSpawnable, randomVector, rotationStraight);
            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = randomVector.y + 1;
            GameObject clone4;
            clone4 = Instantiate(trapSpawnable, randomVector, rotationStraight);
            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = randomVector.y + 1;
            GameObject clone5;
            clone5 = Instantiate(trapSpawnable, randomVector, rotationStraight);
            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = randomVector.y + 1;
        }
        
        /*
        GameObject clone6;
        clone6 = Instantiate(trapSpawnable, randomVector, rotationStraight);
        randomVector = Random.insideUnitSphere * radius + transform.position;
        randomVector.y = Mathf.Abs(randomVector.y);
        randomVector.y = randomVector.y + 1;
        GameObject clone7;
        clone7 = Instantiate(trapSpawnable, randomVector, rotationStraight);
        randomVector = Random.insideUnitSphere * radius + transform.position;
        randomVector.y = Mathf.Abs(randomVector.y);
        randomVector.y = randomVector.y + 1;
        GameObject clone8;
        clone8 = Instantiate(trapSpawnable, randomVector, rotationStraight);
        randomVector = Random.insideUnitSphere * radius + transform.position;
        randomVector.y = Mathf.Abs(randomVector.y);
        randomVector.y = randomVector.y + 1;
        GameObject clone9;
        clone9 = Instantiate(trapSpawnable, randomVector, rotationStraight);
        */
        
    }
}
