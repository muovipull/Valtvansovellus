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
    public List<lluo> tavara_lista = new List<lluo>();
    public static poistu Instance;

    private void Awake()
    {
        Instance = this;



    }    

    private void Start()
    {
        LataaTallennus();
    }

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
        uusikuva.Valmistele(nimi1.text, int.Parse(numero1.text), lisatieto1.text, int.Parse(maara1.text), float.Parse(hinta1.text));
        tavara_lista.Add(uusikuva);
        tallenna();
        nimi1.text = "";
        numero1.text = "";
        lisatieto1.text = "";
        maara1.text =  "";
        hinta1.text = "";
    }

    public void poistulisa()
    {
        canvas.SetActive(false);

        canvas1.SetActive(true);
    }
    
    public void poista_tuote(lluo tavara)
    {
     tavara_lista.Remove(tavara);
     tallenna(); 



    }

    private void LataaTallennus()
    {
        string tallennusTeksti = PlayerPrefs.GetString("Tallennus", "");

        var tavarat = tallennusTeksti.Split('\n');
        foreach(var tavara in tavarat)
        {
            if (string.IsNullOrEmpty(tavara))
            {
                continue;
            }

            var arvot = tavara.Split(';');

            lluo uusikuva = Instantiate(muuttuja, ruudukkoja);
            uusikuva.Valmistele(arvot[0], int.Parse(arvot[1]), arvot[2], int.Parse(arvot[3]), float.Parse(arvot[4]));
            tavara_lista.Add(uusikuva);
        }
    }

    public void tallenna()
    {
        string tallenusTeksti = "";
        foreach(var tuote in tavara_lista)
        {
            tallenusTeksti += $"{tuote.nimi1.text};{tuote.numero1.text};{tuote.lisatieto1.text};{tuote.maara1.text};{tuote.hinta1.text}\n";
        }

        PlayerPrefs.SetString("Tallennus", tallenusTeksti);

    }


}
