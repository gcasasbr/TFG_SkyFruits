using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObjectiusPantalla : MonoBehaviour
{

    public GameObject titol;
    public GameObject puntuacio;
    public GameObject temps;
    public GameObject moviment;
    public GameObject objectiu;
    public GameObject objectiu1;
    public GameObject objectiu2;
    public GameObject objectiu3;
    public GameObject objectiu4;
    public GameObject objectiu5;
    public GameObject BotonGO;

    public GameObject idioma;
    public int idiomaSeleccionat;

    public int pantallaSeleccionada;
    public int pantallaSeleccionadaMON1;
    public int pantallaSeleccionadaMON2;

    public Scene scene;
    public string levelName;


    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        levelName = scene.name;

        titol = GameObject.Find("Titol");
        
        puntuacio = GameObject.Find("Objectiu");
        objectiu1 = GameObject.Find("Objectiu1");
        objectiu2 = GameObject.Find("Objectiu2");
        objectiu3 = GameObject.Find("Objectiu3");
        objectiu4 = GameObject.Find("Objectiu4");
        objectiu5 = GameObject.Find("Objectiu5");

        moviment = GameObject.Find("Moviments");
        temps=GameObject.Find("Temps");
        BotonGO= GameObject.Find("Text");

        idiomaSeleccionat = PlayerPrefs.GetInt("IdiomaSeleccionat");
        pantallaSeleccionada = PlayerPrefs.GetInt("pantallaSeleccionada");
        pantallaSeleccionadaMON1= PlayerPrefs.GetInt("pantallaSeleccionadaMON1");
        pantallaSeleccionadaMON2 = PlayerPrefs.GetInt("pantallaSeleccionadaMON2");
    }

    // Update is called once per frame
    void Update()
    {

        if (levelName == "Scene4")
        {

            if (pantallaSeleccionada == 1)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 1";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Get more than 150 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 5";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 90 seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Pantalla 1";
                if (idiomaSeleccionat == 2) puntuacio.GetComponent<Text>().text = "Aconsegueix més de 150 punts";
                if (idiomaSeleccionat == 2) moviment.GetComponent<Text>().text = "Moviments permesos: 5";
                if (idiomaSeleccionat == 2) temps.GetComponent<Text>().text = "Temps màxim: 90 segons";
                if (idiomaSeleccionat == 2) BotonGO.GetComponent<Text>().text = "Som-hi!!!";


                if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Pantalla 1";
                if (idiomaSeleccionat == 3) puntuacio.GetComponent<Text>().text = "Consigue mas de 150 puntos";
                if (idiomaSeleccionat == 3) moviment.GetComponent<Text>().text = "Movimentos permitidos: 5";
                if (idiomaSeleccionat == 3) temps.GetComponent<Text>().text = "Tiempo máximo: 90 segundos";
                if (idiomaSeleccionat == 3) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }

            if (pantallaSeleccionada == 2)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 2";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Get more than 200 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 10";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 120 seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Pantalla 2";
                if (idiomaSeleccionat == 2) puntuacio.GetComponent<Text>().text = "Aconsegueix més de 200 punts";
                if (idiomaSeleccionat == 2) moviment.GetComponent<Text>().text = "Moviments permesos: 10";
                if (idiomaSeleccionat == 2) temps.GetComponent<Text>().text = "Temps màxim: 120 segons";
                if (idiomaSeleccionat == 2) BotonGO.GetComponent<Text>().text = "Som-hi!!!";


                if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Pantalla 2";
                if (idiomaSeleccionat == 3) puntuacio.GetComponent<Text>().text = "Consigue mas de 200 puntos";
                if (idiomaSeleccionat == 3) moviment.GetComponent<Text>().text = "Movimentos permitidos: 10";
                if (idiomaSeleccionat == 3) temps.GetComponent<Text>().text = "Tiempo máximo: 120 segundos";
                if (idiomaSeleccionat == 3) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }

            if (pantallaSeleccionada == 3)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 3";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Get more than 200 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 120 seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Pantalla 3";
                if (idiomaSeleccionat == 2) puntuacio.GetComponent<Text>().text = "Aconsegueix més de 200 punts";
                if (idiomaSeleccionat == 2) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2) temps.GetComponent<Text>().text = "Temps màxim: 120 segons";
                if (idiomaSeleccionat == 2) BotonGO.GetComponent<Text>().text = "Som-hi!!!";


                if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Pantalla 3";
                if (idiomaSeleccionat == 3) puntuacio.GetComponent<Text>().text = "Consigue mas de 200 puntos";
                if (idiomaSeleccionat == 3) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3) temps.GetComponent<Text>().text = "Tiempo máximo: 120 segundos";
                if (idiomaSeleccionat == 3) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionada == 4)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 4";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Get more than 150 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 150 seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Pantalla 4";
                if (idiomaSeleccionat == 2) puntuacio.GetComponent<Text>().text = "Aconsegueix més de 150 punts";
                if (idiomaSeleccionat == 2) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2) temps.GetComponent<Text>().text = "Temps màxim: 150 segons";
                if (idiomaSeleccionat == 2) BotonGO.GetComponent<Text>().text = "Som-hi!!!";


                if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Pantalla 4";
                if (idiomaSeleccionat == 3) puntuacio.GetComponent<Text>().text = "Consigue mas de 150 puntos";
                if (idiomaSeleccionat == 3) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3) temps.GetComponent<Text>().text = "Tiempo máximo: 150 segundos";
                if (idiomaSeleccionat == 3) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionada == 5)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 5";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Get more than 200 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 12";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 150 seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Pantalla 5";
                if (idiomaSeleccionat == 2) puntuacio.GetComponent<Text>().text = "Aconsegueix més de 200 punts";
                if (idiomaSeleccionat == 2) moviment.GetComponent<Text>().text = "Moviments permesos: 12";
                if (idiomaSeleccionat == 2) temps.GetComponent<Text>().text = "Temps màxim: 150 segons";
                if (idiomaSeleccionat == 2) BotonGO.GetComponent<Text>().text = "Som-hi!!!";


                if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Pantalla 5";
                if (idiomaSeleccionat == 3) puntuacio.GetComponent<Text>().text = "Consigue mas de 200 puntos";
                if (idiomaSeleccionat == 3) moviment.GetComponent<Text>().text = "Movimentos permitidos: 12";
                if (idiomaSeleccionat == 3) temps.GetComponent<Text>().text = "Tiempo máximo: 150 segundos";
                if (idiomaSeleccionat == 3) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionada == 6)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 6";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Get more than 300 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 300 seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Pantalla 6";
                if (idiomaSeleccionat == 2) puntuacio.GetComponent<Text>().text = "Aconsegueix més de 300 punts";
                if (idiomaSeleccionat == 2) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2) temps.GetComponent<Text>().text = "Temps màxim: 300 segons";
                if (idiomaSeleccionat == 2) BotonGO.GetComponent<Text>().text = "Som-hi!!!";


                if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Pantalla 6";
                if (idiomaSeleccionat == 3) puntuacio.GetComponent<Text>().text = "Consigue mas de 300 puntos";
                if (idiomaSeleccionat == 3) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3) temps.GetComponent<Text>().text = "Tiempo máximo: 300 segundos";
                if (idiomaSeleccionat == 3) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionada == 7)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 7";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Get more than 400 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 300 seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Pantalla 7";
                if (idiomaSeleccionat == 2) puntuacio.GetComponent<Text>().text = "Aconsegueix més de 400 punts";
                if (idiomaSeleccionat == 2) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2) temps.GetComponent<Text>().text = "Temps màxim: 300 segons";
                if (idiomaSeleccionat == 2) BotonGO.GetComponent<Text>().text = "Som-hi!!!";


                if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Pantalla 7";
                if (idiomaSeleccionat == 3) puntuacio.GetComponent<Text>().text = "Consigue mas de 400 puntos";
                if (idiomaSeleccionat == 3) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3) temps.GetComponent<Text>().text = "Tiempo máximo: 300 segundos";
                if (idiomaSeleccionat == 3) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionada == 8)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 8";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Get more than 220 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 350 seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Pantalla 8";
                if (idiomaSeleccionat == 2) puntuacio.GetComponent<Text>().text = "Aconsegueix més de 220 punts";
                if (idiomaSeleccionat == 2) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2) temps.GetComponent<Text>().text = "Temps màxim: 350 segons";
                if (idiomaSeleccionat == 2) BotonGO.GetComponent<Text>().text = "Som-hi!!!";


                if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Pantalla 8";
                if (idiomaSeleccionat == 3) puntuacio.GetComponent<Text>().text = "Consigue mas de 220 puntos";
                if (idiomaSeleccionat == 3) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3) temps.GetComponent<Text>().text = "Tiempo máximo: 350 segundos";
                if (idiomaSeleccionat == 3) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionada == 9)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 9";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Get more than 150 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 400 seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Pantalla 9";
                if (idiomaSeleccionat == 2) puntuacio.GetComponent<Text>().text = "Aconsegueix més de 150 punts";
                if (idiomaSeleccionat == 2) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2) temps.GetComponent<Text>().text = "Temps màxim: 400 segons";
                if (idiomaSeleccionat == 2) BotonGO.GetComponent<Text>().text = "Som-hi!!!";


                if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Pantalla 9";
                if (idiomaSeleccionat == 3) puntuacio.GetComponent<Text>().text = "Consigue mas de 150 puntos";
                if (idiomaSeleccionat == 3) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3) temps.GetComponent<Text>().text = "Tiempo máximo: 400 segundos";
                if (idiomaSeleccionat == 3) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }

        }

        if (levelName == "Scene17")
        {
            if (pantallaSeleccionadaMON1 == 1)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 1";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Goal:";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Get 3 tomatoes";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Get 3 melons";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Get 3 lemons";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "Get 3 strawberries";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Get 3 ornages";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 300" + " seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 1";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectiu:";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Aconsegueix 3 tomaquets";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Aconsegueix 3 melons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Aconsegueix 3 llimones";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "Aconsegueix 3 freses";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Aconsegueix 3 taronges";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Temps màxim: 300" + " segons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Som-hi!!!";



                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 1";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectivo:";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Consigue 3 tomates";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Consigue 3 melones";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Consigue 3 limones";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "Consigue 3 fresas";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Consigue 3 naranjas";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Tiempo máximo: 300" + " segundos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionadaMON1 == 2)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 2";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Goal:";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Get 8 tomatoes";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 10";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 300" + " seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 2";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectiu:";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Aconsegueix 8 tomaquets";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Moviments permesos: 10";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Temps màxim: 300" + " segons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Som-hi!!!";



                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 2";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectivo:";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Consigue 8 tomates";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movimentos permitidos: 10";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Tiempo máximo: 300" + " segundos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }



            if (pantallaSeleccionadaMON1 == 3)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 3";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Goal:";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Get 5 tomatoes";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Get 6 melons";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 350" + " seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 3";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectiu:";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Aconsegueix 5 tomaquets";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Aconsegueix 6 melons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Temps màxim: 350" + " segons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Som-hi!!!";



                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 3";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectivo:";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Consigue 5 tomates";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Consigue 6 melones";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Tiempo máximo: 350" + " segundos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionadaMON1 == 4)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 4";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Goal:";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Get 5 naranjas";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Get 3 melones";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Get 3 lemons";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "Get 3 strawberries";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Get 3 oranges";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 10";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 400" + " seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 4";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectiu:";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Aconsegueix 5 naranjas";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Aconsegueix 3 melons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Aconsegueix 3 llimones";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "Aconsegueix 3 freses";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Aconsegueix 3 tomaquets";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Moviments permesos: 10";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Temps màxim: 400" + " segons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Som-hi!!!";



                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 4";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectivo:";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Consigue 5 naranjas";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Consigue 3 melones";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Consigue 3 limones";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "Consigue 3 fresas";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Consigue 3 tomates";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movimentos permitidos: 10";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Tiempo máximo: 400" + " segundos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionadaMON1 == 5)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 5";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Goal:";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Get 12 lemons";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Get 6 strawberries";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Get 4 oranges";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 400" + " seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 5";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectiu:";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Aconsegueix 12 llimones";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Aconsegueix 6 freses";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Aconsegueix 4 taronges";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Temps màxim: 400" + " segons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Som-hi!!!";



                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 5";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectivo:";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Consigue 12 limones";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Consigue 6 fresas";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Consigue 4 naranjas";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Tiempo máximo: 400" + " segundos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionadaMON1 == 6)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 6";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Goal:";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Get 13 melons";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 350" + " seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 6";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectiu:";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Aconsegueix 13 melons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Temps màxim: 350" + " segons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Som-hi!!!";



                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 6";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectivo:";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Consigue 13 melones";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Tiempo máximo: 350" + " segundos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionadaMON1 == 7)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 7";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Goal:";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Get 1 tomatoe";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Get 1 strawberry";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Get 3 lemons";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "Get 3 oranges";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 10";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 300" + " seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 7";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectiu:";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Aconsegueix 1 tomaquet";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Aconsegueix 1 fresa";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Aconsegueix 3 llimones";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "Aconsegueix 3 taronges";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Moviments permesos: 10";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Temps màxim: 300" + " segons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Som-hi!!!";



                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 7";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectivo:";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Consigue 1 tomate";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Consigue 1 fresa";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Consigue 3 limones";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "Consigue 2 naranjas";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movimentos permitidos: 10";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Tiempo máximo: 300" + " segundos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionadaMON1 == 8)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 8";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Goal:";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Get 5 tomatoes";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Get 8 lemons";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Get 8 oranges";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 400" + " seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 8";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectiu:";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Aconsegueix 5 tomaquets";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Aconsegueix 8 llimones";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Aconsegueix 8 taronges";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Temps màxim: 400" + " segons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Som-hi!!!";



                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 8";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectivo:";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Consigue 5 tomates";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Consigue 8 limones";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Consigue 8 naranjas";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Tiempo máximo: 400" + " segundos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionadaMON1 == 9)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 9";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Goal:";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Get 10 tomatoes";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Get 4 melons";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Get 2 oranges";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 400" + " seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 9";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectiu:";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Aconsegueix 10 tomaquets";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Aconsegueix 4 melons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Aconsegueix 2 taronges";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Temps màxim: 400" + " segons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Som-hi!!!";



                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 9";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectivo:";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Consigue 10 tomates";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Consigue 4 melones";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Consigue 2 maranjas";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Tiempo máximo: 400" + " segundos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }
        }

        if (levelName == "Scene41")
        {
            if (pantallaSeleccionadaMON2 == 1)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 1";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Goal:";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Get 6 tomatoes";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Get 4 melons";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Get 4 lemons";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "Get 3 strawberries";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Get more than 150 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 400" + " seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 1";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectiu:";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Aconsegueix 6 tomaquets";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Aconsegueix 4 melons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Aconsegueix 4 llimones";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "Aconsegueix 3 freses";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Aconsegueix més de 150 punts";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Temps màxim: 400" + " segons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Som-hi!!!";



                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 1";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectivo:";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Consigue 6 tomates";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Consigue 4 melones";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Consigue 2 naranjas";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "Consigue 3 fresas";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Consigue mas de 150 puntos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Tiempo máximo: 400" + " segundos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionadaMON2 == 2)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 2";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Goal:";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Get 1 orange";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Get 4 strawberries";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Get more than 100 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 400" + " seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 2";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectiu:";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Aconsegueix 1 taronja";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Aconsegueix 4 freses";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Aconsegueix més de 100 punts";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Temps màxim: 400" + " segons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Som-hi!!!";



                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 2";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectivo:";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Consigue 1 naranja";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Consigue 4 fresas";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Consigue mas de 100 puntos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Tiempo máximo: 400" + " segundos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }



            if (pantallaSeleccionadaMON2 == 3)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 3";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Goal:";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Get 1 orange";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Get 1 melon";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Get 5 strawberries";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Get more than 100 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 350" + " seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 3";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectiu:";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Aconsegueix 1 taronja";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Aconsegueix 1 meló";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Aconsegueix 5 freses";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Aconsegueix més de 100 punts";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Temps màxim: 350" + " segons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Som-hi!!!";



                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 3";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectivo:";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Consigue 1 naranja";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Consigue 1 melon";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Consigue 5 fresas";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Consigue mas de 100 puntos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Tiempo máximo: 350" + " segundos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionadaMON2 == 4)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 4";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Goal:";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Get 1 orange";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Get more than 100 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 400" + " seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 4";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectiu:";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Aconsegueix 1 taronja";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Aconsegueix més de 100 punts";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Temps màxim: 400" + " segons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Som-hi!!!";



                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 4";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectivo:";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Consigue 1 naranja";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Consigue mas de 100 puntos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Tiempo máximo: 400" + " segundos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionadaMON2 == 5)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 5";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Goal:";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Get 9 tomatoes";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Get more than 150 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 400" + " seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 5";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectiu:";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Aconsegueix 9 tomaquets";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Aconsegueix més de 150 punts";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Temps màxim: 400" + " segons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Som-hi!!!";



                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 5";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectivo:";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Consigue 9 tomates";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Consigue mas de 150 puntos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Tiempo máximo: 400" + " segundos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionadaMON2 == 6)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 6";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Goal:";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Get 5 tomatoes";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Get 3 lemons";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Get more than 150 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 400" + " seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 6";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectiu:";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Aconsegueix 5 tomaquets";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Aconsegueix 3 llimones";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Aconsegueix més de 150 punts";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Temps màxim: 400" + " segons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Som-hi!!!";



                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 6";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectivo:";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Consigue 5 tomates";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Consigue 3 limones";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Consigue mas de 150 puntos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Tiempo máximo: 400" + " segundos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionadaMON2 == 7)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 7";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Goal:";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Get 5 oranges";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Get 5 tomatoes";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Get 5 melons";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "Get 5 lemons";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Get more than 200 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 400" + " seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 7";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectiu:";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Aconsegueix 5 taronges";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Aconsegueix 5 tomaquets";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Aconsegueix 5 melons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "Aconsegueix 5 llimones";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Aconsegueix més de 200 punts";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Temps màxim: 400" + " segons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Som-hi!!!";



                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 7";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectivo:";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Consigue 5 naranjas";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Consigue 5 tomates";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "Consigue 5 melones";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "Consigue 5 limones";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Consigue mas de 200 puntos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Tiempo máximo: 400" + " segundos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionadaMON2 == 8)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 8";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Goal:";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Get 20 melons";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Get more than 250 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 300" + " seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 8";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectiu:";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Aconsegueix 20 melons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Aconsegueix més de 250 punts";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Temps màxim: 300" + " segons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Som-hi!!!";



                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 8";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectivo:";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Consigue 20 melones";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Consigue mas de 250 puntos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Tiempo máximo: 300" + " segundos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionadaMON2 == 9)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 9";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Goal:";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Get 4 tomatoes";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Get 4 melons";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Get more than 200 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 400" + " seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 9";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectiu:";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Aconsegueix 4 tomaquets";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Aconsegueix 4 melons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Aconsegueix més de 200 punts";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Temps màxim: 400" + " segons";
                if (idiomaSeleccionat == 2 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Som-hi!!!";



                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Pantalla 9";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Objectivo:";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu1.GetComponent<Text>().text = "Consigue 4 tomates";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu2.GetComponent<Text>().text = "Consigue 4 melones";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu3.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu4.GetComponent<Text>().text = "";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) objectiu5.GetComponent<Text>().text = "Consigue mas de 200 puntos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Tiempo máximo: 400" + " segundos";
                if (idiomaSeleccionat == 3 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }

        }


    }

    public void pantallaJugar()
    {

        if (levelName == "Scene4")
        {

            if (pantallaSeleccionada == 1) SceneManager.LoadScene(2);
            if (pantallaSeleccionada == 2) SceneManager.LoadScene(8);
            if (pantallaSeleccionada == 3) SceneManager.LoadScene(9);
            if (pantallaSeleccionada == 4) SceneManager.LoadScene(10);
            if (pantallaSeleccionada == 5) SceneManager.LoadScene(11);
            if (pantallaSeleccionada == 6) SceneManager.LoadScene(12);
            if (pantallaSeleccionada == 7) SceneManager.LoadScene(13);
            if (pantallaSeleccionada == 8) SceneManager.LoadScene(14);
            if (pantallaSeleccionada == 9) SceneManager.LoadScene(15);
        }

        if (levelName == "Scene17")
        {
            if (pantallaSeleccionadaMON1 == 1) SceneManager.LoadScene(18);
            if (pantallaSeleccionadaMON1 == 2) SceneManager.LoadScene(19);
            if (pantallaSeleccionadaMON1 == 3) SceneManager.LoadScene(20);
            if (pantallaSeleccionadaMON1 == 4) SceneManager.LoadScene(21);
            if (pantallaSeleccionadaMON1 == 5) SceneManager.LoadScene(22);
            if (pantallaSeleccionadaMON1 == 6) SceneManager.LoadScene(23);
            if (pantallaSeleccionadaMON1 == 7) SceneManager.LoadScene(24);
            if (pantallaSeleccionadaMON1 == 8) SceneManager.LoadScene(25);
            if (pantallaSeleccionadaMON1 == 9) SceneManager.LoadScene(26);
        }


        if (levelName == "Scene41")
        {
            if (pantallaSeleccionadaMON2 == 1) SceneManager.LoadScene(31);
            if (pantallaSeleccionadaMON2 == 2) SceneManager.LoadScene(32);
            if (pantallaSeleccionadaMON2 == 3) SceneManager.LoadScene(33);
            if (pantallaSeleccionadaMON2 == 4) SceneManager.LoadScene(34);
            if (pantallaSeleccionadaMON2 == 5) SceneManager.LoadScene(35);
            if (pantallaSeleccionadaMON2 == 6) SceneManager.LoadScene(36);
            if (pantallaSeleccionadaMON2 == 7) SceneManager.LoadScene(37);
            if (pantallaSeleccionadaMON2 == 8) SceneManager.LoadScene(38);
            if (pantallaSeleccionadaMON2 == 9) SceneManager.LoadScene(39);
        }

    }

    public void tornar()
    {
        if (levelName == "Scene4") SceneManager.LoadScene(3);
        
        if (levelName == "Scene17") SceneManager.LoadScene(16);

        if (levelName == "Scene41") SceneManager.LoadScene(30);

    }

}
