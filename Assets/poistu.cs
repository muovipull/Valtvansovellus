using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class poistu : MonoBehaviour
{
    public lluo muuttuja;
    public GameObject canvas;
    public GameObject canvas1;
    public InputField nimi1;
    public Transform ruudukkoja;
    public InputField numero1;
    public InputField lisatieto1;
    public InputField maara1;
    public InputField hinta1;

    public struct ValtenData
    {
        public string Nimi;
    }
    
        /*
        SetInt kokonaisluku
        SetFloat desimaaliku
        SetString sanoja

        */
    public void NewPhotos()
    {
        canvas.SetActive(false); 
        canvas1.SetActive(true);
        lluo uusikuva = Instantiate(muuttuja, ruudukkoja);
        uusikuva.Valmistele(nimi1.text, int.Parse(numero1.text), lisatieto1.text, int.Parse(maara1.text), int.Parse(hinta1.text));
        nimi1.text = "";
        numero1.text = "";
        lisatieto1.text = "";
        maara1.text =  "";
        hinta1.text = "";
    }


}
