using Unity.Mathematics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; // meters per sec
    public float turnSpeed; // degrees per sec
    private float horizontalInput;
    private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward 
        transform.Translate(
            Vector3.forward 
            * Time.deltaTime 
            * speed
            * forwardInput
        );

        // Move the vehicle sideways
        transform.Rotate(
            Vector3.up,
            Time.deltaTime
            * turnSpeed
            * horizontalInput
        );
    }
}