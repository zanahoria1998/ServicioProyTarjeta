//Código de la tarjeta para aparecer los cuados de dialógo al resionar una opción dentro de la tarjeta.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoInteractable : MonoBehaviour
{
    public Textos textos; //Refereciando al Script Textos

    public void OnMouseDown(){ //Al presionar un objeto que tenga este script

        FindObjectOfType<ControlDialogo>().ActivarCartel(textos);//buscará el objeto que tenga el control de dialógo y posteriormente recurrirá al método de activar cartel
        Debug.Log("Llamada a ObjetoInteractable");
    }
}
