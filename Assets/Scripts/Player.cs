using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] Transform playerSpawnPoints;  // Parent of the spawn points
    [SerializeField] GameObject landingAreaPrefab;


    private bool reSpawn = false;
    private Transform[] spawnPoints;
    private bool lastToggle = false;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();

    }


    private void Update()
    {
        if (lastToggle != reSpawn)
        {
            ReSpawn();
            reSpawn = false;
        }
        else
        {
            lastToggle = reSpawn;
        }
    }


    private void ReSpawn()
    {
        int spawnPoint = Random.Range(1, spawnPoints.Length);
        transform.position = spawnPoints[spawnPoint].transform.position;
    }

    void OnFindClearArea()
    {
        Invoke("DropFlare", 3f);
    }

    void DropFlare()
    {
        Instantiate(landingAreaPrefab, transform.position, transform.rotation);
    }
}
