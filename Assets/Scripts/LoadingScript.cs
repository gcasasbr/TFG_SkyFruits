﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScript : MonoBehaviour
{

    

    public GameObject text1;
    public GameObject text2;
    public int idiomaSeleccionat;

    // Start is called before the first frame update.
    void Start()
    {

        idiomaSeleccionat = PlayerPrefs.GetInt("IdiomaSeleccionat");

        if (idiomaSeleccionat != null)
        {
            if (idiomaSeleccionat == 1)
            {
                text1.GetComponent<Text>().text = "LOADING...";
                text2.GetComponent<Text>().text = "The angels of the fruit have escaped from heaven, taking advantage of your negligence as guardians of the gates, and are now scattered throughout the world. You have on day to catch them before anyone notices!!!";
            }

            if (idiomaSeleccionat == 2)
            {

                text1.GetComponent<Text>().text = "CARREGANT...";
                text2.GetComponent<Text>().text = "Els angelets de la fruita s’han escapat del cel aprofitant un descuit teu com a guardià de les portes i ara es troben repartits pel món. Tens un dia per atrapar-los abans no se n’adoni ningú!!!";
            }

            if (idiomaSeleccionat == 3)
            {


                text1.GetComponent<Text>().text = "CARGANDO...";
                text2.GetComponent<Text>().text = "Los angelitos de la fruta se han escapado del cielo aprovechando un descuido tuyo como guardián de las puertas y ahora se encuentran repartidos por el mundo. Tienes un dia para atraparlos antes que se de cuenta alguien!!!";
            }
        }

        Invoke("Cargar", 6f);

    }


    void Cargar()
    {
        SceneManager.LoadScene(44);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
