using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Scary Baby")
        {
            if(KeyPickup.Keys >= 1)
            {
                KeyPickup.Keys--;
                ScoreManager.levelWin = true;
            }
        }
    }
}
