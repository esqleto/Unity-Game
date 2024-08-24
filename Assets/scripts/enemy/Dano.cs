using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dano : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        
    }
	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("dano"))
		{
			Destroy(gameObject);
			Vida.vida -= 1;
		}
	}

}

