using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    //Used for testing and debugging

    void OnCollisionEnter2D(Collision2D col)
    {
        gameObject.SetActive(false);
    }
}
