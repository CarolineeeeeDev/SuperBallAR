using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;


public class MainSceneManger : MonoSingle<MainSceneManger>
{
    public Button NewObjButton;
    public void NewSyncObj()
    {
        Destroy(NewObjButton.gameObject);
        var temp=  PhotonNetwork.Instantiate("BallPlayer1", Vector3.zero, Quaternion.identity);
    }

    


}
