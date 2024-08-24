using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creatorUp : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D vilao;


    [SerializeField]
    private Rigidbody2D linha;
	
	private Vector3 dir;


    public int contador;

	public static int lado;

    public float dis;



    void Start()
    {
        vilao = GetComponent<Rigidbody2D>();     
    }
    
    void LateUpdate()
    {
        contador++;
        
        if(contador >= 50)
        {
            contador = 0;

            Instantiate(linha, transform.position, new Quaternion(0,0,180,0));    
        }
    }   
	
	void Update()
	{
		dir = new Vector3(movements.player.transform.position.x , 11.3f ,transform.position.z);
		vilao.transform.position = Vector3.MoveTowards(dir, transform.position , dis);
	}

}