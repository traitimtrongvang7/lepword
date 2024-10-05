using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class Health : MonoBehaviour
{
    public int health = 10;
    public Text healthDisplay;

    PhotonView view;
    private void Start()
    {
        view = GetComponent<PhotonView>();
    }
    //BINH THUONG
    public void TakeDamage()
    {
        view.RPC("TakeDamageRPC", RpcTarget.All);
    }
    //dong bo hoa
    [PunRPC]
    void TakeDamageRPC()
    {
        health--;
        healthDisplay.text = health.ToString();
    }
}
