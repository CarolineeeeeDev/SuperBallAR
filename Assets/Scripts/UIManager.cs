using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviourPunCallbacks
{
    public Button NewObjButton;
    public MainSceneManger SceneManger;

    void Start()
    {
        NewObjButton.onClick.AddListener(SceneManger.NewSyncObj);
        
    }

}
