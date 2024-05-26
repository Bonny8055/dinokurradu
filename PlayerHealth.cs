using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public Slider healthSlider; // Reference to the Slider component
 public GameObject gameOverPanel;
    public Text healthText;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthText();
    }

    void Update()
    {
         UpdateHealthText();
        // For simplicity, let's assume obstacles have the tag "Obstacle."
    }

    // void OnTriggerEnter(Collider other)
    // {
    //     if (other.CompareTag("damagor"))
    //     {
    //         Debug.Log("Player collided with damagor!");
    //         TakeDamage(10);
    //     }
    // }

    //  public void OnCollisionEnter2D(Collision2D collision)
    // {
      
    //   if (collision.gameObject.tag == "Obstacle")
    //   { 
    //       Debug.Log("Player collided with damagor!");
    //         TakeDamage(10);
    //   }
      
    // }

     private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.CompareTag("Obstacle"))
        {
       Debug.Log("damage");
         TakeDamage(20);
        }
    }

    public void TakeDamage(int damage)
    {
        if (currentHealth <= 0)
        {
            
            return; // Don't take damage if already dead
        }

  
        currentHealth -= damage;
      
         Debug.Log("health" +currentHealth);
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("Player is dead!");
            GameOver();
        }

        UpdateHealthText();

          UpdateHealthUI();
    }

    void UpdateHealthText()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + currentHealth.ToString();
        }
    }

void UpdateHealthUI()
    {
        if (healthSlider != null)
        {
            // Update the slider value based on the current health
            healthSlider.value = currentHealth;

            // You can also set the slider's max value to match the max health
            healthSlider.maxValue = maxHealth;
        }
    }
    void GameOver()
    {
        Debug.Log("Game Over!");
        // You can add additional game over logic here, such as displaying a game over screen.
        // For simplicity, let's restart the level after a delay.

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true); //to open new panel
              Time.timeScale = 0;
        }

        // Invoke("RestartLevel", 2f);
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
