using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguirplayer : MonoBehaviour
{

    [SerializeField]
    private float vel;

    [SerializeField]
    private Rigidbody2D inimigo;



    void Start()
    {
        inimigo = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        inimigo.transform.position = Vector3.MoveTowards(movements.player.transform.position , transform.position , 3f);
    }
}
