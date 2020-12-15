using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puddle : MonoBehaviour
{
    public int puddlePowerDown;

    void Start()
    {
        puddlePowerDown = 10;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            ScoreManager.timeLeft -= puddlePowerDown;

        }
    }
}
