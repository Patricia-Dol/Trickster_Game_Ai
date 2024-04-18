using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popupSnake : MonoBehaviour
{
    [SerializeField] GameObject snakePanel;    // Reference to the panel associated with the mural
    private GameObject snakeObject;  // Reference to the mural GameObject

    private void Start()
    {
        // Find the mural GameObject within the Level GameObject
        snakeObject = GameObject.Find("level/snake"); // Adjust the path based on your hierarchy
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == snakeObject)
        {
            snakePanel.SetActive(true);    // Activate the panel associated with the mural
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == snakeObject)
        {
            snakePanel.SetActive(false);    // Deactivate the panel associated with the mural
        }
    }
}
