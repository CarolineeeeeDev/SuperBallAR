using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

public class NetTest : MonoBehaviourPunCallbacks
{
    public Text textinfo1;
    public Text textinfo2;
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    void Update()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            textinfo2.text = "Master";
        }
        else
        {
            textinfo2.text = "NotMaster";
        }
    }

    public override void OnConnectedToMaster()
    {
        print("Connected to server.");
        
        print(PhotonNetwork.LocalPlayer.NickName);
        PhotonNetwork.JoinOrCreateRoom("TestRoom",new RoomOptions(), TypedLobby.Default);
        textinfo1.text = "Connected";
        
    }
    
    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
    }
}
