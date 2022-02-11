using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class Textos{

    [TextArea (2,6)] //las cajas de tecto ocupaan como minimo 2 y como maximo 6 lineas
    public string[] arrayTextos; //arreglo de textos
    
    //Debug.Log("llamada a arrayTextos");

}

