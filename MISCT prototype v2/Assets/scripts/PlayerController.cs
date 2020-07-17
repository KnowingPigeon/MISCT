using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [Tooltip("Controls player speed")]
    public float Speed = 10;
    Rigidbody2D myRB;
    void Start()
    {
        //grab rigid body of player
        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

            Vector2 movement = new Vector2();
            movement.x = Input.GetAxisRaw("Horizontal") * Speed;
            movement.y = Input.GetAxisRaw("Vertical") * Speed;

            myRB.velocity = movement;
    }
}
