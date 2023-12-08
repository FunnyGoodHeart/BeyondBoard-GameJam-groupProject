using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class LilyChat : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI chatBox;
    [SerializeField] List<ChatSO>
    
    CharacterInteractions interact;
    bool eInteract;

    private void Start()
    {
        interact = GetComponent<CharacterInteractions>();
        eInteract = interact.eTextActive;
    }
    void OnInteract()
    {
        if (eInteract)
        {
        }
    }
    void OnClick()
    {
    }
}
