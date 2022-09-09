using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class Destination : MonoBehaviour
{
    public Text wintext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            wintext.text="Player"+other.GetComponent<PhotonView>().Owner+" Wins!";
            wintext.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
