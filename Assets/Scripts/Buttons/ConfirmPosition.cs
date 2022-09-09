using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ConfirmPosition : MonoBehaviourPunCallbacks
{
    public GameObject sod;
    // Start is called before the first frame update
    void Start()
    {
        if (!PhotonNetwork.IsMasterClient)
        {
            this.gameObject.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick_Confirm()
    {
        Destroy(sod.GetComponent<SpawningObjectDetails>());
        foreach (GameObject obj in Object.FindObjectsOfType(typeof(GameObject)))
        {
            if (obj.name== "PlaceBoxCanvas")
            {
                Destroy(obj);
            }
            if (obj.name == "GameUIActive")
            {
                obj.GetComponent<SetGameUIActive>().SetGameUIAct();
            }
        }
        Destroy(this.gameObject);
    }
}
