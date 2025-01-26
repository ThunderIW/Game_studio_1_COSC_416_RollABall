using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();
    public UnityEvent OnJump = new UnityEvent();

    void Update()
    {
        Vector2 inputVector = Vector2.zero;

        // Process input for W, A, S, D keys and log the pressed keys
        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up;
            Debug.Log("W key pressed");
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector2.down;
            Debug.Log("S key pressed");
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector2.left;
            Debug.Log("A key pressed");
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector2.right;
            Debug.Log("D key pressed");
        }

        // Invoke the event with the input direction
        if (inputVector != Vector2.zero) // Log only when there is movement
        {
            
            OnMove?.Invoke(inputVector);
        }

        // Process and log input for Space key (jump)
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Space key pressed");
            OnJump?.Invoke();
        }
    }
}
