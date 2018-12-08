using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour {

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
    public GameObject cannon;
    public GameObject leftBarrier;
    public GameObject rightBarrier;
    public GameObject centerBarrier;


    // Use this for initialization
    void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        
    }
}
