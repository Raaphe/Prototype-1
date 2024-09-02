using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Vector3 offset = new Vector3(0, 5, 8);
    public GameObject player; 

    // Update is called once per frame
    void LateUpdate()
    {
        // Used to set the camera onto the vehicle with a desired offset.
        transform.position = player.transform.position + offset;
    }
}
