using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingSpawn : MonoBehaviour {

    public GameObject trapSpawnable;
    public float radius = 0.1f;
    AudioSource currentAudio;                     // Reference to the audio source.

    // Use this for initialization
    void Start () {
        currentAudio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void explosion() {
        currentAudio.Play();
        GameObject clone;
        Vector3 randomVector;
        Quaternion rotationStraight = Quaternion.Euler(0, 0, 0);
        Destroy(gameObject);


        randomVector = Random.insideUnitSphere * radius + transform.position;
        randomVector.y = Mathf.Abs(randomVector.y);
        randomVector.y = transform.position.y;
        clone = Instantiate(trapSpawnable, randomVector, rotationStraight);

        clone.AddComponent<Rigidbody>();
        Rigidbody cloneRB = clone.GetComponent<Rigidbody>();
        randomVector.y = 0;
        randomVector.x = randomVector.x * 0.0000000000000000000000000000000001f;
        randomVector.z = randomVector.z * 0.0000000000000000000000000000000001f;


        cloneRB.AddForce(randomVector);

        randomVector = Random.insideUnitSphere * radius + transform.position;
        randomVector.y = Mathf.Abs(randomVector.y);
        randomVector.y = transform.position.y;
        GameObject clone1;
        clone1 = Instantiate(trapSpawnable, randomVector, rotationStraight);

        clone1.AddComponent<Rigidbody>();
        Rigidbody cloneRB1 = clone1.GetComponent<Rigidbody>();
        randomVector.y = 0;
        randomVector.x = randomVector.x * 0.0000000000000000000000000000000001f;
        randomVector.z = randomVector.z * 0.0000000000000000000000000000000001f;
        cloneRB1.AddForce(randomVector);


        randomVector = Random.insideUnitSphere * radius + transform.position;
        randomVector.y = Mathf.Abs(randomVector.y);
        randomVector.y = transform.position.y;
        GameObject clone2;
        clone2 = Instantiate(trapSpawnable, randomVector, rotationStraight);

        clone2.AddComponent<Rigidbody>();
        Rigidbody cloneRB2 = clone2.GetComponent<Rigidbody>();
        randomVector.y = 0;
        randomVector.x = randomVector.x * 0.0000000000000000000000000000000001f;
        randomVector.z = randomVector.z * 0.0000000000000000000000000000000001f;
        cloneRB2.AddForce(randomVector);

        randomVector = Random.insideUnitSphere * radius + transform.position;
        randomVector.y = Mathf.Abs(randomVector.y);
        randomVector.y = transform.position.y;
        GameObject clone3;
        clone3 = Instantiate(trapSpawnable, randomVector, rotationStraight);

        clone3.AddComponent<Rigidbody>();
        Rigidbody cloneRB3 = clone3.GetComponent<Rigidbody>();
        randomVector.y = 0;
        randomVector.x = randomVector.x * 0.0000000000000000000000000000000001f;
        randomVector.z = randomVector.z * 0.0000000000000000000000000000000001f;
        cloneRB3.AddForce(randomVector);


        randomVector = Random.insideUnitSphere * radius + transform.position;
        randomVector.y = Mathf.Abs(randomVector.y);
        randomVector.y = transform.position.y;
        GameObject clone4;
        clone4 = Instantiate(trapSpawnable, randomVector, rotationStraight);

        clone4.AddComponent<Rigidbody>();
        Rigidbody cloneRB4 = clone4.GetComponent<Rigidbody>();
        randomVector.y = 0;
        randomVector.x = randomVector.x * 0.0000000000000000000000000000000001f;
        randomVector.z = randomVector.z * 0.0000000000000000000000000000000001f;
        cloneRB4.AddForce(randomVector);


        randomVector = Random.insideUnitSphere * radius + transform.position;
        randomVector.y = Mathf.Abs(randomVector.y);
        randomVector.y = transform.position.y;
        GameObject clone5;
        clone5 = Instantiate(trapSpawnable, randomVector, rotationStraight);

        clone5.AddComponent<Rigidbody>();
        Rigidbody cloneRB5 = clone5.GetComponent<Rigidbody>();
        randomVector.y = 0;
        randomVector.x = randomVector.x * 0.0000000000000000000000000000000001f;
        randomVector.z = randomVector.z * 0.0000000000000000000000000000000001f;
        cloneRB5.AddForce(randomVector);

        randomVector = Random.insideUnitSphere * radius + transform.position;
        randomVector.y = Mathf.Abs(randomVector.y);
        randomVector.y = transform.position.y;



        randomVector = Random.insideUnitSphere * radius + transform.position;
        randomVector.y = Mathf.Abs(randomVector.y);
        randomVector.y = transform.position.y;
        GameObject clone6;
        clone6 = Instantiate(trapSpawnable, randomVector, rotationStraight);

        clone5.AddComponent<Rigidbody>();
        Rigidbody cloneRB6 = clone6.GetComponent<Rigidbody>();
        randomVector.y = 0;
        randomVector.x = randomVector.x * 0.0000000000000000000000000000000001f;
        randomVector.z = randomVector.z * 0.0000000000000000000000000000000001f;
        cloneRB5.AddForce(randomVector);

        randomVector = Random.insideUnitSphere * radius + transform.position;
        randomVector.y = Mathf.Abs(randomVector.y);
        randomVector.y = transform.position.y;


        randomVector = Random.insideUnitSphere * radius + transform.position;
        randomVector.y = Mathf.Abs(randomVector.y);
        randomVector.y = transform.position.y;
        GameObject clone7;
        clone7 = Instantiate(trapSpawnable, randomVector, rotationStraight);

        clone7.AddComponent<Rigidbody>();
        Rigidbody cloneRB7 = clone7.GetComponent<Rigidbody>();
        randomVector.y = 0;
        randomVector.x = randomVector.x * 0.0000000000000000000000000000000001f;
        randomVector.z = randomVector.z * 0.0000000000000000000000000000000001f;
        cloneRB7.AddForce(randomVector);

        randomVector = Random.insideUnitSphere * radius + transform.position;
        randomVector.y = Mathf.Abs(randomVector.y);
        randomVector.y = transform.position.y;



        randomVector = Random.insideUnitSphere * radius + transform.position;
        randomVector.y = Mathf.Abs(randomVector.y);
        randomVector.y = transform.position.y;
        GameObject clone8;
        clone8 = Instantiate(trapSpawnable, randomVector, rotationStraight);

        clone8.AddComponent<Rigidbody>();
        Rigidbody cloneRB8 = clone8.GetComponent<Rigidbody>();
        randomVector.y = 0;
        randomVector.x = randomVector.x * 0.0000000000000000000000000000000001f;
        randomVector.z = randomVector.z * 0.0000000000000000000000000000000001f;
        cloneRB5.AddForce(randomVector);

        randomVector = Random.insideUnitSphere * radius + transform.position;
        randomVector.y = Mathf.Abs(randomVector.y);
        randomVector.y = transform.position.y;



        randomVector = Random.insideUnitSphere * radius + transform.position;
        randomVector.y = Mathf.Abs(randomVector.y);
        randomVector.y = transform.position.y;
        GameObject clone9;
        clone9 = Instantiate(trapSpawnable, randomVector, rotationStraight);

        clone9.AddComponent<Rigidbody>();
        Rigidbody cloneRB9 = clone9.GetComponent<Rigidbody>();
        randomVector.y = 0;
        randomVector.x = randomVector.x * 0.0000000000000000000000000000000001f;
        randomVector.z = randomVector.z * 0.0000000000000000000000000000000001f;
        cloneRB5.AddForce(randomVector);

        randomVector = Random.insideUnitSphere * radius + transform.position;
        randomVector.y = Mathf.Abs(randomVector.y);
        randomVector.y = transform.position.y;

        Destroy(clone, 7f);
        Destroy(clone1, 7f);
        Destroy(clone2, 7f);
        Destroy(clone3, 7f);
        Destroy(clone4, 7f);
        Destroy(clone5, 7f);
        Destroy(clone6, 7f);
        Destroy(clone7, 7f);
        Destroy(clone8, 7f);
        Destroy(clone9, 7f);
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        // Code to execute after the delay
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            currentAudio.Play();
            GameObject clone;
            Vector3 randomVector;
            Quaternion rotationStraight = Quaternion.Euler(0, 0, 0);
            Destroy(gameObject);


            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = transform.position.y;
            clone = Instantiate(trapSpawnable, randomVector, rotationStraight);

            clone.AddComponent<Rigidbody>();
            Rigidbody cloneRB = clone.GetComponent<Rigidbody>();
            randomVector.y = 0;
            randomVector.x = randomVector.x * 0.0000000000000000000000000000000001f;
            randomVector.z = randomVector.z * 0.0000000000000000000000000000000001f;


            cloneRB.AddForce(randomVector);

            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = transform.position.y;
            GameObject clone1;
            clone1 = Instantiate(trapSpawnable, randomVector, rotationStraight);

            clone1.AddComponent<Rigidbody>();
            Rigidbody cloneRB1 = clone1.GetComponent<Rigidbody>();
            randomVector.y = 0;
            randomVector.x = randomVector.x * 0.0000000000000000000000000000000001f;
            randomVector.z = randomVector.z * 0.0000000000000000000000000000000001f;
            cloneRB1.AddForce(randomVector);


            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = transform.position.y;
            GameObject clone2;
            clone2 = Instantiate(trapSpawnable, randomVector, rotationStraight);

            clone2.AddComponent<Rigidbody>();
            Rigidbody cloneRB2 = clone2.GetComponent<Rigidbody>();
            randomVector.y = 0;
            randomVector.x = randomVector.x * 0.0000000000000000000000000000000001f;
            randomVector.z = randomVector.z * 0.0000000000000000000000000000000001f;
            cloneRB2.AddForce(randomVector);

            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = transform.position.y;
            GameObject clone3;
            clone3 = Instantiate(trapSpawnable, randomVector, rotationStraight);

            clone3.AddComponent<Rigidbody>();
            Rigidbody cloneRB3 = clone3.GetComponent<Rigidbody>();
            randomVector.y = 0;
            randomVector.x = randomVector.x * 0.0000000000000000000000000000000001f;
            randomVector.z = randomVector.z * 0.0000000000000000000000000000000001f;
            cloneRB3.AddForce(randomVector);


            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = transform.position.y;
            GameObject clone4;
            clone4 = Instantiate(trapSpawnable, randomVector, rotationStraight);

            clone4.AddComponent<Rigidbody>();
            Rigidbody cloneRB4 = clone4.GetComponent<Rigidbody>();
            randomVector.y = 0;
            randomVector.x = randomVector.x * 0.0000000000000000000000000000000001f;
            randomVector.z = randomVector.z * 0.0000000000000000000000000000000001f;
            cloneRB4.AddForce(randomVector);


            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = transform.position.y;
            GameObject clone5;
            clone5 = Instantiate(trapSpawnable, randomVector, rotationStraight);

            clone5.AddComponent<Rigidbody>();
            Rigidbody cloneRB5 = clone5.GetComponent<Rigidbody>();
            randomVector.y = 0;
            randomVector.x = randomVector.x * 0.0000000000000000000000000000000001f;
            randomVector.z = randomVector.z * 0.0000000000000000000000000000000001f;
            cloneRB5.AddForce(randomVector);

            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = transform.position.y;



            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = transform.position.y;
            GameObject clone6;
            clone6 = Instantiate(trapSpawnable, randomVector, rotationStraight);

            clone5.AddComponent<Rigidbody>();
            Rigidbody cloneRB6 = clone6.GetComponent<Rigidbody>();
            randomVector.y = 0;
            randomVector.x = randomVector.x * 0.0000000000000000000000000000000001f;
            randomVector.z = randomVector.z * 0.0000000000000000000000000000000001f;
            cloneRB5.AddForce(randomVector);

            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = transform.position.y;


            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = transform.position.y;
            GameObject clone7;
            clone7 = Instantiate(trapSpawnable, randomVector, rotationStraight);

            clone7.AddComponent<Rigidbody>();
            Rigidbody cloneRB7 = clone7.GetComponent<Rigidbody>();
            randomVector.y = 0;
            randomVector.x = randomVector.x * 0.0000000000000000000000000000000001f;
            randomVector.z = randomVector.z * 0.0000000000000000000000000000000001f;
            cloneRB7.AddForce(randomVector);

            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = transform.position.y;



            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = transform.position.y;
            GameObject clone8;
            clone8 = Instantiate(trapSpawnable, randomVector, rotationStraight);

            clone8.AddComponent<Rigidbody>();
            Rigidbody cloneRB8 = clone8.GetComponent<Rigidbody>();
            randomVector.y = 0;
            randomVector.x = randomVector.x * 0.0000000000000000000000000000000001f;
            randomVector.z = randomVector.z * 0.0000000000000000000000000000000001f;
            cloneRB5.AddForce(randomVector);

            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = transform.position.y;



            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = transform.position.y;
            GameObject clone9;
            clone9 = Instantiate(trapSpawnable, randomVector, rotationStraight);

            clone9.AddComponent<Rigidbody>();
            Rigidbody cloneRB9 = clone9.GetComponent<Rigidbody>();
            randomVector.y = 0;
            randomVector.x = randomVector.x * 0.0000000000000000000000000000000001f;
            randomVector.z = randomVector.z * 0.0000000000000000000000000000000001f;
            cloneRB5.AddForce(randomVector);

            randomVector = Random.insideUnitSphere * radius + transform.position;
            randomVector.y = Mathf.Abs(randomVector.y);
            randomVector.y = transform.position.y;

            Destroy(clone, 7f);
            Destroy(clone1, 7f);
            Destroy(clone2, 7f);
            Destroy(clone3, 7f);
            Destroy(clone4, 7f);
            Destroy(clone5, 7f);
            Destroy(clone6, 7f);
            Destroy(clone7, 7f);
            Destroy(clone8, 7f);
            Destroy(clone9, 7f);
        }
        else
        if (collision.gameObject.tag == "Environment") {
            Invoke("explosion", 3f);
            
        }

        

    }
}
