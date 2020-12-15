using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static float timeLeft;
    public static float oilTimeLeft;
    public Text timerText, oilTimer, keyText, statusText;

    public static bool oilTimerOn;

    public static bool levelWin;
    public static bool levelStarted;
    public static bool levelLost;

    void Start()
    {
        timeLeft = 90;
        oilTimeLeft = 0;
        levelWin = false;
        levelStarted = false;

    }

    void Update()
    {
        keyText.text = "Keys: " + KeyPickup.Keys.ToString();
        timerText.text = "Time Remaining: " + ScoreManager.timeLeft.ToString();
        oilTimer.text = "Oil Burn Remaining: " + ScoreManager.oilTimeLeft.ToString();

        if (!levelStarted)
        {
            statusText.text = "Press 1 to start!";

            if (Input.GetKeyDown("1"))
            {
                levelStarted = true;
            }
        }

        if (levelStarted && timeLeft > 0)
        {
            statusText.text = "";
            timeLeft -= Time.deltaTime;
        }

        if (oilTimerOn)
        {
            oilTimeLeft -= Time.deltaTime;
        }

        if (oilTimeLeft <= 0)
        {
            oilTimeLeft = 0;
            oilTimerOn = false;
        }

        if (levelWin)
        {
            statusText.text = "You've won! Press 1 to return to level select!";

            if (Input.GetKeyDown("1"))
            {
                SceneManager.LoadScene("Menu");
            }
        }

        if (levelLost)
        {
            statusText.text = "You've lost! Press 1 to return to level select!";

            if (Input.GetKeyDown("1"))
            {
                SceneManager.LoadScene("Menu");
            }
        }

        if (timeLeft <= 0)
        {
            levelLost = true;
            timeLeft = 0;
        }
    }
}
