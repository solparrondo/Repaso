/*9. Realizá un programa que resuelva el siguiente problema:
Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del
total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
por las tres.
Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
mostrar lo pedido en el siguiente formato:
Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej09 : MonoBehaviour
{

    public string nombre1;
    public string nombre2;
    public string nombre3;

    public float capitalAportado1;
    public float capitalAportado2;
    public float capitalAportado3;

    float porcentaje1;
    float porcentaje2;
    float porcentaje3;

    float total;

    // Start is called before the first frame update
    void Start()
    {
        total = capitalAportado1 + capitalAportado2 + capitalAportado3;

        porcentaje1 = capitalAportado1 / total * 100;
        porcentaje2 = capitalAportado2 / total * 100;
        porcentaje3 = capitalAportado3 / total * 100;

        Debug.Log("Nombre: " + nombre1 + ", Capital aportado: $" + capitalAportado1 + ", Porcentaje del capital: %" + porcentaje1 + ", Monto total aportado: $" + total);
        Debug.Log("Nombre: " + nombre2 + ", Capital aportado: $" + capitalAportado2 + ", Porcentaje del capital: %" + porcentaje2 + ", Monto total aportado: $" + total);
        Debug.Log("Nombre: " + nombre3 + ", Capital aportado: $" + capitalAportado3 + ", Porcentaje del capital: %" + porcentaje3 + ", Monto total aportado: $" + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
