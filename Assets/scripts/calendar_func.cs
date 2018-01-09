﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class calendar_func : MonoBehaviour
{

    public Text mes_text, año_text, holo_text;
    string diasemana;
    int año, diasemanaint, diasemanaint2, Element, diamesint, mes_tipo, d, m, a, c, premax, mesmax, 
        cuartaparte, bisiesto, bisiesto2;
    public Button boton_holo;
    public Dias[] dia;
    public Image Pendientes_del_dia;
    public Button Cerrar_pendiente;


    // Use this for initialization
    void Start()
    {
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
    void Update()
    {
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
                m = 2;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Febrero":
                premax = 31;
                mesmax = 28;
                mes_text.text = "Marzo";
                m = 3;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Marzo":
                premax = 28;
                mesmax = 31;
                mes_text.text = "Abril";
                m = 4;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Abril":
                premax = 31;
                mesmax = 30;
                mes_text.text = "Mayo";
                m = 5;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Mayo":
                premax = 30;
                mesmax = 31;
                mes_text.text = "Junio";
                m = 6;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Junio":
                premax = 31;
                mesmax = 30;
                mes_text.text = "Julio";
                m = 7;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Julio":
                premax = 30;
                mesmax = 31;
                mes_text.text = "Agosto";
                m = 8;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Agosto":
                premax = 31;
                mesmax = 31;
                mes_text.text = "Septiembre";
                m = 9;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Septiembre":
                premax = 31;
                mesmax = 30;
                mes_text.text = "Octubre";
                m = 10;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Octubre":
                premax = 30;
                mesmax = 31;
                mes_text.text = "Noviembre";
                m = 11;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Noviembre":
                premax = 31;
                mesmax = 30;
                mes_text.text = "Diciembre";
                m = 12;
                StartCoroutine("calcular_primer_dia", año);
                StartCoroutine("llenar_dias");
                break;
            case "Diciembre":
                premax = 30;
                mesmax = 31;
                mes_text.text = "Enero";
                m = 1;
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
    public void Boton_dia_pendientes()
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
    void llenar_dias()
    {
        switch (diasemanaint)
        {
            case 0:
                diasemanaint = 6;
                break;
            case 1:
                diasemanaint = 0;
                break;
            case 2:
                diasemanaint = 1;
                break;
            case 3:
                diasemanaint = 2;
                break;
            case 4:
                diasemanaint = 3;
                break;
            case 5:
                diasemanaint= 4;
                break;
            case 6:
                diasemanaint = 5;
                break;  
        }

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
                mesmax = mesmax + 2;
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
                mesmax = mesmax + 2;
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
                mesmax = mesmax + 2;
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
                mesmax = mesmax + 2;
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
                mesmax = mesmax + 2;
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
                mesmax = mesmax + 2;
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
                mesmax = mesmax + 2;
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
    //Dia = 1 (siempre)
    // A = El año - 2000
    //C = 6 (por ahora que sirva del 2000 pa lante)
    //Este void y los cases de los botones llenan las variables que utiliza la funcion que llena los dias,
    //Este void solo calcula que dia de la semana cae el primer dia de cada mes de cada año
    void calcular_primer_dia(int AA)
    {
        switch (m)
        {
            case 1:
                m = 1;

                bisiesto = AA % 400;
                if(bisiesto == 0)
                {
                    m = 0;
                }
                else
                { bisiesto = AA % 4;
                  bisiesto2 = AA % 100;
                    if(bisiesto == 0 && bisiesto2 != 0)
                    {
                        m = 0;
                    }
                }   
                break;
            case 2:
                m = 4;

                bisiesto = AA % 400;
                if (bisiesto == 0)
                {
                    m = 3;
                }
                else
                {
                    bisiesto = AA % 4;
                    bisiesto2 = AA % 100;
                    if (bisiesto == 0 && bisiesto2 != 0)
                    {
                        m = 3;
                    }
                }
                break;
            case 3:
                m = 4;
                break;
            case 4:
                m = 0;
                break;
            case 5:
                m = 2;
                break;
            case 6:
                m = 5;
                break;
            case 7:
                m = 0;
                break;
            case 8:
                m = 3;
                break;
            case 9:
                m = 6;
                break;
            case 10:
                m = 1;
                break;
            case 11:
                m = 4;
                break;
            case 12:
                m = 6;
                break;
        }
        d = 1;
        c = 6;
        a = AA - 2000;
        cuartaparte = a / 4;
        diasemanaint = (c + a + cuartaparte +  d + m) % 7;
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
