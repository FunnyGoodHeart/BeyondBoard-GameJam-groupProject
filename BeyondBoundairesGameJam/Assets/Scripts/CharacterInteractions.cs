using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class CharacterInteractions : MonoBehaviour
{
    //chat activity
    [SerializeField] TextMeshProUGUI chatBox;
    FragmentCollection fragments;
    int fragmentsCounting;
    PlaceThingForE justE;
    ChatBoxandTextPlacement chatboxandtext;
    bool eTextActive = false;
    public bool chatActive = false;

    [Header("Lily's stuff")]
    [SerializeField] string[] lilysChat1 = new string[4];
    [SerializeField] string[] lilysChat2 = new string[4];
    bool lilysChat = false;
    bool inLilysChat = false;
    bool lilysFI = true;
    int lilyI = 0;

    [Header("Bennet's stuff")]
    [SerializeField] string[] bennetsChat1 = new string[4];
    bool bennetsChat = false;
    bool inBennetsChat = false;
    bool bennetsFI = true;
    int bennetsI = 0;

    private void Awake()
    {
        justE = FindObjectOfType<PlaceThingForE>();
        chatboxandtext = FindObjectOfType<ChatBoxandTextPlacement>();
        fragments = GetComponent<FragmentCollection>();
    }
    private void Start()
    {
        justE.gameObject.SetActive(false);
        chatboxandtext.gameObject.SetActive(false);
        Debug.Log("off");
    }
    private void Update()
    {
        fragmentsCounting = fragments.fragmentCount;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Friend")
        {
            justE.gameObject.SetActive(true);
            eTextActive = true;
        }
        if(collision.gameObject.name == "Lily")
        {
            lilysChat = true;
        }
        if(collision.gameObject.name == "Bennet")
        {
            bennetsChat = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Friend")
        {
            justE.gameObject.SetActive(false);
            eTextActive = false;
        }
        lilysChat = false;
        bennetsChat = false;
    }
    void OnInteract()
    {
        if (eTextActive)
        {
            chatActive = true;
            chatboxandtext.gameObject.SetActive(true);
        }
        if (lilysChat)
        {
            if (lilysFI)
            {
                chatBox.text = "Hello! it seems we have not met before";
                lilysFI = false;
                inLilysChat = true;
            }
            else
            {
                chatBox.text = "Hello!";
                inLilysChat = true;
            }
        }
        if (bennetsChat)
        {
            if (bennetsFI)
            {
                chatBox.text = "Hiya im Bennet!";
                bennetsFI = false;
                inBennetsChat = true;
            }
            else
            {
                chatBox.text = "hiya again!";
                inBennetsChat = true;
            }
        }
    }
    void OnClick()
    {
        if(inLilysChat)
        {
            
            if(lilyI < lilysChat2.Length && fragmentsCounting == 1)
            {
                chatBox.text = lilysChat2[lilyI];
                lilyI++;
            }
            else if (lilyI < lilysChat1.Length)
            {
                chatBox.text = lilysChat1[lilyI];
                lilyI++;
            }
            else
            {
                chatboxandtext.gameObject.SetActive(false);
                lilyI = 0;
                inLilysChat = false;
                lilysChat = false;
                return;
            }
        }
        if(inBennetsChat)
        {
            if (bennetsI < bennetsChat1.Length)
            {
                chatBox.text = bennetsChat1[bennetsI];
                bennetsI++;
            }
            else
            {
                chatboxandtext.gameObject.SetActive(false);
                bennetsI = 0;
                inBennetsChat = false;
                bennetsChat = false;
                return;
            }
        }
    }
}
