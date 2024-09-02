using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 30.0f;
    private float turnSpeed = 35.0f;
    private float horizontalInput;
    private bool isCarOn = true;
    
    // Update is called once per frame
    void Update()
    {
        // Get User Inputs
        horizontalInput = Input.GetAxis("Horizontal");
        float forwardInput = Input.GetAxis("Vertical");

        if (forwardInput > 0)
        {
            isCarOn = true ;
        } else if(forwardInput < 0) {
            isCarOn = false; 
        }

        if (isCarOn)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        // Rotate the vehicle laterally to steer.
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}