using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject player;
    //pham vi di chuyen hop le
    public float minX, minY, maxX, maxY;

    private void Start()
    {
        Vector2 randomPosition = new Vector2 (Random.Range(minX, maxX), Random.Range(minY, maxY));
        PhotonNetwork.Instantiate(player.name, randomPosition, Quaternion.identity);
    }
}
