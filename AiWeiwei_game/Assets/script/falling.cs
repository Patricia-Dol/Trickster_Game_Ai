using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject ceiling; // Reference to the ceiling object
    public GameObject star; // Reference to the star object

    private Rigidbody ceilingRb;
    private Collider playerCollider;
    private Collider starCollider;

    void Start()
    {
        ceilingRb = ceiling.GetComponent<Rigidbody>();
        playerCollider = GetComponent<Collider>();
        starCollider = star.GetComponent<Collider>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the player collides with the star
        if (collision.gameObject == star)
        {
            // Deactivate the colliders of the player and the star
            playerCollider.enabled = false;
            starCollider.enabled = false;

            // Activate gravity for the ceiling
            ceilingRb.useGravity = true;
        }
    }
}

