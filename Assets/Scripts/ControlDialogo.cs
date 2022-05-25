using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlDialogo : MonoBehaviour
{

    public GameObject[] trofeos;
    private int puntos; //contador
    private Animator anim;
    private Queue <string> colaDialogos;
    Textos texto;
    [SerializeField] TextMeshProUGUI textoPantalla;

    public void ActivarCartel(Textos textoObjeto)//TextoObjeto es el texto que se le pasa en el script (ObjetoInteractable)
    {
            anim.SetBool("Cartel", true);
            texto = textoObjeto;
            Debug.Log("Llamada a ActivarCartel");
    }

    public void ActivaTexto()
    {

        colaDialogos.Clear();
        foreach (string textoGuardar in texto.arrayTextos) //recorre el texto dentro del array
        {

            colaDialogos.Enqueue(textoGuardar); //cada palabra del array que se guarda en la variable textoGuardar, la agrega a la cola

            if (textoGuardar == "Respuesta Correcta"){
                Trofeos();
                Debug.Log("if de texto wardar jala");
            } 
            else if (textoGuardar == "Respuesta Incorrecta"){
                Debug.Log("Respuesta incorecta, función");
            }
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
        //puntos=trofeos.Length;
        puntos=0;
        anim = GetComponent<Animator>();
       
        colaDialogos = new Queue<string>();

         /*foreach(GameObject x in trofeos){
            Destroy(x);
        }*/
    }


    //Update is called once per frame
    void RevisionPuntaje(){


        if(puntos == 0){ //puntaje = 0
            //Instantiate(prefab, new Vector3(-233, -189, 3));
            //Instantiate(trofeos[0].gameObject);
            GameObject trofeo = Instantiate(trofeos[0].gameObject, new Vector3(-233, -117, 3), transform.rotation) as GameObject;
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);
            //trofeo.transform.position = new Vector3(-233, -189, 3);
            
        }

        else if(puntos == 1){ // puntaje = 1
            //Instantiate(trofeos[1].gameObject);
            GameObject trofeo = Instantiate(trofeos[0].gameObject, new Vector3(-177, -117, 3), transform.rotation) as GameObject;
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);

        }

        else if(puntos == 2){ //Puntaje = 2
            //Instantiate(trofeos[2].gameObject);
            GameObject trofeo = Instantiate(trofeos[0].gameObject, new Vector3(-120, -117, 3), transform.rotation) as GameObject;
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);

        }
    }

    public void Trofeos(){
        Debug.Log("Esto es puntos" + puntos);
        RevisionPuntaje();
        puntos++;
    }
}
