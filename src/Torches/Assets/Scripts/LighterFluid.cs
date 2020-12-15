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


    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            ScoreManager.timeLeft = ScoreManager.timeLeft + lfPowerUp;
            gameObject.SetActive(false);
        }
    }

}
