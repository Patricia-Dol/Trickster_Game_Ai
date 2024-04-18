using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popupList : MonoBehaviour
{
    [SerializeField] GameObject listPanel;    // Reference to the panel associated with the mural
    private GameObject listObject;  // Reference to the mural GameObject

    private void Start()
    {
        // Find the mural GameObject within the Level GameObject
        listObject = GameObject.Find("level/list"); // Adjust the path based on your hierarchy
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == listObject)
        {
            listPanel.SetActive(true);    // Activate the panel associated with the mural
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == listObject)
        {
            listPanel.SetActive(false);    // Deactivate the panel associated with the mural
        }
    }
}
