using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour
{
    private Vector3 playerpos = new Vector3(-1.2f, 0, 0);
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
            playerpos.z = UnityEngine.Random.Range(-0.4f, 0.4f);
            other.transform.localPosition = playerpos;
        }
    }
}
