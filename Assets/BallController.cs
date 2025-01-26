using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed;
    [SerializeField] private float jumpForce=5f;
    private bool isGrounded = false;


    public void MoveBall(Vector2 input)
    {
        // Convert 2D input (X, Y) to 3D input (X, Z)
        Vector3 inputXZPlane = new Vector3(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }

    public void Jump() { 
        if (isGrounded)
        {
            sphereRigidbody.AddForce (Vector3.up*jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name== "bottomOfBox")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "bottomOfBox")
        {
            isGrounded = true;
        }


    }
}
