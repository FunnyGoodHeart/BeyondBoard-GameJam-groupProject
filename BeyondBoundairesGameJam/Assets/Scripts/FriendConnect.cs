using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendConnect : MonoBehaviour
{
    [SerializeField] bool firstInteraction = true;
    [SerializeField] int repeatStartPosition;
    public string friendName;
    public DialogueDisplay dialogueDisplay;
    [HideInInspector]
    public int StartPosition
    {
        get
        {
            if (firstInteraction)
            {
                firstInteraction = false;
                return 0;
            }
            else
            {
                return repeatStartPosition;
            }
        }
    }

    internal DialogueDisplay DialogueDisplay(string dialogue, string name)
    {
        throw new NotImplementedException();
    }
}

