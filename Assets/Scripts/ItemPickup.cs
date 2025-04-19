using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public enum ItemType { Heal, PowerUp }
    public ItemType itemType;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (itemType == ItemType.Heal)
            {
                // Thêm máu cho người chơi
                Debug.Log("Player healed!");
            }
            else if (itemType == ItemType.PowerUp)
            {
                // Tăng sức mạnh cho người chơi
                Debug.Log("Player powered up!");
            }
            Destroy(gameObject);
        }
    }
}