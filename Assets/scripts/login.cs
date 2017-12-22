using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class login : MonoBehaviour {
    int pregistradas;
    public Canvas canvasinicio, canvasregist;

	// Use this for initialization
	void Start () {
        pregistradas = 4;
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public void iniciarSesion ()
    {
        for (int i = 0; i < pregistradas; i++)
        {
            Debug.Log("hola" + i);
        }
    }

    public void registrarse()
    {
        canvasinicio.gameObject.SetActive(false);
        canvasregist.gameObject.SetActive(true);
    }
}
