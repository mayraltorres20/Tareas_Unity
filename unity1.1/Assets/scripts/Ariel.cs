using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ariel : MonoBehaviour
{
  /*void OnCollisionEnter2D ( colisión Collision2D )
    {
        if (collision.gameObject.tag == "Ariel")
        {
            Debug.Log("wihh");
        }
    }*/
  
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody2D MovDer = GetComponent<Rigidbody2D>();
        //MovDer.AddForce(new Vector2(-1,0), ForceMode2D.Impulse);
        const float ImpulsoMinimo = 3f;
        const float ImpulsoMaximo = 5f;

        float angulo = Random.Range(0, 2 * Mathf.PI);

        Vector2 direccion = new Vector2(Mathf.Cos(angulo), Mathf.Sin(angulo));
        float magnitud = Random.Range(ImpulsoMinimo, ImpulsoMaximo);
        Rigidbody2D MovDer = GetComponent<Rigidbody2D>();
        MovDer.AddForce(direccion*magnitud, ForceMode2D.Impulse);

        Debug.Log(magnitud);
        Debug.Log(direccion);

        
    }


    // Update is called once per frame
    void Update()
    {
       
    }

    void OnCollisionEnter2D ( Collision2D collision )
    {

         Debug.Log("OnCollisionEnter2D " + collision.gameObject.tag);
        if (collision.gameObject.tag == "Bola")
        {
            Debug.Log("wihhhhhhh");
        }
    }
}
