using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Enemy : MonoBehaviour
{
    PlayerController[] players;
    PlayerController nearestPlayers;
    public float speed;

    private void Start()
    {
        players = FindObjectsOfType<PlayerController>();
    }

    private void Update()
    {
        float distanceOne = Vector2.Distance(transform.position, players[0].transform.position);
        float distanceTwo = Vector2.Distance(transform.position, players[1].transform.position);

        if (distanceOne < distanceTwo)
        {
            nearestPlayers  = players[0];
        }
        else
        {
            nearestPlayers = players[1];
        }
        //khac
        if (nearestPlayers != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, nearestPlayers.transform.position, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.tag == "GoldenRay")
        {
            PhotonNetwork.Destroy(gameObject);
        }
    }
}
