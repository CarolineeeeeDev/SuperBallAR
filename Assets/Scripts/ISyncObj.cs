using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEditor;
using UnityEngine;

public class ISyncObj : MonoBehaviourPunCallbacks
{
    //public float Speed = 1;
    private void Start()
    {
       
        transform.SetParent(MainSceneManger.Instance.transform);
        transform.localPosition=Vector3.zero;
    }

    private void Update()
    {
        
        if (!photonView.IsMine) return;

       
        
        //transform.Translate(new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"))*Speed*Time.deltaTime);
        
    }

    //private void OnCollisionEnter(Collision other)
    //{
    //    var view = other.collider.GetComponent<PhotonView>();
    //    if (view != null)
    //    {
    //        if (!view.IsMine)
    //        {
    //            view.RequestOwnership();
    //        }
    //    }
    //}
}
