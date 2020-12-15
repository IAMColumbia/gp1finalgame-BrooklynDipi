using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighterFluid : MonoBehaviour
{
    public int lfPowerUp;

    void Start()
    {
        lfPowerUp = 30;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Scary Baby")
        {
            ScoreManager.timeLeft = ScoreManager.timeLeft + lfPowerUp;
            gameObject.SetActive(false);
        }

        //tag for enemy, they get component

    }

}
