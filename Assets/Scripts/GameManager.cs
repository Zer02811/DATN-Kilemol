using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int playerHealth = 100;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        playerHealth -= damage;
        if (playerHealth <= 0)
        {
            Debug.Log("Game Over!");
        }
    }
}