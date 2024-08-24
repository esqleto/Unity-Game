using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linhaquevolta : MonoBehaviour
{

[SerializeField]
Rigidbody2D projetil;



    void Start()
    {
       projetil.velocity = new Vector2(projetil.velocity.x, 12);
    }

    void Update()
    {

    }
	void OnTriggerEnter2D(Collider2D other)
	{	
		if(other.gameObject.CompareTag("voltar"))
		{
        projetil.velocity = new Vector2(projetil.velocity.x, -6);
        projetil.transform.rotation = new Quaternion(0, 0, 180, 0);
		}
	}
}
