using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class CharacterInteractions : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI chatBox;
    PlaceThingForE justE;
    ChatBoxandTextPlacement chatboxandtext;
    bool eTextActive = false;
    public bool chatActive = false;

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
            eTextActive = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Friend")
        {
            justE.gameObject.SetActive(false);
            eTextActive = false;
        }
    }
    void OnInteract()
    {
        if (eTextActive)
        {
            chatActive = true;
            //chatboxandtext.gameObject.SetActive(true);
            //chatBox.text = "AAAAAAAAAA";
        }
    }
}
