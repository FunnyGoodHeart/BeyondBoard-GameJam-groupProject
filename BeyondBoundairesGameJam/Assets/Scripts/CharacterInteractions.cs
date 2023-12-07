using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterInteractions : MonoBehaviour
{
    PlaceThingForE justE;
    ChatBoxandTextPlacement chatboxandtext;
    bool ETextActive = false;

    private void Awake()
    {
        justE = FindObjectOfType<PlaceThingForE>();
        chatboxandtext = FindObjectOfType<ChatBoxandTextPlacement>();
    }
    private void Start()
    {
        justE.gameObject.SetActive(false);
        chatboxandtext.gameObject.SetActive(false);
        Debug.Log("off");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Friend")
        {
            justE.gameObject.SetActive(true);
            ETextActive = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Friend")
        {
            justE.gameObject.SetActive(false);
            ETextActive = false;
        }
    }
    void OnInteract()
    {
        if (ETextActive)
        {
            chatboxandtext.gameObject.SetActive(true);
        }
    }
}
