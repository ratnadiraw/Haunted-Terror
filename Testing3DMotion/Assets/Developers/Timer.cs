using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public Text TimerText;
    public float StartTime;
	// Use this for initialization
	void Start () {
        StartTime = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        float t = Time.time - StartTime;

        string min = ((int)t / 60).ToString();
        string sec = (t % 60).ToString();
        TimerText.text = min + ":" + sec;
    }
}
