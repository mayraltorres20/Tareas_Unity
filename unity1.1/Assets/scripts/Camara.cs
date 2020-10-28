using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    //public int puntaje = 350;
    //public int tiempo = 40;
    public float gravedad = 9.81f; 

    // Start is called before the first frame update
    void Start()
    {
        // float ptsSeg = (float) puntaje / tiempo; //cast <-conversion de datos
        // Debug.Log("Puntos por Segundo");
        // Debug.Log(ptsSeg);
        Debug.Log(gravedad);
    }

   
}
