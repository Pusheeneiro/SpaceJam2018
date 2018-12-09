﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {
   private  GameObject player;
    private Vector2 enemyPlayerPosition2D;
    private Vector2 playerPosition2D;
    private Rigidbody2D playerBody;
    private Vector2 forceW;
    private GameObject enemyPlayer;
    private Rigidbody2D enemyPlayerBody;

    public float speedHorizontal;
    public float speedVertical;
    public float forceVertical;
    public bool spacePhysic;
    public Vector2 enemyEscapeVector ;

    // Use this for initialization
    void Start ()
    {
        player = GameObject.Find("Player1");
        enemyPlayerPosition2D = GameObject.Find("Player2").transform.position; ;
        enemyPlayer = GameObject.Find("Player2");
        enemyPlayerBody = enemyPlayer.GetComponent<Rigidbody2D>();

        playerBody = player.GetComponent<Rigidbody2D>();
        playerPosition2D = new Vector2(0, 0);
        forceW = new Vector2(0, forceVertical);

        if (spacePhysic == false)
        {
            playerBody.gravityScale = 1;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (spacePhysic == false)
        {
             playerPosition2D.x = 0;
             if (Input.GetKeyDown(KeyCode.W)) 
              {
                 playerBody.AddForce(forceW);
              }
        }



        if (Input.GetKeyDown(KeyCode.W))
        {
            playerPosition2D.y = speedVertical;
            playerPosition2D.x = 0;
        }


        if (Input.GetKeyDown(KeyCode.A))
        {
            playerPosition2D.y = 0;
            playerPosition2D.x = -speedHorizontal;

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            playerPosition2D.y = -speedVertical;
            playerPosition2D.x = 0;

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            playerPosition2D.y = 0;
            playerPosition2D.x = speedHorizontal;

        }

       
        

    }

    void FixedUpdate()
    {

        if (spacePhysic == true)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
                playerBody.MovePosition(playerBody.position + playerPosition2D * Time.fixedDeltaTime);
            }
        }

        else
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                playerBody.MovePosition(playerBody.position + playerPosition2D * Time.fixedDeltaTime);
            }
        }
       
    }

    void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.gameObject.name == "Player2")
        {

            enemyPlayerBody.transform.position = enemyEscapeVector;
        }
    }
}
