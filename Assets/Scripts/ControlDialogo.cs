using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlDialogo : MonoBehaviour
{

    private Animator anim;
    private Queue <string> colaDialogos;
    Textos texto;
    //public bool CartelPrueba;
    [SerializeField] TextMeshProUGUI textoPantalla;

    public void ActivarCartel(Textos textoObjeto)//TextoObjeto es el texto que se le pasa en el script (ObjetoInteractable)
    {
            //CartelPrueba=true;
            anim.SetBool("Cartel", true);
            texto = textoObjeto;
            Debug.Log("Llamada a ActivarCartel");
    }

    public void ActivaTexto()
    {

        colaDialogos.Clear();
        foreach (string textoGuardar in texto.arrayTextos)
        {

            colaDialogos.Enqueue(textoGuardar);
            Debug.Log("Llamada a ActivaTexto");
        }

        SiguienteFrase();
    }

    public void SiguienteFrase()
    {
        if (colaDialogos.Count == 0)
        {
            CierraCartel();
            return;
        }

        string fraseActual = colaDialogos.Dequeue();
        textoPantalla.text = fraseActual;
        Debug.Log("Llamada a SiguienteFrase");
    }

    public void CierraCartel()
    {
        //CartelPrueba=false;
        anim.SetBool("Cartel", false);
        Debug.Log("Llamada a CierraCartel");
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
       
        colaDialogos = new Queue<string>();
    }

    //Update is called once per frame
    /*void Update(){

        if(Input.GetButtonDown("Opcion1")){
            ActivarCartel();
        }
    }*/
}
