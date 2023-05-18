using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;
    [SerializeField] Transform playerSpawnPos;
    void awake()
    {
        spawnPlayer();
    }

    void spawnPlayer()
    {
        Instantiate(playerPrefab, playerSpawnPos.position, Quaternion.identity);
    }
}
