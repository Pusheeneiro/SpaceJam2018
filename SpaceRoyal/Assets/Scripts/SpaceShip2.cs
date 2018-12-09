using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpaceShip2 : MonoBehaviour
{

    public GameObject spaceShip;
    public GameObject buttonShipUp;
    public GameObject buttonShipDown;
    public GameObject buttonCannonLeft;
    public GameObject buttonCannonRight;
    public GameObject buttonCannonShot;
    public GameObject buttonBarrierLeft;
    public GameObject buttonBarrierRight;
    public GameObject buttonBarrierCenter;
    public GameObject buttonAutodestruct;


    private Vector2 cannonPosition2D;
    private GameObject cannon;
    private Rigidbody2D cannonBody;

    public GameObject leftBarrier;
    public GameObject rightBarrier;
    public GameObject centerBarrier;


    public float cannonSpeed;
    public bool cannonShouldMove;
    public float speed;

    public bool shipShouldMove;
    public float speedShip;

    // Use this for initialization
    void Start()
    {
        cannon = GameObject.Find("SpaceShip2/Cannon");
        cannonBody = cannon.GetComponent<Rigidbody2D>();
        cannonPosition2D = new Vector2(0, 0);


    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {

        if (cannonShouldMove)
        {
            cannonBody.transform.position = new Vector2(cannonBody.transform.position.x + speed, cannonBody.transform.position.y);
            cannonShouldMove = false;
        }


        if (shipShouldMove)
        {
            cannonBody.transform.position = new Vector2(cannonBody.transform.position.x, cannonBody.transform.position.y + speedShip);
            shipShouldMove = false;
        }

        ////cannonBody.MovePosition(cannonBody.position + cannonPosition2D * Time.fixedDeltaTime)
    }

    void OnTriggerStay2D(Collider2D other)
    {
        string[] buttons = { "ButtonShipDown", "ButtonShipUp", "ButtonBarrierLeft", "ButtonBarrierRight", "ButtonBarrierCenter", "ButtonCannonLeft", "ButtonCannonRight", "ButtonCannonShot", "ButtonAutodestruct" };
        //int[] layers = { 8, 9 };

        if (other.gameObject.name == "ButtonShipDown" && other.gameObject.layer == 9)
        {
            shipShouldMove = true;
            speedShip = -0.2f;
        }

        if (other.gameObject.name == "ButtonShipUp" && other.gameObject.layer == 9)
        {
            shipShouldMove = true;
            speedShip = 0.2f;
        }

        if (other.gameObject.name == "ButtonBarrierLeft" && other.gameObject.layer == 9)
        {

        }

        if (other.gameObject.name == "ButtonBarrierRight" && other.gameObject.layer == 9)
        {

        }

        if (other.gameObject.name == "ButtonBarrierCenter" && other.gameObject.layer == 9)
        {

        }

        if (other.gameObject.name == "ButtonCannonLeft" && other.gameObject.layer == 9)
        {

            cannonShouldMove = true;
            speed = -0.2f;

        }

        if (other.gameObject.name == "ButtonCannonRight" && other.gameObject.layer == 9)
        {

            cannonShouldMove = true;
            speed = 0.2f;
        }

        if (other.gameObject.name == "ButtonCannonShot" && other.gameObject.layer == 9)
        {

        }

        if (other.gameObject.name == "ButtonAutodestruct" && other.gameObject.layer == 9)
        {

        }

    }
}

