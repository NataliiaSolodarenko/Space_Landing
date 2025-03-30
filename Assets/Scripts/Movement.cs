using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] InputAction thrust;
    [SerializeField] InputAction rotation;
    [SerializeField] float thrustStrength = 800f;
    [SerializeField] float rotationStrength = 150f;

    Rigidbody rb;

    void OnEnable()
    {
        thrust.Enable();
        rotation.Enable();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        ProcessThrust();
        ProcessRotation();
    }

    private void ProcessThrust()
    {
        if (thrust.IsPressed())
        {
            rb.AddRelativeForce(Vector3.up * thrustStrength * Time.fixedDeltaTime);
        }
    }

    private void ProcessRotation()
    {
        float rotationInput = rotation.ReadValue<float>();
        if (rotationInput < 0)//right
        {
            transform.Rotate(Vector3.forward * rotationStrength * Time.fixedDeltaTime);
        }
        else if (rotationInput > 0)//left
        {
            transform.Rotate(Vector3.back * rotationStrength * Time.fixedDeltaTime);
        }
    }
}
