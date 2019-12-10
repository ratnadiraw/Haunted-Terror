using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEventController : MonoBehaviour {
    // To Make Static?
    public static GameEventController instance = null;
    public int maxTimeInSeconds;       // Menentukan threshold score
    public int enemyToKill;            // Menentukan threshold musuh yang harus dibunuh
    public static int killedEnemy;            // Menentukan jumlah musuh yang telah dibunuh
    public Text winningText;
    public Text pointText;
    public Button nextGame;
    private bool shouldScore;
    public int score;
    public int scoreMinusParameter;
    public int level;

    public bool win;

    // Object object dari script lain
    public Timer timerScript;

    private void Awake()
    {

        winningText.gameObject.SetActive(false);
        pointText.gameObject.SetActive(false);
        nextGame.gameObject.SetActive(false);
        if (instance == null)
        {
            instance = this;
        }
        else {
            Destroy(gameObject);
        }
        shouldScore = true;
        win = false;
        score = 999999;
        killedEnemy = 0;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (killedEnemy >= enemyToKill) {
            // KONDISI MENANG
            if (shouldScore) {
                shouldScore = false;
                // setiap x detik dari maxTimeInSeconds, kurangkan score sebesar y
                float timeBegin = timerScript.StartTime;
                float timeNow = Time.time;
                float timeDiffInSecond = timeNow - timeBegin;
                int timeDiffInt = Mathf.RoundToInt(timeDiffInSecond);
                // Kurangi score setiap detik
                for (int i = maxTimeInSeconds; i <= timeDiffInt; i++) {
                    score -= scoreMinusParameter;
                }
                Debug.LogWarning("TIME IN SECONDS: " + timeDiffInSecond);
            }
            winningText.text = "CONGRATULATION";
            winningText.gameObject.SetActive(true);
            pointText.text = score+"";
            pointText.gameObject.SetActive(true);
            nextGame.gameObject.SetActive(true);
            Debug.LogWarning("WINNING CONDITION");
            win = true;
        }

        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) == true)
        {
            if (win)
            {
                if (level == 0)
                {
                    SceneManager.LoadScene("Level1");

                } else if (level == 1)
                {
                    SceneManager.LoadScene("Level2fix");
                } else
                {

                    SceneManager.LoadScene("StartSceneNew");
                }
            }
        }
	}
}
