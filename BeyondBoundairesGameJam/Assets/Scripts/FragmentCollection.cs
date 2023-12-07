using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FragmentCollection : MonoBehaviour
{
    [SerializeField] int fragmentCount = 0;
    [SerializeField] TextMeshProUGUI fragmentText;


    void Start()
    {
        fragmentText.text = "Fragments Collected: " + fragmentCount;
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fragment")
        {
            fragmentCount++;
            fragmentText.text = "Fragments Collected: " + fragmentCount;
            Destroy(collision.gameObject);
        }
    }
}
