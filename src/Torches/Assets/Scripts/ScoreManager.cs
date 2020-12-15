using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum gameState
{
    levelStart,
    levelProgressing,
    Loss,
    Win
}

public class ScoreManager : MonoBehaviour
{
    public static float timeLeft;

    public Text timerText, oilTimer, keyText, statusText;

    public static float oilTimeLeft;
    public static bool oilTimerOn;

    public static gameState state;

    void Start()
    {
        timeLeft = 90;
        oilTimeLeft = 0;

        state = gameState.levelStart;

    }

    void Update()
    {
        keyText.text = "Keys: " + KeyPickup.Keys.ToString();
        timerText.text = "Time Remaining: " + ScoreManager.timeLeft.ToString();
        oilTimer.text = "Oil Burn Remaining: " + ScoreManager.oilTimeLeft.ToString();

        if (state == gameState.levelStart) //Level waiting to start by user action
        {
            statusText.text = "Press 1 to start!";

            if (Input.GetKeyDown("1"))
            {
                state = gameState.levelProgressing;
            }
        }

        if (state == gameState.levelProgressing && timeLeft > 0) //User playing level 
        {
            statusText.text = "";
            timeLeft -= Time.deltaTime;
        }

        if (timeLeft <= 0)
        {
            state = gameState.Loss;
            timeLeft = 0;
        }

        //Oil Logic
        if (oilTimerOn)
        {
            oilTimeLeft -= Time.deltaTime;
        }

        if (oilTimeLeft <= 0)
        {
            oilTimeLeft = 0;
            oilTimerOn = false;
        }

        //Win/Loss Logic
        if (state == gameState.Win) //If user finds key and puts into lock...
        {
            statusText.text = "You've won! Press 1 to return to level select!";


            if (Input.GetKeyDown("1"))
            {
                SceneManager.LoadScene("Menu");
            }
        }

        if (state == gameState.Loss) //If user doesnt find key for lock in time...
        {
            statusText.text = "You've lost! Press 1 to return to level select!";

            if (Input.GetKeyDown("1"))
            {
                SceneManager.LoadScene("Menu");
            }
        }

    }
}
