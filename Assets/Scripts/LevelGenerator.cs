using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] platforms; // Các nền tảng ngẫu nhiên
    public int numberOfPlatforms = 10;
    public float levelWidth = 10f;
    public float minY = 1f;
    public float maxY = 3f;

    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platforms[Random.Range(0, platforms.Length)], spawnPosition, Quaternion.identity);
        }
    }
}