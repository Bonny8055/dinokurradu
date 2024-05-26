using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    GameController gameController;
    public Transform respawnPoint;
    SpriteRenderer spriteRenderer;
    
    public Sprite passive, active;

    private void Awake()
    {
        FindGameController();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("chk");
            spriteRenderer.sprite = active;

            if (gameController != null)
            {
                gameController.Updatecheckpoint(respawnPoint.position);
            }
            else
            {
                Debug.LogWarning("GameController is null in checkpoint script");
            }
        }
    }

    private void FindGameController()
    {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("Player");

        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        else
        {
            Debug.LogWarning("GameController GameObject not found. Make sure it has the 'GameController' tag.");
        }
    }
}
