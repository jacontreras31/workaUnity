using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class calendar_func : MonoBehaviour {

    public Text mes_text, año_text;
    string diasemana;
    int año,diasemanaint, diasemanaint2,Element, diamesint, mes_tipo, d, m, a, c, premax, mesmax;
    public Button boton;
    public Dias[] dia;
    public Image Pendientes_del_dia;
    public Button Cerrar_pendiente;


    // Use this for initialization
    void Start () {
        mesmax = 18 / 4;
        Debug.Log(mesmax);
        m = System.DateTime.Now.Month;
        año = System.DateTime.Now.Year;
        StartCoroutine("calcular_primer_dia", System.DateTime.Now.Year);
        mes_text.text = System.DateTime.Now.ToString("MM");
        año_text.text = System.DateTime.Now.ToString("yyyy");
        año = System.DateTime.Now.Year;
        switch (mes_text.text)
        {
            case "01":
                premax = 31;
                mesmax = 31;
                mes_text.text = "Enero";
                break;
            case "02":
                premax = 31;
                mesmax = 28;
                mes_text.text = "Febrero";
                break;
            case "03":
                premax = 28;
                mesmax = 31;
                mes_text.text = "Marzo";
                break;
            case "04":
                premax = 31;
                mesmax = 30;
                mes_text.text = "Abril";
                break;
            case "05":
                premax = 30;
                mesmax = 31;
                mes_text.text = "Mayo";
                break;
            case "06":
                premax = 31;
                mesmax = 30;
                mes_text.text = "Junio";
                break;
            case "07":
                premax = 30;
                mesmax = 31;
                mes_text.text = "Julio";
                break;
            case "08":
                premax = 31;
                mesmax = 31;
                mes_text.text = "Agosto";
                break;
            case "09":
                premax = 31;
                mesmax = 30;
                mes_text.text = "Septiembre";
                break;
            case "10":
                premax = 30;
                mesmax = 31;
                mes_text.text = "Octubre";
                break;
            case "11":
                premax = 31;
                mesmax = 30;
                mes_text.text = "Noviembre";
                break;
            case "12":
                premax = 30;
                mesmax = 31;
                mes_text.text = "Diciembre";
                break;
        }
        StartCoroutine("llenar_dias");
    }

	
	// Update is called once per frame
	void Update () {
	}

    //Funciones de los botones
    public void Boton_derecha()
    {
        switch (mes_text.text)
        {
            case "Enero":
                premax = 31;
                mesmax = 31;
                mes_text.text = "Febrero";
                m = 1;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Febrero":
                premax = 31;
                mesmax = 28;
                mes_text.text = "Marzo";
                m = 2;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Marzo":
                premax = 28;
                mesmax = 31;
                mes_text.text = "Abril";
                m = 3;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Abril":
                premax = 31;
                mesmax = 30;
                mes_text.text = "Mayo";
                m = 4;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Mayo":
                premax = 30;
                mesmax = 31;
                mes_text.text = "Junio";
                m = 5;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Junio":
                premax = 31;
                mesmax = 30;
                mes_text.text = "Julio";
                m = 6;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Julio":
                premax = 30;
                mesmax = 31;
                mes_text.text = "Agosto";
                m = 7;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Agosto":
                premax = 31;
                mesmax = 31;
                mes_text.text = "Septiembre";
                m = 8;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Septiembre":
                premax = 31;
                mesmax = 30;
                mes_text.text = "Octubre";
                m = 9;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Octubre":
                premax = 30;
                mesmax = 31;
                mes_text.text = "Noviembre";
                m = 10;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Noviembre":
                premax = 31;
                mesmax = 30;
                mes_text.text = "Diciembre";
                m = 11;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Diciembre":
                premax = 30;
                mesmax = 31;
                mes_text.text = "Enero";
                m = 12;
                if (año > System.DateTime.Now.Year)
                {
                    año = año + 1;
                    año_text.text = "" + año;
                }
                else
                {
                    año = año + 1;
                    año_text.text = "" + año;
                }
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
        }
    }
    public void Boton_Izquierda()
    {
        switch (mes_text.text)
        {
            case "Enero":
                mes_text.text = "Diciembre";
                if (año < System.DateTime.Now.Year)
                {
                    año = año - 1;
                    año_text.text = "" + año;
                }
                else
                {
                    año = año - 1;
                    año_text.text = "" + año;
                }
                break;
            case "Febrero":
                mes_text.text = "Enero";
                break;
            case "Marzo":
                mes_text.text = "Febrero";
                break;
            case "Abril":
                mes_text.text = "Marzo";
                break;
            case "Mayo":
                mes_text.text = "Abril";
                break;
            case "Junio":
                mes_text.text = "Mayo";
                break;
            case "Julio":
                mes_text.text = "Junio";
                break;
            case "Agosto":
                mes_text.text = "Julio";
                break;
            case "Septiembre":
                mes_text.text = "Agosto";
                break;
            case "Octubre":
                mes_text.text = "Septiembre";
                break;
            case "Noviembre":
                mes_text.text = "Octubre";
                break;
            case "Diciembre":
                mes_text.text = "Noviembre";
                break;
        }
    }

    //abrir-cerrar popup "pendientes"
    public void Boton_dia_pendientes ()
    {
        Pendientes_del_dia.gameObject.SetActive(true);
        Cerrar_pendiente.gameObject.SetActive(true);
    }
    public void Cierra_pendientes()
    {
        Pendientes_del_dia.gameObject.SetActive(false);
        Cerrar_pendiente.gameObject.SetActive(false);
    }

    //Llenar_botones
    //este void llenar dia utilizara las variables que llenara primeramente el void calculo
    void llenar_dias ()
    {

        switch (diasemanaint)
        {
            case 0:
                Element = 0;
                diasemanaint2 = diasemanaint - 1;
                diamesint = premax - diasemanaint2;
                while (Element < diasemanaint)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                diamesint = 1;
                mesmax = mesmax + 1;
                while (Element < mesmax)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                break;
            case 1:
                Element = 0;
                diasemanaint2 = diasemanaint - 1;
                diamesint = premax - diasemanaint2;
                while (Element < diasemanaint)
                    {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                    }
                    diamesint = 1;
                mesmax = mesmax + 1;
                while (Element < mesmax)
                    {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                    }
                break;
            case 2:
                Element = 0;
                diasemanaint2 = diasemanaint - 1;
                diamesint = premax - diasemanaint2;
                while (Element < diasemanaint)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                diamesint = 1;
                mesmax = mesmax + 1;
                while (Element < mesmax)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                break;
            case 3:
                Element = 0;
                diasemanaint2 = diasemanaint - 1;
                diamesint = premax - diasemanaint2;
                while (Element < diasemanaint)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                diamesint = 1;
                mesmax = mesmax + 1;
                while (Element < mesmax)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                break;
            case 4:
                Element = 0;
                diasemanaint2 = diasemanaint - 1;
                diamesint = premax - diasemanaint2;
                while (Element < diasemanaint)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                diamesint = 1;
                mesmax = mesmax + 1;
                while (Element < mesmax)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                break;
            case 5:
                Element = 0;
                diasemanaint2 = diasemanaint - 1;
                diamesint = premax - diasemanaint2;
                while (Element < diasemanaint)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                diamesint = 1;
                mesmax = mesmax + 1;
                while (Element < mesmax)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                break;
            case 6:
                Element = 0;
                diasemanaint2 = diasemanaint - 1;
                diamesint = premax - diasemanaint2;
                while (Element < diasemanaint)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    dia[Element].día.image.color = Color.grey;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                diamesint = 1;
                mesmax = mesmax + 1;
                while (Element < mesmax)
                {
                    dia[Element].día.GetComponentInChildren<Text>().text = "" + diamesint;
                    Element = Element + 1;
                    diamesint = diamesint + 1;
                }
                break;
        }
    }
    //necesitamos 3 variables 
    //dia, año y mes
    //Dia = 1 (siempre), año 2017, diciembre
    // A = 2017- 2000
    //C = 
    
    void calcular_primer_dia(int AA )
    {
        switch (m)
        {
            case 1:
                m = 11;
                break;
            case 2:
                m = 12;
                break;
            case 3:
                m = 1;
                break;
            case 4:
                m = 2;
                break;
            case 5:
                m = 3;
                break;
            case 6:
                m = 4;
                break;
            case 7:
                m = 5;
                break;
            case 8:
                m = 6;
                break;
            case 9:
                m = 7;
                break;
            case 10:
                m = 8;
                break;
            case 11:
                m = 9;
                break;
            case 12:
                m = 10;
                break;
        }
d = 1;
        a = AA - 2000;
        c = 20;
        diasemanaint = (d + (((13*m) - 1) / 5) + a +(a / 4) + (c / 4) - 2*c) % 7;
        Debug.Log("diasemanaint" + diasemanaint);
        Debug.Log("a" + a);
        Debug.Log("D" + d);
        Debug.Log("M" + m);
        Debug.Log("C" + c);
    }
       
}

[System.Serializable]
public class Dias
{
    public Button día;
}
