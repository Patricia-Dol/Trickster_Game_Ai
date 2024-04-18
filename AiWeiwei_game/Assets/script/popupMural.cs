using UnityEngine;

public class PopupMural : MonoBehaviour
{
    [SerializeField] GameObject muralPanel;    // Reference to the panel associated with the mural
    private GameObject muralObject;  // Reference to the mural GameObject

    private void Start()
    {
        // Find the mural GameObject within the Level GameObject
        muralObject = GameObject.Find("level/mural"); // Adjust the path based on your hierarchy
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == muralObject)
        {
            muralPanel.SetActive(true);    // Activate the panel associated with the mural
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == muralObject)
        {
            muralPanel.SetActive(false);    // Deactivate the panel associated with the mural
        }
    }
}
