using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteractions : MonoBehaviour
{
    PlaceThingForE justE;

    private void Awake()
    {
        justE = FindObjectOfType<PlaceThingForE>();
    }
    private void Start()
    {
        justE.gameObject.SetActive(false);
        Debug.Log("off");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Friend")
        {
            justE.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Friend")
        {
            justE.gameObject.SetActive(false);
        }
    }
}
