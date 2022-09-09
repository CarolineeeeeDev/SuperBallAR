using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class SelePlayerUI : MonoBehaviourPunCallbacks
{
    public GameObject GamePlayer;
    public GameObject obj;
    public Button Style1;
    public Button Style2;
    public Button Style3;
    public Button Confirm;
    public Material Mat1;
    public Material Mat2;
    public Material Mat3;
    private Vector3 playerpos = new Vector3(-1.2f, 0, 0);
    private void Start()
    {
        Style1.onClick.AddListener(SetStyle1);
        Style2.onClick.AddListener(SetStyle2);
        Style3.onClick.AddListener(SetStyle3);
        Confirm.onClick.AddListener(ConfirmDes);
    }
    public void SetStyle1()
    {
        playerpos.z = UnityEngine.Random.Range(-0.4f, 0.4f);
        var temp = PhotonNetwork.Instantiate("BallPlayer1", playerpos, Quaternion.identity);
        PhotonNetwork.Destroy(this.gameObject);
    }

    public void SetStyle2()
    {
        playerpos.z = UnityEngine.Random.Range(-0.4f, 0.4f);
        var temp = PhotonNetwork.Instantiate("BallPlayer2", playerpos, Quaternion.identity);
        PhotonNetwork.Destroy(this.gameObject);
    }
    public void SetStyle3()
    {
        playerpos.z = UnityEngine.Random.Range(-0.4f, 0.4f);
        var temp = PhotonNetwork.Instantiate("BallPlayer3", playerpos, Quaternion.identity);
        PhotonNetwork.Destroy(this.gameObject);
    }
    public void ConfirmDes()
    {
        Destroy(obj);
    }
    //[PunRPC]
    //private void OnSeleRPC()
    //{
    //    GetComponent<Button>().interactable = false;
    //}
}
