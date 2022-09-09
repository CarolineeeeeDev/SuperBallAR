using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PutBoxShowHide : MonoBehaviourPunCallbacks
{
    public GameObject Box;
    private MultipleObjectPlacement muti=new MultipleObjectPlacement();
    // Start is called before the first frame update
     void Start()
    {
        if(PhotonNetwork.IsMasterClient)
        {
            this.gameObject.SetActive(false);
        }
    }

    public void OnClick_PutBox()
    {
        muti.PutBox(Box);
    }
}
