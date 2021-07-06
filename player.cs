using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class player : MonoBehaviour
{
    public float moveSpeed;
    public float speedMulti;
    public float speedIcreansekamien;
    private float speedMilestoneCount;

    public float jumpHeight;


    private Rigidbody2D mojeciało;

    

    public bool uziemnienie;
    public LayerMask cojestziemia;

    private Collider2D mojakolizja;

    private Animator myanimator;

    void Start()
    {
        mojeciało = GetComponent<Rigidbody2D>();

        mojakolizja = GetComponent<Collider2D>();

        myanimator = GetComponent<Animator>();

        speedMilestoneCount = speedIcreansekamien;

    }

    // Update is called once per frame
    void Update()
    {
        
        
        uziemnienie = Physics2D.IsTouchingLayers(mojakolizja, cojestziemia);

        if(transform.position.x > speedMilestoneCount)
        {
            speedMilestoneCount += speedIcreansekamien;

            speedIcreansekamien = speedIcreansekamien * speedMulti;
            moveSpeed = moveSpeed * speedMulti;
        }


        mojeciało.velocity = new Vector2(moveSpeed, mojeciało.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId)) 
        {

            
            if (uziemnienie)
            {
                mojeciało.velocity = new Vector2(mojeciało.velocity.x, jumpHeight);
            }

        }

        myanimator.SetFloat("speed", mojeciało.velocity.x);
        myanimator.SetBool("uziemnienie", uziemnienie);

    }


    // kod na pauze do gry !!! Input.GetTouch(0).fingerId wkleic do nawiasow eventsystem

    //if(Input.GetKeyDown(KeyCode.W))
    //{
    //GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
}
//if (Input.GetKey(KeyCode.D))

// {

//GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

//}
// if (Input.GetKey(KeyCode.A))

// {

//GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

// }
//}
