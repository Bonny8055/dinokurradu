using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Move the object
        MoveObject();
    }

    void MoveObject()
    {
        // Get input from arrow keys or WASD
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);

        // Normalize the movement vector to ensure constant speed regardless of direction
        movement = movement.normalized * moveSpeed * Time.deltaTime;

        // Move the object
        transform.Translate(movement);
    }
}
