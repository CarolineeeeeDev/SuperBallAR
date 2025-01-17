﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class MonoSingle<T>:MonoBehaviour where T:MonoSingle<T>
{
 
    private static T _instance;
 
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<T>();
                if (_instance == null)
                {
                    GameObject managerGo = new GameObject(typeof(T).Name);
                    _instance = managerGo.AddComponent<T>();
                }
            }
           
            return _instance;
        }
    }
 
}
