using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boost = 30f;
    [SerializeField] float norm = 20f;

    SurfaceEffector2D surface2d;

    bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        rb2d =GetComponent<Rigidbody2D>();
        surface2d = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            Rotate();
            RespondToBoost();
        }
        
    }

    public void DisableControl()
    {
        canMove = false;
    }

    void RespondToBoost()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            surface2d.speed = boost;
        }
        else
        {
            surface2d.speed = norm;
        }
    }

    void Rotate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
