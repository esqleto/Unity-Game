using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creator : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D vilao;

    [SerializeField]
    private float velocidade;

    [SerializeField]
    private Rigidbody2D linha;
	[SerializeField]
    private Rigidbody2D cair;
	
	private Vector3 dir;


    public int contador;

	public int aleatorio;

	public static int lado;

    public float dis;



    void Start()
    {
        vilao = GetComponent<Rigidbody2D>();     
    }
    
    void LateUpdate()
    {
        contador++;
        
        if(contador >= 30)
        {
            contador = 0;

			aleatorio = Random.Range(0, 10);
            
            switch(aleatorio)
            {
                case 0: Instantiate(cair, transform.position, Quaternion.identity); break;
                case 1: Instantiate(cair, transform.position, Quaternion.identity); break;
                case 2: Instantiate(cair, transform.position, Quaternion.identity); break;
                case 3: Instantiate(cair, transform.position, Quaternion.identity); break;
                case 4: Instantiate(cair, transform.position, Quaternion.identity); break;
                case 5: Instantiate(cair, transform.position, Quaternion.identity); break;
                case 6: Instantiate(cair, transform.position, Quaternion.identity); break;
                case 7: Instantiate(cair, transform.position, Quaternion.identity); break;
                case 8: Instantiate(cair, transform.position, Quaternion.identity); break;
                case 9: Instantiate(cair, transform.position, Quaternion.identity); break;

                default: Instantiate(cair, transform.position, Quaternion.identity); break;
            }
        }
    }   
	
	void Update()
	{
		dir = new Vector3(movements.player.transform.position.x , -12 ,transform.position.z);
		vilao.transform.position = Vector3.MoveTowards(dir, transform.position , dis);
	}

}