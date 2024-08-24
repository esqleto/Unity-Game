using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linha : MonoBehaviour
{
[SerializeField]
Rigidbody2D projetil;
	
    void Start()
    {
	projetil.velocity = new Vector2(projetil.velocity.x, -15); 
    }

    void Update()
    {
        
    }
}
