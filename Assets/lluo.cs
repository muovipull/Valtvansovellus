using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class lluo : MonoBehaviour
{
    public TextMeshProUGUI nimi1;
    public TextMeshProUGUI numero1;
    public TextMeshProUGUI lisatieto1;
    public TextMeshProUGUI maara1;
    public TextMeshProUGUI hinta1;
    public GameObject poista_hyvaksy;


    public void Valmistele(string nimi, int numero, string lisatieto, int maara, int hinta)
    {
        nimi1.text = nimi.ToString();
        numero1.text = numero.ToString();
        lisatieto1.text = lisatieto.ToString();
        maara1.text = maara.ToString();
        hinta1.text = hinta.ToString();
    
    }
    public void poista_tuote()
    {
        poista_hyvaksy.SetActive(true);



    }
    public void kylla()//sopii poistaa
    {
        poista_hyvaksy.SetActive(false);
        Destroy(gameObject);




    }



}
