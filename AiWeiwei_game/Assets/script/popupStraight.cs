using UnityEngine;

public class popupStraight : MonoBehaviour
{
    [SerializeField] GameObject pipePanel;    // Reference to the panel associated with the mural
    private GameObject pipeObject;  // Reference to the mural GameObject

    private void Start()
    {
        // Find the mural GameObject within the Level GameObject
        pipeObject = GameObject.Find("level/pipes"); // Adjust the path based on your hierarchy
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == pipeObject)
        {
            pipePanel.SetActive(true);    // Activate the panel associated with the mural
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == pipeObject)
        {
            pipePanel.SetActive(false);    // Deactivate the panel associated with the mural
        }
    }
}
