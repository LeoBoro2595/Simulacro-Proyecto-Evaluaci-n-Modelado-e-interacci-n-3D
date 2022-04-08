using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    public float dineroDisponible;
    public float precio1;
    public float precio2;
    public float precio3;
    float dineroGastado;
    float dineroSobrante;
    float dineroFaltante;
    // Start is called before the first frame update
    void Start()
    {
        dineroGastado = precio1 + precio2 + precio3;
        if (dineroDisponible > dineroGastado)
        {
            Debug.Log("El dinero disponible es mayor al costo de los tres productos.");
            dineroSobrante = dineroDisponible - dineroGastado;
            Debug.Log("Sobran $" + dineroSobrante);
        }
        else if (dineroDisponible < dineroGastado)
        {
            Debug.Log("El dinero disponible es menor al costo de los tres productos.");
            dineroFaltante = dineroGastado - dineroDisponible;
            Debug.Log("Faltan $" + dineroFaltante);

        }


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
