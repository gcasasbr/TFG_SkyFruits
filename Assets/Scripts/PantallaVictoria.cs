using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PantallaVictoria : MonoBehaviour
{

    public GameObject victoria;
    public GameObject victoria2;
    public GameObject victoria3;
    public GameObject idioma;
    public int idiomaSeleccionat;
    public int mon;
    public int pantallesPassades;

    public int pantallesPassadesMON1;
    public int pantallesPassadesMON2;

    public int pantallaSeleccionada;
    public int pantallaSeleccionadaMON1;
    public int pantallaSeleccionadaMON2;

    public Scene scene;
    public string levelName;

    public int disparador;

    
    void Start()
    {

       
        scene = SceneManager.GetActiveScene();
        levelName = scene.name;

        pantallaSeleccionada = PlayerPrefs.GetInt("pantallaSeleccionada");
        pantallaSeleccionadaMON1 = PlayerPrefs.GetInt("pantallaSeleccionadaMON1");
        pantallaSeleccionadaMON2 = PlayerPrefs.GetInt("pantallaSeleccionadaMON2");

        victoria = GameObject.Find("Text");
        victoria2 = GameObject.Find("Text2");
        victoria3 = GameObject.Find("Text3");
        idioma = GameObject.Find("Idioma(Clone)");
        idiomaSeleccionat = PlayerPrefs.GetInt("IdiomaSeleccionat");
        mon = PlayerPrefs.GetInt("mon");
        pantallesPassades= PlayerPrefs.GetInt("pantallesPassades");
        pantallesPassadesMON1 = PlayerPrefs.GetInt("pantallesPassadesMON1");
        pantallesPassadesMON2 = PlayerPrefs.GetInt("pantallesPassadesMON2");

        disparador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (levelName == "Scene 5")
        {
            if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) victoria.GetComponent<Text>().text = "VICTORY!!!";
            if (idiomaSeleccionat == 2) victoria.GetComponent<Text>().text = "VICTORIA!!!";
            if (idiomaSeleccionat == 3) victoria.GetComponent<Text>().text = "VICTORIA!!!";
        }

        if (levelName == "Scene6")
        {
            if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) victoria.GetComponent<Text>().text = "Ups...Time is over!!!";
            if (idiomaSeleccionat == 2) victoria.GetComponent<Text>().text = "Ups...El temps s'ha acabat!!!";
            if (idiomaSeleccionat == 3) victoria.GetComponent<Text>().text = "Ups...El tiempo se ha acabado!!!";
        }

        if (levelName == "Scene28" || levelName == "Scene40")
        {
            if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) victoria.GetComponent<Text>().text = "VICTORY!!!";
            if (idiomaSeleccionat == 2) victoria.GetComponent<Text>().text = "VICTORIA!!!";
            if (idiomaSeleccionat == 3) victoria.GetComponent<Text>().text = "VICTORIA!!!";
        }

        if (levelName == "Scene29" || levelName == "Scene42")
        {
            if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) victoria.GetComponent<Text>().text = "Ups...Time is over!!!";
            if (idiomaSeleccionat == 2) victoria.GetComponent<Text>().text = "Ups...El temps s'ha acabat!!!";
            if (idiomaSeleccionat == 3) victoria.GetComponent<Text>().text = "Ups...El tiempo se ha acabado!!!";
        }


        if (levelName== "Scene43")
        {
            if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) victoria.GetComponent<Text>().text = "Congratulations you managed to catch all the little angels in the fruit ... but someone noticed ...";
            if (idiomaSeleccionat == 2) victoria.GetComponent<Text>().text = "Felicitats has conseguit atrapar tots els angeletes de la fruita... però algú se n'ha adonat...";
            if (idiomaSeleccionat == 3) victoria.GetComponent<Text>().text = "Felicidades has conseguido atrapar todos los angelitos de la fruta ... pero alguien se ha dado cuenta ...";

            if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) victoria2.GetComponent<Text>().text = "Stay tuned for how the story continues with new worlds and updates";
            if (idiomaSeleccionat == 2) victoria2.GetComponent<Text>().text = "Estigues atent a com segueix la història amb nous móns i actualitzacions";
            if (idiomaSeleccionat == 3) victoria2.GetComponent<Text>().text = "Estate atento a cómo sigue la historia con nuevos mundos y actualizaciones";


            if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) victoria3.GetComponent<Text>().text = "Thanks for playing SKY-FRUITS";
            if (idiomaSeleccionat == 2) victoria3.GetComponent<Text>().text = "Gràcies per jugar a SKY-FRUITS";
            if (idiomaSeleccionat == 3) victoria3.GetComponent<Text>().text = "Gracias por jugar a SKY-FRUTOS";


        }


    }

    public void tornar()
    {
        if (levelName == "Scene 5")
        {
                      
            
                if (pantallaSeleccionada > pantallesPassades || pantallesPassades == 1 || pantallaSeleccionada == pantallesPassades)
                {
                    if (pantallaSeleccionada == 1) PlayerPrefs.SetInt("pantallesPassades", 2);      //posar if per assegurar que pantalles passades sigui més petit que 8???
                    if (pantallaSeleccionada == 2) PlayerPrefs.SetInt("pantallesPassades", 3);
                    if (pantallaSeleccionada == 3) PlayerPrefs.SetInt("pantallesPassades", 4);
                    if (pantallaSeleccionada == 4) PlayerPrefs.SetInt("pantallesPassades", 5);
                    if (pantallaSeleccionada == 5) PlayerPrefs.SetInt("pantallesPassades", 6);
                    if (pantallaSeleccionada == 6) PlayerPrefs.SetInt("pantallesPassades", 7);
                    if (pantallaSeleccionada == 7) PlayerPrefs.SetInt("pantallesPassades", 8);
                    if (pantallaSeleccionada == 8) PlayerPrefs.SetInt("pantallesPassades", 9);
                    if (pantallaSeleccionada == 9)
                    {
                        PlayerPrefs.SetInt("mon", 1);
                        PlayerPrefs.SetInt("pantallesPassadesM1", 1);

                    }
                }
            

        }


        if (levelName == "Scene28")
        {

            
            if (pantallaSeleccionadaMON1 > pantallesPassadesMON1 || pantallesPassadesMON1 == 1 || pantallaSeleccionadaMON1 == pantallesPassadesMON1)
            {

              
                    if (pantallaSeleccionadaMON1 == 1) PlayerPrefs.SetInt("pantallesPassadesMON1", 2);      
                    if (pantallaSeleccionadaMON1 == 2) PlayerPrefs.SetInt("pantallesPassadesMON1", 3);
                    if (pantallaSeleccionadaMON1 == 3) PlayerPrefs.SetInt("pantallesPassadesMON1", 4);
                    if (pantallaSeleccionadaMON1 == 4) PlayerPrefs.SetInt("pantallesPassadesMON1", 5);
                    if (pantallaSeleccionadaMON1 == 5) PlayerPrefs.SetInt("pantallesPassadesMON1", 6);
                    if (pantallaSeleccionadaMON1 == 6) PlayerPrefs.SetInt("pantallesPassadesMON1", 7);
                    if (pantallaSeleccionadaMON1 == 7) PlayerPrefs.SetInt("pantallesPassadesMON1", 8);
                    if (pantallaSeleccionadaMON1 == 8) PlayerPrefs.SetInt("pantallesPassadesMON1", 9);
                    if (pantallaSeleccionadaMON1 == 9)
                    {
                        PlayerPrefs.SetInt("mon", 2);
                        PlayerPrefs.SetInt("pantallesPassadesM2", 1);
                       
                    }
                
            }
            


        }


        if (levelName == "Scene40")
        {


            if (pantallaSeleccionadaMON2 > pantallesPassadesMON2 || pantallesPassadesMON2 == 1 || pantallaSeleccionadaMON2 == pantallesPassadesMON2)
            {


                if (pantallaSeleccionadaMON2 == 1) PlayerPrefs.SetInt("pantallesPassadesMON2", 2);
                if (pantallaSeleccionadaMON2 == 2) PlayerPrefs.SetInt("pantallesPassadesMON2", 3);
                if (pantallaSeleccionadaMON2 == 3) PlayerPrefs.SetInt("pantallesPassadesMON2", 4);
                if (pantallaSeleccionadaMON2 == 4) PlayerPrefs.SetInt("pantallesPassadesMON2", 5);
                if (pantallaSeleccionadaMON2 == 5) PlayerPrefs.SetInt("pantallesPassadesMON2", 6);
                if (pantallaSeleccionadaMON2 == 6) PlayerPrefs.SetInt("pantallesPassadesMON2", 7);
                if (pantallaSeleccionadaMON2 == 7) PlayerPrefs.SetInt("pantallesPassadesMON2", 8);
                if (pantallaSeleccionadaMON2 == 8) PlayerPrefs.SetInt("pantallesPassadesMON2", 9);
                if (pantallaSeleccionadaMON2 == 9)
                {
                    //PlayerPrefs.SetInt("mon", 2);
                    //PlayerPrefs.SetInt("pantallesPassadesM2", 1);

                }

            }



        }



        if (pantallaSeleccionada == 9 && levelName == "Scene 5")
        {
            SceneManager.LoadScene(7);
        }

        if (pantallaSeleccionada < 9 && levelName == "Scene 5")
        {
            SceneManager.LoadScene(3);
        }


        if (pantallaSeleccionadaMON1 == 9 && levelName == "Scene28")
        {
            SceneManager.LoadScene(7);
        }

        if (pantallaSeleccionadaMON1 < 9 && levelName == "Scene28")
        {
            SceneManager.LoadScene(16);
        }


        if (pantallaSeleccionadaMON2 == 9 && levelName == "Scene40")
        {
            SceneManager.LoadScene(43);

        }

        if (pantallaSeleccionadaMON2 < 9 && levelName == "Scene40")
        {
            SceneManager.LoadScene(30);
        }

        if (levelName == "Scene29")
        {
            SceneManager.LoadScene(16);
        }

        if (levelName == "Scene6")
        {
            SceneManager.LoadScene(3);

        }

        if (levelName == "Scene42")
        {
            SceneManager.LoadScene(30);

        }

        if (levelName == "Scene43")
        {
            SceneManager.LoadScene(0);

        }


    }

}
