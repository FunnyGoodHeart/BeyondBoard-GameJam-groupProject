using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Chat Log", fileName = "New Chat")]
public class ChatSO : ScriptableObject
{
    [SerializeField] string[] chat = new string[4];
    [SerializeField] int chatAmmount = 4;
    //chat ammount need to be manually changed but
    //should be same ammount as string count
}
