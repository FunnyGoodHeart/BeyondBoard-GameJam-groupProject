using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Chat", menuName = "Dialogue")]
public class DialogueTree : ScriptableObject
{
    [TextArea(3, 6)]
    [SerializeField] string[] lines;
}
