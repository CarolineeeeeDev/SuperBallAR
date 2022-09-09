using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlaceBoxShowHide : MonoBehaviourPunCallbacks
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(obj!=null)
        {
            if (PhotonNetwork.IsMasterClient)
            {
                obj.SetActive(true);

            }
        }
        
    }
}
