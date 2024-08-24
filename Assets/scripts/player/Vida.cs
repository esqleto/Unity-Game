using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{


    [SerializeField]
    private GameObject[] Life;


    public static int vida;

    
    void Start()
    {
        vida = 3;
    }


    void Update()
    {
        ControleVida();

        if (vida > 3)
        {
            vida = 3;
        }

        if (vida <= 0)
        {
            vida = 0;
        }
    }




    void ControleVida()
    {
        switch (vida)
        {
            case 0:
                Life[0].GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
                Life[1].GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
                Life[2].GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
                break;
            case 1:
                Life[0].GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
                Life[1].GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
                Life[2].GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);        
                break;
            case 2:
                Life[0].GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
                Life[1].GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
                Life[2].GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);            
                break;
            case 3:
                Life[0].GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
                Life[1].GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
                Life[2].GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);             
                break;
   
            default:
                Life[0].GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
                Life[1].GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
                Life[2].GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);            
                break;
        }
    }







}
