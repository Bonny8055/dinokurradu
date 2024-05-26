using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Input for mobile controls
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Move the player
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }

    // Button functions
    public void MoveLeft()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }

    public void MoveRight()
    {
        transform.Translate(Vector3.right * -moveSpeed * Time.deltaTime);
    }

    public void MoveUp()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
    }

    public void MoveDown()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
    }
}
