using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] float talkDistance = 2;
    bool inConversation;
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
                if (hitInfo.collider.gameObject.TryGetComponent(out NPC npc))
                {
                    DialogueDisplay.instance.StartDialogue(npc.dialogueAsset.dialogue, npc.StartPosition, npc.npcName);
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
