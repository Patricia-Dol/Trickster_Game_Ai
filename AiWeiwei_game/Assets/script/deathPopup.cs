using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathPopup : MonoBehaviour
{
    [SerializeField] GameObject deathPanel;    // Reference to the panel associated with the mural
    private GameObject ceilingObject;  // Reference to the mural GameObject

    private void Start()
    {
        // Find the mural GameObject within the Level GameObject
        ceilingObject = GameObject.Find("falling"); // Adjust the path based on your hierarchy
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == ceilingObject)
        {
            deathPanel.SetActive(true);    // Activate the panel associated with the mural
        }
    }
}
