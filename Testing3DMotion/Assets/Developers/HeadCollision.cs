using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeadCollision : MonoBehaviour
{
    public GameObject terserah;
    public PlayerHealth script;
    public HealthPlayer script2;
    // Use this for initialization
    void Start()
    {
        terserah = GameObject.Find("HeadCollider");
        script = (PlayerHealth)terserah.GetComponent(typeof(PlayerHealth));
        script2 = (HealthPlayer)terserah.GetComponent(typeof(HealthPlayer));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "HeartCube")
        {
            Destroy(collision.gameObject);
            script.TakeHealth(10);
            script2.TakeHealth(10);
        }
    }
}
