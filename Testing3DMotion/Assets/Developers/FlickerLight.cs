using UnityEngine;
using System.Collections;

public class FlickerLight : MonoBehaviour
{

    public GameObject Lights;
    public float timer;

    void Start()
    {
        StartCoroutine(FlickeringLight());
    }

    IEnumerator FlickeringLight()
    {
        Lights.SetActive(true);
        timer = Random.Range(0.1f, 2);
        yield return new WaitForSeconds(timer);
        Lights.SetActive(false);
        timer = Random.Range(0.1f, 3);
        yield return new WaitForSeconds(timer);
        StartCoroutine(FlickeringLight());
    }
}
