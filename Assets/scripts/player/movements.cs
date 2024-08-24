using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movements : MonoBehaviour
{
 public float vel;
 
 public static Rigidbody2D player;

 [SerializeField]
 private Collider2D playercoll;

 static public Vector3 posatual;

 [SerializeField]
 private float dashtam;


 


    void Start()
    {
		Physics2D.IgnoreLayerCollision(0, 6, false);
		player = GetComponent<Rigidbody2D>();
		playercoll = GetComponent<Collider2D>();
		
   
    }

    void Update()
    {
        teclasy();
		teclasx();
		dash();
		posatual = transform.position;
    }

	//inputs de teclas
	
	void teclasy()
	{
	 

	if(Input.GetKey(KeyCode.W))
	{
		player.velocity = new Vector2(player.velocity.x, vel);
		
	}
	
	else if(Input.GetKey(KeyCode.S))
	{
		player.velocity = new Vector2(player.velocity.x, -vel);
		
	}

	else
	{
		player.velocity = new Vector2(player.velocity.x, 0);
		

	}

	}

	void teclasx()
	{

	if(Input.GetKey(KeyCode.D))
	{
		player.velocity = new Vector2(vel, player.velocity.y);
		creator.lado = 7;
		
	}

	else if(Input.GetKey(KeyCode.A))
	{
		player.velocity = new Vector2(-vel, player.velocity.y);
		creator.lado = -7;
		
	}
	
	else
	{
		player.velocity = new Vector2(0,player.velocity.y);

	}
	}

	// sistema de esquiva
	void dash()
	{
		if(Input.GetKeyDown(KeyCode.Space) && player.velocity.x >= 1 && player.velocity.y == 0)
		{
			transform.position = posatual + new Vector3(dashtam, 0, 0);
			StartCoroutine("invencivel");
		}		
		else if(Input.GetKeyDown(KeyCode.Space) && player.velocity.x <= -1 && player.velocity.y == 0)
		{
			transform.position = posatual + new Vector3(-dashtam, 0, 0);
			StartCoroutine("invencivel");
		}
		else if(Input.GetKeyDown(KeyCode.Space) && player.velocity.y >= 1 && player.velocity.x == 0)
		{
			transform.position = posatual + new Vector3(0, dashtam, 0);
			StartCoroutine("invencivel");
		}		
		else if(Input.GetKeyDown(KeyCode.Space) && player.velocity.y <= -1 && player.velocity.x == 0)
		{
			transform.position = posatual + new Vector3(0, -dashtam, 0);
			StartCoroutine("invencivel");
		}
		else if(Input.GetKeyDown(KeyCode.Space) && player.velocity.y >= 1 && player.velocity.x >= 1)
		{
			transform.position = posatual + new Vector3(dashtam, dashtam, 0);
			StartCoroutine("invencivel");
		}
		else if(Input.GetKeyDown(KeyCode.Space) && player.velocity.y <= -1 && player.velocity.x <= -1)
		{
			transform.position = posatual + new Vector3(-dashtam, -dashtam, 0);
			StartCoroutine("invencivel");
		}
		else if(Input.GetKeyDown(KeyCode.Space) && player.velocity.y >= 1 && player.velocity.x <= -1)
		{
			transform.position = posatual + new Vector3(-dashtam, dashtam, 0);
			StartCoroutine("invencivel");
		}
		else if(Input.GetKeyDown(KeyCode.Space) && player.velocity.y <= -1 && player.velocity.x >= 1)
		{
			transform.position = posatual + new Vector3(dashtam, -dashtam, 0);
			StartCoroutine("invencivel");
		}
	}

	IEnumerator invencivel()
	{
		Physics2D.IgnoreLayerCollision(0, 6, true);
		yield return new WaitForSeconds(0.5f);
		Physics2D.IgnoreLayerCollision(0, 6, false);
		

	}
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("linha"))
		{
			StartCoroutine("invencivel");
		}
		
	}
	
	private void OnTriggerStay2D(Collider2D other)
	{
		
		
		if(other.gameObject.CompareTag("limite"))
		{
			dashtam = 0.5f;
		}
		
	}
	
	private void OnTriggerExit2D(Collider2D other)
	{
		
		
		if(other.gameObject.CompareTag("limite"))
		{
			dashtam = 2f;
		}
		
	}
	
	
	
}
