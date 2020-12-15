using UnityEngine;
using System.Collections;
//Code by Brooklyn DiPietrantonio, git @Brooklyndipi. Tutorial help 
//from https://learn.unity.com/tutorial/movement-basics#5c7f8528edbc2a002053b711

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);
    }
}