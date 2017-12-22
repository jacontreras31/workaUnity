using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu_script : MonoBehaviour {

    Vector2 mousepos1, mousepos2, imagenpos, botonpos;
    public Image imagen;
    public bool triggermouse, triggermouse2 , barrafuera;
    public Button sidebutton, shade;


	// Use this for initialization
	void Start () {
    
	}
	
	// Update is called once per frame
	void Update () {
        //Aquí saca el sidebar
        if (barrafuera == false)
        { 
         if (Input.GetMouseButtonDown(0))
         {
            mousepos1 = Input.mousePosition;
            Debug.Log(mousepos1.x);
            if (mousepos1.x < 130)
            {
                Debug.Log("1");
                triggermouse = true;
            }
         }
        }
        if (triggermouse == true) {
            if (Input.GetMouseButtonUp(0))
            {
                mousepos2 = Input.mousePosition;
                Debug.Log(mousepos2.x);
                if (mousepos2.x > 130)
                {
                    Debug.Log("sliding");
                    imagenpos = imagen.transform.position;
                    imagenpos.x += 4.9f;
                    imagen.transform.position = imagenpos;
                    shade.gameObject.SetActive(true);
                    barrafuera = true;
                    triggermouse = false;

                }
                else
                {
                    triggermouse = false;
                }
            }
        }
        // Aquí mete el sidebar
        if (barrafuera == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mousepos1 = Input.mousePosition;
                Debug.Log(mousepos1.x);
                if (mousepos1.x >160)
                {
                    Debug.Log("2");
                    triggermouse2 = true;
                }
            }
        }
        if (triggermouse2 == true)
        {
            if (Input.GetMouseButtonUp(0))
            {
                mousepos2 = Input.mousePosition;
                Debug.Log(mousepos2.x);
                if (mousepos2.x < 130)
                {
                    Debug.Log("sliding");
                    imagenpos = imagen.transform.position;
                    imagenpos.x -= 4.9f;
                    imagen.transform.position = imagenpos;
                    shade.gameObject.SetActive(false);
                    barrafuera = false;
                    triggermouse2 = false;

                }
                else
                {
                    triggermouse2 = false;
                }
            }
        }
    }

    public void botonsito ()
    {

        imagenpos = imagen.transform.position;
        imagenpos.x += 4.9f;
        imagen.transform.position = imagenpos;
        shade.gameObject.SetActive(true);
        barrafuera = true;


    }
    public void shadef()
    {

        imagenpos = imagen.transform.position;
        imagenpos.x -= 4.9f;
        imagen.transform.position = imagenpos;
        shade.gameObject.SetActive(false);
        barrafuera = false;
    }
}
