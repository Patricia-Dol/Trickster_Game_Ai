using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingCeiling : MonoBehaviour
{
    public Rigidbody2D ceilingRb; // Changed from Rigidbody to Rigidbody2D since you're using 2D colliders
    public GameObject panelToAppear; // Reference to the panel to appear
    public float panelDisplayTime = 3f; // Time in seconds to display the panel

    public Collider2D listCollider;
    public Collider2D starCollider;
    public Collider2D pipeCollider;
    public Collider2D snakeCollider;
    public Collider2D muralCollider;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider belongs to the player
        if (other.CompareTag("Player"))
        {
            // Start coroutine to display panel for a limited time
            StartCoroutine(DisplayPanel());

            // Deactivate colliders after the panel display time
            Invoke("DeactivateCollidersAndGravity", panelDisplayTime);
        }
    }

    // Coroutine to display the panel for a limited time
    private IEnumerator DisplayPanel()
    {
        panelToAppear.SetActive(true);
        yield return new WaitForSeconds(panelDisplayTime);
        panelToAppear.SetActive(false);
    }

    // Method to deactivate colliders and activate gravity
    private void DeactivateCollidersAndGravity()
    {
        // Deactivate colliders
        if (starCollider != null)
        {
            starCollider.enabled = false;
        }

        if (listCollider != null)
        {
            listCollider.enabled = false;
        }

        if (pipeCollider != null)
        {
            pipeCollider.enabled = false;
        }

        if (snakeCollider != null)
        {
            snakeCollider.enabled = false;
        }

        if (muralCollider != null)
        {
            muralCollider.enabled = false;
        }

        // Activate gravity for the ceiling
        if (ceilingRb != null)
        {
            ceilingRb.gravityScale = 0.2f;
        }
    }
}
