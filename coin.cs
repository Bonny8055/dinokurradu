using UnityEngine;

public class coin : MonoBehaviour
{
    [SerializeField] private int Value;
    private bool hasTriggered;
    private CoinManager coinManager;
    private void Start()
    {
        coinManager = CoinManager.instance;
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")&& !hasTriggered)
        {
            hasTriggered=true;
            coinManager.ChangeCoins(Value);
            Destroy(gameObject);
        }
    }
}
   