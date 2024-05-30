using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] float talkDistance = 2;
    bool inConversation;
    private string dialogue;

    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }
    void Interact()
    {
        if (inConversation)
        {
            DialogueDisplay.instance.SkipLine();
        }
        else
        {
            if (Physics.Raycast(new Ray(transform.position, transform.forward), out RaycastHit hitInfo, talkDistance))
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out FriendConnect npc))
                {
                    DialogueDisplay.instance.ShowDialogue(npc.DialogueDisplay(dialogue, name), npc.StartPosition, npc.friendName);
                }
            }
        }
    }
    void JoinConversation()
    {
        inConversation = true;
    }
    void LeaveConversation()
    {
        inConversation = false;
    }
    private void OnEnable()
    {
        DialogueDisplay.OnDialogueStarted += JoinConversation;
        DialogueDisplay.OnDialogueEnded += LeaveConversation;
    }
    private void OnDisable()
    {
        DialogueDisplay.OnDialogueStarted -= JoinConversation;
        DialogueDisplay.OnDialogueEnded -= LeaveConversation;
    }
}
