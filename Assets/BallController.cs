using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody sphereRigidbody;
    void Start()
    {
        Debug.Log("Calling the Start Method");
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 inputVector = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log(Vector2.up);
            inputVector += Vector2.up;
        }


        if (Input.GetKey(KeyCode.A)) {
            Debug.Log(Vector2.left);
            inputVector += Vector2.left;


        }

        if (Input.GetKey(KeyCode.S)) {
            inputVector += Vector2.down;
            Debug.Log(Vector2.down);
        }

        if (Input.GetKey(KeyCode.D)) {
            inputVector += Vector2.right;
            Debug.Log(Vector2.right);
        }
        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        Debug.Log("Resultant Vector:" + inputVector);
        Debug.Log("Resultant 3D Vector" + inputXZPlane);
        sphereRigidbody.AddForce(inputXZPlane);
    }
}
