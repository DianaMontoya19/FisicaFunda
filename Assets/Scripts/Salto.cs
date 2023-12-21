using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    public float fuerzaSalto = 10f;
    private Rigidbody rb;
    public Vector3 gravedad=new Vector3(0f,-9.8f,0f);
    void Start()
    {
         rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }
    void Update()
    {
        rb.AddForce(gravedad, ForceMode.Acceleration);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            rb.AddForce(Vector3.up*fuerzaSalto, ForceMode.Impulse);
        }

    }
}
