using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
 [SerializeField]
 private Rigidbody2D inimigo;
 [SerializeField]
 private Rigidbody2D linha;

 private Vector2 positioninimigo;
 private Vector2 positionprox;
 public bool vai;


   
   
   void Start()
    {
       inimigo = GetComponent<Rigidbody2D>();
	   	
		
		Invoke("contadois", 3.0f);
		

	   
    }

    void LateUpdate()
    {
		Invoke("conta", 0.5f);
		if(vai == true)
		{
			inimigo.transform.position = positionprox + new Vector2(1,0);
			Instantiate(linha, inimigo.position, Quaternion.identity);
		}
		else if(vai == false)
		{
			inimigo.transform.position = inimigo.position;
		}
		positionprox = movements.posatual;
	
        
    }
	
	void conta()
	{
	 vai = false;
	}
	void contadois()
	{
	Invoke("contadois", 3.0f);
	 vai = true;
	}
}
