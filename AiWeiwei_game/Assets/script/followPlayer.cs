using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    //the position you want it compaired to the character
    private Vector3 offset = new Vector3 (0f, 2f, -10f);
    //how long you want it to take to reach the player
    private float smoothTime = 0.05f;
    //
    private Vector3 velocity = Vector3.zero;
    //the charcter (obj it follows
    [SerializeField] private Transform target;

    // Update is called once per frame
    void Update()
    {
        //where you want the camera to be compaire the the obj (character)
        Vector3 targetPosition = target.position + offset;
        //moving the camera(cam position, where it should go, velocity, time to take)
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
