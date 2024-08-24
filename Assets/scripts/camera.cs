using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class camera : MonoBehaviour

{   
    public static camera instance;

    private void Awake() 
    {
        if(instance == null)
        {
            instance = this;
        }
    }


    public Transform alvo;
    private float xMin, xMax, yMin, yMax;
    [SerializeField]
    public Tilemap TileM;
    private Vector3 mintile, maxtile;


    void Start()
    {
        StartMapa();
    }

    public void StartMapa()
    {
        mintile = TileM.CellToWorld(TileM.cellBounds.min);  
        maxtile = TileM.CellToWorld(TileM.cellBounds.max);   

        limites(mintile, maxtile);
    }

     void LateUpdate() 
    {
    transform.position = new Vector3(Mathf.Clamp(alvo.position.x, xMin, xMax), Mathf.Clamp(alvo.position.y, yMin, yMax), -10);
        
    }
    void limites(Vector3 mintile, Vector3 maxtile)
    {
        Camera cam = Camera.main;
        float altura = 2f * cam.orthographicSize;
        float largura = altura * cam.aspect;

        xMin = mintile.x + largura / 2;
        xMax = maxtile.x - largura / 2;
        yMin = mintile.y + altura / 2;
        yMax = maxtile.y - altura / 2;

    }
}

