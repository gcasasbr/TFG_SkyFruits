 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Linq;
using System.Globalization;

using UnityEngine.UI;
using System.Collections.Specialized;
//using System.Runtime.Hosting;
using UnityEngine.SceneManagement;

using UnityEngine.SceneManagement;
using System.Security.Cryptography;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update

    public int contador;

    public List<GameObject> ObjectesTocats = new List<GameObject>();  //DEclarem la llista de GameObjects

    public string tipus_fruita;
    public string tipus_fruita2;

    public GameObject PrimerObjecteLlista;
    public GameObject chest;

    public int punts;
    public GameObject contador_punts;
    public GameObject contador_moviments;
    public GameObject contador_segons;

    public GameObject ultimObjecte;
    public Vector3 ultimPosicio;

    public int moviments;
    public float segons;

    public Scene scene;
    public string levelName;

    public bool intercanvienProces;

    public float posicioYestrella;
    public List<GameObject> ObjectesEnPantalla = new List<GameObject>();  //DEclarem la llista de GameObjects
    public string ObjecteAEliminar;
    public bool estrellaTocada;

    public GameObject text1;
    public GameObject text2;
    public GameObject text3;

    public bool prova;
    public bool destruirTancats;

    public int n;

    public bool contar;

    public GameObject PT;
    public GameObject PLL;
    public GameObject PM;
    public GameObject PN;
    public GameObject PF;

    public int contadorTomaquets;
    public int contadorMelo;
    public int contadorLlimona;
    public int contadorTaronja;
    public int contadorFresa;

    public string puntsObjectiu;
    public string numTaronjaObjectiu;
    public string numFresaObjectiu;
    public string numMeloObjectiu;
    public string numLlimonaObjectiu;
    public string numTomaquetObjectiu;

    public bool prova34;
    public bool habilitador;

    //public RaycastHit hit2;

    public void prova2()
    {
        prova = true;
    }


    void Start()
    {

        habilitador = false;

        puntsObjectiu = "0";
        numTaronjaObjectiu = "0";
        numFresaObjectiu="0";
        numMeloObjectiu="0";
        numLlimonaObjectiu="0";
        numTomaquetObjectiu="0";

        contadorTomaquets = 0;
        contadorMelo = 0;
        contadorLlimona = 0;
        contadorTaronja = 0;
        contadorFresa = 0;

        PT = GameObject.Find("PT");
        PM = GameObject.Find("PM");
        PN = GameObject.Find("PN");
        PLL = GameObject.Find("PLL");
        PF = GameObject.Find("PF");

               

        contador = 0;
        
        prova = false;
        

        destruirTancats = true;

        intercanvienProces = false;
        moviments = 5;

        punts = 0;
        contador = 0;
        tipus_fruita = null;
        chest = GameObject.Find("Chest");
        contador_punts = GameObject.Find("Punts");
        contador_moviments = GameObject.Find("Moviments");
        contador_segons = GameObject.Find("Temps");
        contador_punts.GetComponent<Text>().text = punts.ToString();
        estrellaTocada = false;
       
        text1 = GameObject.Find("Text1");
        text2 = GameObject.Find("Text2");
        text3 = GameObject.Find("Text3");

        scene = SceneManager.GetActiveScene();
        levelName = scene.name;

        switch (levelName)
        {

            case "Scene2":  segons = 90;
                            moviments = 5;
                            puntsObjectiu = "150";
                            numFresaObjectiu = "-";
                            numLlimonaObjectiu = "-";
                            numMeloObjectiu = "-";
                            numTaronjaObjectiu = "-";
                            numTomaquetObjectiu = "-";

                            break;

            case "Scene8":  segons = 120;
                            moviments = 10;
                            puntsObjectiu = "200";
                            numFresaObjectiu = "-";
                            numLlimonaObjectiu = "-";
                            numMeloObjectiu = "-";
                            numTaronjaObjectiu = "-";
                            numTomaquetObjectiu = "-";
                            break;

            case "Scene9":
                            segons = 120;
                            moviments = 15;
                            puntsObjectiu = "200";
                            numFresaObjectiu = "-";
                            numLlimonaObjectiu = "-";
                            numMeloObjectiu = "-";
                            numTaronjaObjectiu = "-";
                            numTomaquetObjectiu = "-";
                            break;

            case "Scene10":

                            puntsObjectiu = "150";
                            numFresaObjectiu = "-";
                            numLlimonaObjectiu = "-";
                            numMeloObjectiu = "-";
                            numTaronjaObjectiu = "-";
                            numTomaquetObjectiu = "-";
                            segons = 150;
                            moviments = 15;
                            break;

            case "Scene11":

                            puntsObjectiu = "200";
                            numFresaObjectiu = "-";
                            numLlimonaObjectiu = "-";
                            numMeloObjectiu = "-";
                            numTaronjaObjectiu = "-";
                            numTomaquetObjectiu = "-";
                            segons = 150;
                            moviments = 12;
                            break;

            case "Scene12":
                            puntsObjectiu = "300";
                            numFresaObjectiu = "-";
                            numLlimonaObjectiu = "-";
                            numMeloObjectiu = "-";
                            numTaronjaObjectiu = "-";
                            numTomaquetObjectiu = "-";
                            segons = 300;
                            moviments = 20;
                            break;

            case "Scene13":
                            puntsObjectiu = "400";
                            numFresaObjectiu = "-";
                            numLlimonaObjectiu = "-";
                            numMeloObjectiu = "-";
                            numTaronjaObjectiu = "-";
                            numTomaquetObjectiu = "-";
                            segons = 300;
                            moviments = 15;
                            break;

            case "Scene14":
                            puntsObjectiu = "220";
                            numFresaObjectiu = "-";
                            numLlimonaObjectiu = "-";
                            numMeloObjectiu = "-";
                            numTaronjaObjectiu = "-";
                            numTomaquetObjectiu = "-";
                            segons = 350;
                            moviments = 15;
                            break;

            case "Scene15":

                            puntsObjectiu = "150";
                            numFresaObjectiu = "-";
                            numLlimonaObjectiu = "-";
                            numMeloObjectiu = "-";
                            numTaronjaObjectiu = "-";
                            numTomaquetObjectiu = "-";
                            segons = 400;
                            moviments = 15;
                            break;


            case "Scene18":

                            puntsObjectiu = "-";
                            numFresaObjectiu = "3";
                            numLlimonaObjectiu = "3";
                            numMeloObjectiu = "3";
                            numTaronjaObjectiu = "3";
                            numTomaquetObjectiu = "3";
                            segons = 400;
                            moviments = 15;
                            break;


            case "Scene19":
                            puntsObjectiu = "-";
                            numFresaObjectiu = "-";
                            numLlimonaObjectiu = "-";
                            numMeloObjectiu = "-";
                            numTaronjaObjectiu = "-";
                            numTomaquetObjectiu = "8";
                            segons = 300;
                            moviments = 10;
                            break;

            case "Scene20":
                            puntsObjectiu = "-";
                            numFresaObjectiu = "-";
                            numLlimonaObjectiu = "-";
                            numMeloObjectiu = "6";
                            numTaronjaObjectiu = "-";
                            numTomaquetObjectiu = "5";
                            segons = 350;
                            moviments = 15;
                            break;

            case "Scene21":
                            puntsObjectiu = "-";
                            numFresaObjectiu = "3";
                            numLlimonaObjectiu = "3";
                            numMeloObjectiu = "3";
                            numTaronjaObjectiu = "5";
                            numTomaquetObjectiu = "3";
                            segons = 400;
                            moviments = 10;
                            break;

            case "Scene22":
                            puntsObjectiu = "-";
                            numFresaObjectiu = "6";
                            numLlimonaObjectiu = "12";
                            numMeloObjectiu = "-";
                            numTaronjaObjectiu = "4";
                            numTomaquetObjectiu = "-";
                            segons = 400;
                            moviments = 15;
                            break;

            case "Scene23":
                            puntsObjectiu = "-";
                            numFresaObjectiu = "-";
                            numLlimonaObjectiu = "-";
                            numMeloObjectiu = "13";
                            numTaronjaObjectiu = "-";
                            numTomaquetObjectiu = "-";
                            segons = 350;
                            moviments = 15;
                            break;

            case "Scene24":
                            puntsObjectiu = "-";
                            numFresaObjectiu = "1";
                            numLlimonaObjectiu = "3";
                            numMeloObjectiu = "-";
                            numTaronjaObjectiu = "3";
                            numTomaquetObjectiu = "1";
                            segons = 300;
                            moviments = 10;
                            break;

            case "Scene25":
                            puntsObjectiu = "-";
                            numFresaObjectiu = "-";
                            numLlimonaObjectiu = "8";
                            numMeloObjectiu = "-";
                            numTaronjaObjectiu = "8";
                            numTomaquetObjectiu = "5";
                            segons = 400;
                            moviments = 15;
                            break;

            case "Scene26":
                            puntsObjectiu = "-";
                            numFresaObjectiu = "-";
                            numLlimonaObjectiu = "-";
                            numMeloObjectiu = "4";
                            numTaronjaObjectiu = "3";
                            numTomaquetObjectiu = "11";
                            segons = 400;
                            moviments = 15;
                            break;


            case "Scene31":

                            puntsObjectiu = "150";
                            numFresaObjectiu = "3";
                            numLlimonaObjectiu = "4";
                            numMeloObjectiu = "4";
                            numTaronjaObjectiu = "-";
                            numTomaquetObjectiu = "6";
                            segons = 400;
                            moviments = 15;
                            break;

            case "Scene32":
                            puntsObjectiu = "100";
                            numFresaObjectiu = "4";
                            numLlimonaObjectiu = "-";
                            numMeloObjectiu = "-";
                            numTaronjaObjectiu = "1";
                            numTomaquetObjectiu = "-";
                            segons = 400;
                            moviments = 15;
                            break;


            case "Scene33":
                            puntsObjectiu = "100";
                            numFresaObjectiu = "5";
                            numLlimonaObjectiu = "-";
                            numMeloObjectiu = "1";
                            numTaronjaObjectiu = "1";
                            numTomaquetObjectiu = "-";
                            segons = 350;
                            moviments = 15;
                            break;

            case "Scene34":
                            puntsObjectiu = "100";
                            numFresaObjectiu = "-";
                            numLlimonaObjectiu = "-";
                            numMeloObjectiu = "-";
                            numTaronjaObjectiu = "-";
                            numTomaquetObjectiu = "1";
                            segons = 400;
                            moviments = 15;
                            break;

            case "Scene35":
                            puntsObjectiu = "150";
                            numFresaObjectiu = "-";
                            numLlimonaObjectiu = "-";
                            numMeloObjectiu = "-";
                            numTaronjaObjectiu = "-";
                            numTomaquetObjectiu = "9";
                            segons = 400;
                            moviments = 15;
                            break;

            case "Scene36":
                            puntsObjectiu = "150";
                            numFresaObjectiu = "-";
                            numLlimonaObjectiu = "3";
                            numMeloObjectiu = "-";
                            numTaronjaObjectiu = "-";
                            numTomaquetObjectiu = "5";
                            segons = 400;
                            moviments = 15;
                            break;

            case "Scene37":
                            puntsObjectiu = "200";
                            numFresaObjectiu = "-";
                            numLlimonaObjectiu = "5";
                            numMeloObjectiu = "5";
                            numTaronjaObjectiu = "5";
                            numTomaquetObjectiu = "5";
                            segons = 400;
                            moviments = 15;
                            break;

            case "Scene38":
                            puntsObjectiu = "250";
                            numFresaObjectiu = "-";
                            numLlimonaObjectiu = "-";
                            numMeloObjectiu = "20";
                            numTaronjaObjectiu = "-";
                            numTomaquetObjectiu = "-";
                            segons = 300;
                            moviments = 15;
                            break;

            case "Scene39":
                            puntsObjectiu = "200";
                            numFresaObjectiu = "-";
                            numLlimonaObjectiu = "-";
                            numMeloObjectiu = "4";
                            numTaronjaObjectiu = "-";
                            numTomaquetObjectiu = "4";
                            segons = 400;
                            moviments = 15;
                            break;

        }


        if (PlayerPrefs.GetInt("IdiomaSeleccionat") == 1)
        {
            text1.GetComponent<Text>().text = "Time";
            text2.GetComponent<Text>().text = "Score";
            text3.GetComponent<Text>().text = "Movements";
        }
        else
        {

            if (PlayerPrefs.GetInt("IdiomaSeleccionat") == 2)
            {
                text1.GetComponent<Text>().text = "Temps";
                text2.GetComponent<Text>().text = "Puntuació";
                text3.GetComponent<Text>().text = "Moviments";
            }
            else
            {

                if (PlayerPrefs.GetInt("IdiomaSeleccionat") == 3)
                {
                    text1.GetComponent<Text>().text = "Tiempo";
                    text2.GetComponent<Text>().text = "Puntuación";
                    text3.GetComponent<Text>().text = "Movimientos";
                }
                else
                {
                    text1.GetComponent<Text>().text = "Time";
                    text2.GetComponent<Text>().text = "Score";
                    text3.GetComponent<Text>().text = "Movements";

                }
            }
        }




    }

    void cronometre()
    {
        segons = segons - 1;
    }

    
    // Update is called once per frame
    void Update()
    {


        if (PT != null)
        {
            PT.GetComponent<Text>().text = contadorTomaquets.ToString()+"/"+numTomaquetObjectiu.ToString();
            PM.GetComponent<Text>().text = " "+contadorMelo.ToString()+"/"+numMeloObjectiu.ToString();
            PLL.GetComponent<Text>().text = contadorLlimona.ToString()+"/"+numLlimonaObjectiu.ToString();
            PN.GetComponent<Text>().text = " "+contadorTaronja.ToString()+"/"+numTaronjaObjectiu.ToString();
            PF.GetComponent<Text>().text = contadorFresa.ToString()+"/"+numFresaObjectiu.ToString();

        }


        if (punts < 0) punts = 0;

        if (estrellaTocada)
        {
            for(int z=0;z< ObjectesEnPantalla.Count(); z++)
            {
                if (ObjectesEnPantalla[z] != null && ObjectesEnPantalla[z].tag!="Tancat" )
                {
                    if (Mathf.Abs(ObjectesEnPantalla[z].GetComponent<Transform>().position.y - posicioYestrella) < 0.4f)
                    {
                        ObjectesEnPantalla[z].GetComponent<FruitMovment>().estrellaTocada = true;
                        ObjectesEnPantalla[z].GetComponent<FruitMovment>().iniciar = true;

                    }
                                    
                                       
                }
                                
            }

            estrellaTocada = false;
        }
        

        switch (levelName)
        {

            case "Scene2":
               
                if(punts>150) SceneManager.LoadScene(5);
                break;

            case "Scene8":

                if (punts > 200) SceneManager.LoadScene(5);
                break;

            case "Scene9":

                if (punts > 200) SceneManager.LoadScene(5);
                break;


            case "Scene10":

                if (punts > 150) SceneManager.LoadScene(5);
                break;


            case "Scene11":

                if (punts > 200) SceneManager.LoadScene(5);
                break;


            case "Scene12":

                if (punts > 300) SceneManager.LoadScene(5);
                break;


            case "Scene13":

                if (punts > 400) SceneManager.LoadScene(5);
                break;


            case "Scene14":

                if (punts > 220) SceneManager.LoadScene(5);
                break;


            case "Scene15":

                if (punts > 150) SceneManager.LoadScene(5);
                break;


            case "Scene18":

                if (contadorTomaquets>2&&contadorMelo>2&&contadorLlimona>2&&contadorFresa>2&&contadorTaronja>2) SceneManager.LoadScene(28);
                break;


            case "Scene19":

                if (contadorTomaquets > 7) SceneManager.LoadScene(28);
                break;


            case "Scene20":

                if (contadorMelo > 5 && contadorTomaquets > 4) SceneManager.LoadScene(28);
                break;


            case "Scene21":

                if (contadorTomaquets > 2 && contadorMelo > 2 && contadorLlimona > 2 && contadorFresa > 2 && contadorTaronja > 4) SceneManager.LoadScene(28);
                break;


            case "Scene22":

                if (contadorLlimona > 11 && contadorFresa > 5 && contadorTaronja>3) SceneManager.LoadScene(28);
                break;


            case "Scene23":

                if (contadorMelo > 12) SceneManager.LoadScene(28);
                break;


            case "Scene24":

                if (contadorTomaquets > 0 && contadorLlimona > 2 && contadorFresa > 0 && contadorTaronja > 2) SceneManager.LoadScene(28);
                break;


            case "Scene25":

                if (contadorTomaquets > 4 && contadorLlimona > 7 && contadorTaronja > 7) SceneManager.LoadScene(28);
                break;


            case "Scene26":

                if (contadorTomaquets > 10 && contadorMelo > 3 && contadorTaronja > 2) SceneManager.LoadScene(28);
                break;


            case "Scene31":

                if (contadorTomaquets > 5 && contadorMelo > 3 && contadorLlimona > 3 && contadorFresa>2 && punts>150) SceneManager.LoadScene(40);
                break;


            case "Scene32":

                if (contadorTaronja>0 && contadorFresa>3 && punts>100 ) SceneManager.LoadScene(40);
                break;


            case "Scene33":

                if (contadorTaronja>0 && contadorMelo>0 && contadorFresa>4 && punts>100) SceneManager.LoadScene(40);
                break;


            case "Scene34":

                if (contadorTomaquets>0 && punts>100) SceneManager.LoadScene(40);
                break;


            case "Scene35":

                if (contadorTomaquets > 8 && punts > 150) SceneManager.LoadScene(40);
                break;


            case "Scene36":

                if (contadorTomaquets > 4 && contadorLlimona > 2 && punts > 150) SceneManager.LoadScene(40);
                break;


            case "Scene37":

                if (contadorTaronja>4 && contadorTomaquets>4 && contadorMelo>4 && contadorLlimona>4 && punts>200) SceneManager.LoadScene(40);
                break;

            case "Scene38":

                if (contadorMelo>19 && punts > 250) SceneManager.LoadScene(40);
                break;

            case "Scene39":

                if (contadorTomaquets > 3 && contadorMelo > 3 && punts > 200) SceneManager.LoadScene(40);
                break;

        }

        if (segons < 0)
        {

            if(levelName == "Scene2" || levelName == "Scene8" || levelName == "Scene9" || levelName == "Scene10" || levelName == "Scene11" || levelName == "Scene12" || levelName == "Scene13" || levelName == "Scene14" || levelName == "Scene15") SceneManager.LoadScene(6);
            if(levelName == "Scene18" || levelName == "Scene19" || levelName == "Scene20" || levelName == "Scene21" || levelName == "Scene22" || levelName == "Scene23" || levelName == "Scene24" || levelName == "Scene25" || levelName == "Scene26") SceneManager.LoadScene(29);
            if(levelName == "Scene31" || levelName == "Scene32" || levelName == "Scene33" || levelName == "Scene34" || levelName == "Scene35" || levelName == "Scene36" || levelName == "Scene37" || levelName == "Scene38" || levelName == "Scene39") SceneManager.LoadScene(40);

        }


        contador_moviments.GetComponent<Text>().text = moviments.ToString();
        contador_segons.GetComponent<Text>().text = Mathf.Round(segons).ToString();

        segons -= Time.deltaTime;

        contador_punts.GetComponent<Text>().text = punts.ToString()+"/"+puntsObjectiu.ToString();

        if (contador > 2 && ObjectesTocats.Any())   //Si contador és mes gran de 2 (Hem tocat 3 objectes iguals seguits) i hi ha elements a la llista.
        {
            ObjecteAEliminar = ObjectesTocats.First().tag;
            PrimerObjecteLlista = ObjectesTocats.First();       //Borrem els elements de la llista i passem els objectes al cistell perquè ens donin punts
            ObjectesTocats.Remove(PrimerObjecteLlista);
            PrimerObjecteLlista.GetComponent<FruitMovment>().iniciar = true;
            
        }

        if (!intercanvienProces &&!habilitador)
        {
            if (Input.touchCount > 0)
            {

                Physics2D.queriesStartInColliders = true;

                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)     //Toquem primer afegim a la llista per primer cop
                {

                    Vector2 worldPoint2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    RaycastHit2D hit2 = Physics2D.Raycast(worldPoint2, Vector2.zero);
                                     
                                       

                    if (hit2.collider != null&& hit2.collider.tag!="Torna" && hit2.collider.tag != "Recargar" && hit2.collider.tag != "TornaM1" && hit2.collider.tag != "TornaM2")
                    {
                        ObjectesTocats.Add(hit2.collider.gameObject);
                        contador = contador + 1;
                        tipus_fruita = hit2.collider.gameObject.tag;

                        ultimPosicio = hit2.collider.gameObject.transform.position;
                    }
                    else
                    {
                        if (hit2.collider != null && hit2.collider.tag == "Torna")
                        {
                            tornar();
                        }
                        else
                        {
                            if (hit2.collider != null && hit2.collider.tag == "Recargar")
                            {
                                recarga();
                            }

                            else
                            {
                                if (hit2.collider != null && hit2.collider.tag == "TornaM1")
                                {
                                    tornarM1();
                                }
                                else
                                {
                                    if (hit2.collider != null && hit2.collider.tag == "TornaM2")
                                    {
                                        prova34 = true;
                                        tornarM2();
                                    }
                                }
                            }
                        }
                    }

                }


                if (touch.phase == TouchPhase.Moved)   //Què fem quan anem movent el dit

                {
                    Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);


                    if (hit.collider != null )
                    {

                        if (hit.collider.gameObject.tag == tipus_fruita || ((hit.collider.gameObject.tag == "Bombolla" || hit.collider.gameObject.tag == "Estrella" || hit.collider.gameObject.tag == "EstrellaDaurada" || hit.collider.gameObject.tag == "Bomba" || tipus_fruita =="Bomba" || tipus_fruita=="EstrellaDaurada" || tipus_fruita == "Estrella" || tipus_fruita == "Bombolla")&&contador>1) ) //Mirem si l'objecet nou que toquem és de la mateixa categoria que l'anterior
                        {

                            if (hit.collider.tag != "Tancat" && hit.collider.tag != "Caixa")
                            {
                                if (!ObjectesTocats.Contains(hit.collider.gameObject))  //Si l'objecte no figura ja a la llista l'afegim, si ja figura a la llista no l'afegim
                                {


                                    if (Vector3.Distance(hit.collider.gameObject.transform.position, ultimPosicio) < 1.35f)
                                    {
                                        if (Mathf.Abs(hit.collider.gameObject.transform.position.x - ultimPosicio.x) < 1f && Mathf.Abs(hit.collider.gameObject.transform.position.y - ultimPosicio.y) < 1f)

                                        {
                                            if (hit.collider.gameObject.tag != "Bomba" && hit.collider.gameObject.tag != "Estrella" && hit.collider.gameObject.tag != "Bombolla")
                                            {
                                                tipus_fruita2 = hit.collider.gameObject.tag;
                                            }

                                            ultimPosicio = hit.collider.gameObject.transform.position;
                                            ObjectesTocats.Add(hit.collider.gameObject);
                                            contador = contador + 1;
                                        }

                                    }
                                }
                            }
                        }
                        else  //si es una fruita diferent el que toquem reiniciem tot i intercanviem objectes de posicio
                        {

                           
                            
                                if (ObjectesTocats.Count() == 1 && contador<3)
                                {
                                    if (!ObjectesTocats.First().GetComponent<FruitMovment>().intercanviar) //mirem que no s'estigui efectutant un intercanvi de fruites ja. Si és le cas no fa res. Sino fa l'intercanvi.
                                    {
                                        if (Vector3.Distance(hit.collider.gameObject.transform.position, ObjectesTocats.First().transform.position) < 1.35f)
                                        {
                                            if (moviments > 0 && hit.collider.gameObject.tag != "EstrellaDaurada" && hit.collider.gameObject.tag != "Tancat" && ObjectesTocats.First().gameObject.tag != "EstrellaDaurada" && hit.collider.gameObject.tag != "Bomba" && hit.collider.gameObject.tag != "Bombolla" && ObjectesTocats.First().gameObject.tag != "Bomba" && ObjectesTocats.First().gameObject.tag != "Tancat" && ObjectesTocats.First().gameObject.tag != "Bombolla")
                                            {

                                                if (hit.collider.gameObject.tag != "Caixa" && ObjectesTocats.First().gameObject.tag != "Caixa")
                                                {

                                                    if (Mathf.Abs(Vector3.Distance(ObjectesTocats.First().transform.position, hit.collider.gameObject.transform.position)) < 1.5f)
                                                    {
                                                    moviments = moviments - 1;
                                                    intercanvienProces = true;
                                                    ObjectesTocats.First().GetComponent<FruitMovment>().intercanvi(ObjectesTocats.First(), hit.collider.gameObject);
                                                    }
                                                }
                                                
                                            }


                                       
                                        habilitador = true;
                                        Invoke("resetear", 1f);

                                    }
                                    }


                                }
                            
                            else
                            {

                               
                                habilitador = true;
                                Invoke("resetear", 1f);
                               
                            }
                        }


                    }

                }

                if (touch.phase == TouchPhase.Ended)  //Quan acabem de tocar reiniciem tot
                {
                  
                    habilitador = true;
                    Invoke("resetear", 1f);
                }



            }
        }
    }

    public void resetear()
    {
        habilitador = false;
        contador = 0;
        ObjectesTocats.Clear();
        tipus_fruita = null;
        Physics2D.queriesStartInColliders = false;
    }

    public void tornar()
    {
        SceneManager.LoadScene(3);
    }


    public void tornarM1()
    {
        SceneManager.LoadScene(16);
    }

    public void tornarM2()
    {
        SceneManager.LoadScene(30);
    }


    public void recarga()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
