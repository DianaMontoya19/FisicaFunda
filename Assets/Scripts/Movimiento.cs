using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad = 5f;

    void Update()
    {
        float movimientoHor = Input.GetAxis("Horizontal");
        float movimientoVer = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoVer, 0f, -movimientoHor);

        GetComponent<Rigidbody>().velocity = movimiento*velocidad;
    }
}
