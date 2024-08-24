using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.C))
        {
            GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
        }
        
    }
}
