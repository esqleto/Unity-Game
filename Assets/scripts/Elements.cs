using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Elements : MonoBehaviour
{
 public bool Helio;
 public bool Cloro;
 public bool Oxigenio;

 public bool saida;
 public bool saida2;
 public bool saida3;
 
 public GameObject H;
 public GameObject C;
 public GameObject O;

public GameObject Hfollow;
public GameObject Cfollow;
public GameObject Ofollow;

public GameObject luz;

public Text mis1;
public Text mis2;
public Text mis3;




 
	
	void Start()
    {
		
		luz.GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
	
		Helio = false;
		Cloro = false;
		Oxigenio = false;
	
		saida = false;
		saida2 = false;
		saida3 = false;
	
		Physics2D.IgnoreLayerCollision(0, 7, true);   
    }

    void Update()
    {
		if(saida == true && saida2 == true && saida3 == true)
		{
			Physics2D.IgnoreLayerCollision(0, 7, false);

			luz.GetComponent<Renderer>().material.color = new Color(1, 0, 0, 0.7f);
		}
        
    }

	private void OnTriggerEnter2D(Collider2D other)
	{
		
		if(other.gameObject.CompareTag("helio") && Cloro == false && Oxigenio == false)
		{
			Helio = true;
			Destroy(H.gameObject);
			Hfollow = Instantiate(Hfollow, transform.position, Quaternion.identity);
		}
		
		if (other.gameObject.CompareTag("cloro") && Helio == false && Oxigenio == false)
		{
			Cloro = true;
			Destroy(C.gameObject);
			Cfollow = Instantiate(Cfollow, transform.position, Quaternion.identity);
		}
		if(other.gameObject.CompareTag("oxigenio") && Cloro == false && Helio == false)
		{
			Oxigenio = true;
			Destroy(O.gameObject);
			Ofollow = Instantiate(Ofollow, transform.position, Quaternion.identity);
		}
		if(other.gameObject.CompareTag("hidrogenio") && Helio == true)
		{
			saida = true;
			Helio = false;
			Destroy(Hfollow);
			mis1.color = new Color(0, 225, 0);
		}
		if(other.gameObject.CompareTag("carbono") && Oxigenio == true)
		{
			saida2 = true;
			Oxigenio = false;
			Destroy(Ofollow);
			mis2.color = new Color(0, 225, 0);
		}
		if(other.gameObject.CompareTag("sodio") && Cloro == true)
		{
			saida3 = true;
			Cloro = false;
			Destroy(Cfollow);
			mis3.color = new Color(0, 225, 0);
		}
	}



}
