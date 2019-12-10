using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial : MonoBehaviour {

    public Text TutorialText;
    public float timer;
    public Image before;
    public Image when;
    public Image cmove;
    public Image heartmove;
    public Image downmove;
    public GameObject musuh;
    public GameObject tv;

    // Use this for initialization
    void Start () {
        StartCoroutine(Tutorial());
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    IEnumerator Tutorial()
    {
        TutorialText.gameObject.SetActive(true);
        timer = 5f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(false);
        TutorialText.text = "Look arround and move..";
        timer = 0.5f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(true);
        timer = 3f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(false);
        TutorialText.text = "by moving your head";
        timer = 0.5f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(true);
        timer = 3f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(false);
        TutorialText.text = "We give you magic power";
        timer = 0.5f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(true);
        timer = 3f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(false);
        TutorialText.text = "Draw magic pattern";
        timer = 0.5f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(true);
        timer = 3f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(false);
        TutorialText.text = "by holding and pressing";
        timer = 0.5f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(true);
        timer = 3f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(false);
        TutorialText.text = "thumb A button";
        timer = 0.5f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(true);
        timer = 3f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(false);
        timer = 0.5f;
        yield return new WaitForSeconds(timer);
        before.gameObject.SetActive(true);
        timer = 1f;
        yield return new WaitForSeconds(timer);
        while (!OVRInput.GetDown(OVRInput.Button.One))
        {
            yield return null;
        }
        when.gameObject.SetActive(true);
        while (!OVRInput.GetUp(OVRInput.Button.One))
        {
            yield return null;
        }
        when.gameObject.SetActive(false);

        timer = 2f;
        yield return new WaitForSeconds(timer);
        before.gameObject.SetActive(false);
        TutorialText.text = "make C gesture";
        timer = 0.5f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(true);
        timer = 2f;
        yield return new WaitForSeconds(timer);


        TutorialText.gameObject.SetActive(false);
        TutorialText.text = "make Heart gesture";
        timer = 0.5f;
        yield return new WaitForSeconds(timer);
        cmove.gameObject.SetActive(true);

        timer = 3f;
        yield return new WaitForSeconds(timer);
        cmove.gameObject.SetActive(false);


        timer = 0.5f;
        yield return new WaitForSeconds(timer);

        TutorialText.gameObject.SetActive(true);
        timer = 3f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(false);
        TutorialText.text = "make Down gesture";
        timer = 0.5f;
        yield return new WaitForSeconds(timer);
        heartmove.gameObject.SetActive(true);

        timer = 3f;
        yield return new WaitForSeconds(timer);
        heartmove.gameObject.SetActive(false);


        timer = 0.5f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(true);
        timer = 3f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(false);
        TutorialText.text = "Creating the same weapon cube";
        timer = 0.5f;
        yield return new WaitForSeconds(timer);
        downmove.gameObject.SetActive(true);

        timer = 3f;
        yield return new WaitForSeconds(timer);
        downmove.gameObject.SetActive(false);


        timer = 0.5f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(true);
        timer = 3f;
        yield return new WaitForSeconds(timer);
        before.gameObject.SetActive(false);
        TutorialText.text = "will delete the previous cube.";
        timer = 0.5f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(true);
        timer = 3f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(false);
        TutorialText.text = "There's hidden combo";
        timer = 0.5f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(true);
        timer = 3f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(false);
        TutorialText.text = "That lies in your hand";
        timer = 0.5f;
        yield return new WaitForSeconds(timer);
     
        TutorialText.gameObject.SetActive(true);
        timer = 3f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(false);
        TutorialText.text = "Defeat your enemy";
        timer = 0.5f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(true);
        timer = 3f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(false);
        TutorialText.text = "by throwing weapon cube.";
        timer = 0.5f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(true);
        timer = 3f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(false);
        TutorialText.text = "Good luck";
        timer = 0.5f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(true);
        timer = 3f;
        yield return new WaitForSeconds(timer);
        TutorialText.gameObject.SetActive(false);
        timer = 0.5f;
        yield return new WaitForSeconds(timer);
        musuh.SetActive(true);
        tv.SetActive(false);


    }
}
