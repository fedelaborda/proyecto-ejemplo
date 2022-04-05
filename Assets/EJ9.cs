using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//9. Realizá un programa que resuelva el siguiente problema:  
//Tres personas aportan diferente capital a una sociedad.Se desea saber qué porcentaje del total aportó cada una 
//(indicando nombre y porcentaje) y cuál es el monto del total aportado  por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  mostrar lo pedido 
//en el siguiente formato:  
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. 


public class EJ9 : MonoBehaviour
{
    // Start is called before the first frame update

    public string nom1;
    public string nom2;
    public string nom3;

    public float capital1;
    public float capital2;
    public float capital3;

    float PorcentajeAportado1;
    float PorcentajeAportado2;
    float PorcentajeAportado3;

    float montototal;


    void Start()
    {

        Debug.Log("Nombre: " + nom1 + " Capital Aportado $: " + capital1 + " Porcentaje del capital: % " + PorcentajeAportado1 + " Monto total aportado: $ " + montototal);
        Debug.Log("Nombre: " + nom2 + " Capital Aportado $: " + capital2 + " Porcentaje del capital: % " + PorcentajeAportado2 + " Monto total aportado: $ " + montototal);
        Debug.Log("Nombre: " + nom3 + " Capital Aportado $: " + capital3 + " Porcentaje del capital: % " + PorcentajeAportado3 + " Monto total aportado: $ " + montototal);
        montototal = capital1 + capital2 + capital3;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
