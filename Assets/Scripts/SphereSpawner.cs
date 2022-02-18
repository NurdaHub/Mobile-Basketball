using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject spherePrefab;

    private List<GameObject> spheresList = new List<GameObject>();
    private float horizontal = 3;
    private int minCount = 25;
    private int maxCount = 35;

    public void Spawn()
    {
        var spheresCount = Random.Range(minCount, maxCount);

        for (int i = 0; i < spheresCount; i++)
            CreateSphere();
    }

    private void CreateSphere()
    {
        var randomX = Random.Range(-horizontal, horizontal);
        var randomZ = Random.Range(-horizontal, horizontal);
        var randomY = Random.Range(11.5f, 13.5f);
        Vector3 randomPos = new Vector3(randomX, randomY, randomZ);

        GameObject sphere = Instantiate(spherePrefab, randomPos, Quaternion.identity, transform);
        
        spheresList.Add(sphere);
    }

    public void CleanSpheresList()
    {
        foreach (var sphere in spheresList)
        {
            Destroy(sphere);
        }
        
        spheresList.Clear();
    }
}
