using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGameUIActive : MonoBehaviour
{
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetGameUIAct()
    {
        go.SetActive(true);
    }
}
