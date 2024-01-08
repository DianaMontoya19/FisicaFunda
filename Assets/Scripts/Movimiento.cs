using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad = 5f;
    public Vector3 gravedad = new Vector3(0f, 9.8f, 0f);
    public Vector3 gravedad2 = new Vector3(0f, -9.8f, 0f);
    bool enter = false;
    bool salir = false;



    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    void Update()
    {
        float movimientoHor = Input.GetAxis("Horizontal");
        float movimientoVer = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoVer, 0f, -movimientoHor);

        rb.AddForce(movimiento * velocidad);
    }

    void OnCollisionEnter(Collision collision)
    {
          


        while (enter == false)
        {           
            if (collision.gameObject.CompareTag("salto"))
            {
                rb.useGravity = false;
                rb.AddForce(gravedad, ForceMode.Acceleration);

                print("entro");

                             
            }
            print("aun no");
            enter = true;
            salir = true;
           
        }
        while (salir == true)
            {

                if (collision.gameObject.CompareTag("salio"))
                {
                    rb.useGravity = true;
                // rb.AddForce(gravedad2, ForceMode.Acceleration);
                print("salio");
            }

            salir = false ;
            enter = false;
            }
          
            
            
        

    
       
            
        


    }


}
