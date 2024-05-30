using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GoingThroughDoor : MonoBehaviour
{
    PlaceThingForE justE;
    bool nearDoor = false;
    GameObject nearbyDoor;
    int door2X = 0;
    int door2Y = 0;
    int door2Z = 0;

    private void Awake()
    {
        justE = FindObjectOfType<PlaceThingForE>();
    }
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Door")
        {
            justE.gameObject.SetActive(true);
            nearbyDoor = collision.gameObject;
            nearDoor = true;
        }
    }
    void OnInteract()
    {
        if (nearDoor)
        {
            if(nearbyDoor.gameObject.name == "Door 1")
            {
                
            }
        }
    }
}
