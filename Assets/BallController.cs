using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed;

    public void MoveBall(Vector2 input)
    {
        // Convert 2D input (X, Y) to 3D input (X, Z)
        Vector3 inputXZPlane = new Vector3(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }
}
