using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {

    private GameObject player;
  
    private Vector2 playerPosition2D;
    private Vector2 enemyPlayerPosition2D;
    private Rigidbody2D playerBody;
    private Vector2 forceW;
    private GameObject enemyPlayer;
    private Rigidbody2D enemyPlayerBody;

    public Vector2 enemyEscapePosition;
    public float speedHorizontal;
    public float speedVertical;
    public float forceVertical;
    public bool spacePhysic;


    // Use this for initialization
    void Start ()
    {
        player = GameObject.Find("Player2");
        enemyPlayerPosition2D = GameObject.Find("Player1").transform.position;
        enemyPlayer = GameObject.Find("Player1");
        enemyPlayerBody = enemyPlayer.GetComponent<Rigidbody2D>();
        playerPosition2D = new Vector2(0, 0);
        


       
        playerBody = player.GetComponent<Rigidbody2D>();
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



        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerPosition2D.y = speedVertical;
            playerPosition2D.x = 0;
        }


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerPosition2D.y = 0;
            playerPosition2D.x = -speedHorizontal;

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerPosition2D.y = -speedVertical;
            playerPosition2D.x = 0;

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerPosition2D.y = 0;
            playerPosition2D.x = speedHorizontal;

        }
    }

    void FixedUpdate()
    {
        //enemyPlayerPosition2D = enemyEscapePosition;
        // enemyPlayerPosition2D = new Vector2(100, 100);
 

        if (spacePhysic == true)
        {
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
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
        if (Other.gameObject.name == "Player1")
        {
           
            enemyPlayerBody.transform.position = enemyEscapePosition;
        }
    }
}
