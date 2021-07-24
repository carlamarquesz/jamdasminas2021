using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioplataforma : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
