using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCanvas : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DestroyCanva()
    {
        Destroy(canvas);
    }
}