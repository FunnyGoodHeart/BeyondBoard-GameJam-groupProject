using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LilyChat : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI chatBox;
    ChatBoxandTextPlacement chatboxandtext;
    CharacterInteractions interactions;
    bool activeChat = false;

    private void Start()
    {
        interactions = GetComponent<CharacterInteractions>();
    }
    private void Update()
    {
        bool chatActive = interactions.chatActive;
        activeChat = chatActive;
        Debug.Log(activeChat);
        Debug.Log("AAAAA");
        if (activeChat)
        {
            Debug.Log("Hello");
            chatboxandtext.gameObject.SetActive(true);
            chatBox.text = "Hello";
        }
    }
}
