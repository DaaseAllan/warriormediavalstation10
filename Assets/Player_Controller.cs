using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour {

    public float MovSpeed;

    public float torque;
    public Rigidbody2D body;


    void Update () {
        print(Input.GetButton("p1_right"));

        if(Input.GetButton("p1_right") == true && Input.GetButton("p1_left") == false)
        {
            body.velocity = new Vector2(0, 0);
            body.angularVelocity = -100;
        }


        else if(Input.GetButton("p1_left") == true && Input.GetButton("p1_right") == false)
        {
            body.velocity = new Vector2(0, 0);
            body.angularVelocity = 100;
        }


        else if(Input.GetButton("p1_left") == true && Input.GetButton("p1_right") == true)
        {
            body.angularVelocity = 0;
            body.velocity = transform.up * MovSpeed;
        }


        else
        {
            body.velocity = new Vector2(0, 0);
            body.angularVelocity = 0;
        }
    }
}
