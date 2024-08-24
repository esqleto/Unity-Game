using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creatormove : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D inimigo;
	private Vector3 dir;
	



    void Start()
    {
        inimigo = GetComponent<Rigidbody2D>();
		
    }

    void Update()
    {
		dir = new Vector3(movements.player.transform.position.x, -12 ,transform.position.z);
        inimigo.transform.position = Vector3.MoveTowards(dir, transform.position , 5f);
    }
}

