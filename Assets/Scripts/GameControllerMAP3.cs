using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerMAP3 : MonoBehaviour
{
    // Start is called before the first frame update.

    public GameObject boto2;
    public GameObject boto3;
    public GameObject boto4;
    public GameObject boto5;
    public GameObject boto6;
    public GameObject boto7;
    public GameObject boto8;
    public GameObject boto9;

    public GameObject lock2;
    public GameObject lock3;
    public GameObject lock4;
    public GameObject lock5;
    public GameObject lock6;
    public GameObject lock7;
    public GameObject lock8;
    public GameObject lock9;

    public bool prova;

    public int pantallesPassadesMON2;

    void Start()
    {
        pantallesPassadesMON2 = PlayerPrefs.GetInt("pantallesPassadesMON2");

        switch (pantallesPassadesMON2)
        {
            case 2:
                lock2.gameObject.SetActive(false);
                boto2.gameObject.SetActive(true);
                lock3.gameObject.SetActive(true);
                boto3.gameObject.SetActive(false);
                lock4.gameObject.SetActive(true);
                boto4.gameObject.SetActive(false);
                lock5.gameObject.SetActive(true);
                boto5.gameObject.SetActive(false);
                lock6.gameObject.SetActive(true);
                boto6.gameObject.SetActive(false);
                lock7.gameObject.SetActive(true);
                boto7.gameObject.SetActive(false);
                lock8.gameObject.SetActive(true);
                boto8.gameObject.SetActive(false);
                lock9.gameObject.SetActive(true);
                boto9.gameObject.SetActive(false);
                break;

            case 3:
                lock2.gameObject.SetActive(false);
                boto2.gameObject.SetActive(true);
                lock3.gameObject.SetActive(false);
                boto3.gameObject.SetActive(true);
                lock4.gameObject.SetActive(true);
                boto4.gameObject.SetActive(false);
                lock5.gameObject.SetActive(true);
                boto5.gameObject.SetActive(false);
                lock6.gameObject.SetActive(true);
                boto6.gameObject.SetActive(false);
                lock7.gameObject.SetActive(true);
                boto7.gameObject.SetActive(false);
                lock8.gameObject.SetActive(true);
                boto8.gameObject.SetActive(false);
                lock9.gameObject.SetActive(true);
                boto9.gameObject.SetActive(false);
                break;


            case 4:
                lock2.gameObject.SetActive(false);
                boto2.gameObject.SetActive(true);
                lock3.gameObject.SetActive(false);
                boto3.gameObject.SetActive(true);
                lock4.gameObject.SetActive(false);
                boto4.gameObject.SetActive(true);
                lock5.gameObject.SetActive(true);
                boto5.gameObject.SetActive(false);
                lock6.gameObject.SetActive(true);
                boto6.gameObject.SetActive(false);
                lock7.gameObject.SetActive(true);
                boto7.gameObject.SetActive(false);
                lock8.gameObject.SetActive(true);
                boto8.gameObject.SetActive(false);
                lock9.gameObject.SetActive(true);
                boto9.gameObject.SetActive(false);
                break;


            case 5:

                lock2.gameObject.SetActive(false);
                boto2.gameObject.SetActive(true);
                lock3.gameObject.SetActive(false);
                boto3.gameObject.SetActive(true);
                lock4.gameObject.SetActive(false);
                boto4.gameObject.SetActive(true);
                lock5.gameObject.SetActive(false);
                boto5.gameObject.SetActive(true);
                lock6.gameObject.SetActive(true);
                boto6.gameObject.SetActive(false);
                lock7.gameObject.SetActive(true);
                boto7.gameObject.SetActive(false);
                lock8.gameObject.SetActive(true);
                boto8.gameObject.SetActive(false);
                lock9.gameObject.SetActive(true);
                boto9.gameObject.SetActive(false);
                break;


            case 6:

                lock2.gameObject.SetActive(false);
                boto2.gameObject.SetActive(true);
                lock3.gameObject.SetActive(false);
                boto3.gameObject.SetActive(true);
                lock4.gameObject.SetActive(false);
                boto4.gameObject.SetActive(true);
                lock5.gameObject.SetActive(false);
                boto5.gameObject.SetActive(true);
                lock6.gameObject.SetActive(false);
                boto6.gameObject.SetActive(true);
                lock7.gameObject.SetActive(true);
                boto7.gameObject.SetActive(false);
                lock8.gameObject.SetActive(true);
                boto8.gameObject.SetActive(false);
                lock9.gameObject.SetActive(true);
                boto9.gameObject.SetActive(false);
                break;


            case 7:

                lock2.gameObject.SetActive(false);
                boto2.gameObject.SetActive(true);
                lock3.gameObject.SetActive(false);
                boto3.gameObject.SetActive(true);
                lock4.gameObject.SetActive(false);
                boto4.gameObject.SetActive(true);
                lock5.gameObject.SetActive(false);
                boto5.gameObject.SetActive(true);
                lock6.gameObject.SetActive(false);
                boto6.gameObject.SetActive(true);
                lock7.gameObject.SetActive(false);
                boto7.gameObject.SetActive(true);
                lock8.gameObject.SetActive(true);
                boto8.gameObject.SetActive(false);
                lock9.gameObject.SetActive(true);
                boto9.gameObject.SetActive(false);
                break;


            case 8:

                lock2.gameObject.SetActive(false);
                boto2.gameObject.SetActive(true);
                lock3.gameObject.SetActive(false);
                boto3.gameObject.SetActive(true);
                lock4.gameObject.SetActive(false);
                boto4.gameObject.SetActive(true);
                lock5.gameObject.SetActive(false);
                boto5.gameObject.SetActive(true);
                lock6.gameObject.SetActive(false);
                boto6.gameObject.SetActive(true);
                lock7.gameObject.SetActive(false);
                boto7.gameObject.SetActive(true);
                lock8.gameObject.SetActive(false);
                boto8.gameObject.SetActive(true);
                lock9.gameObject.SetActive(true);
                boto9.gameObject.SetActive(false);
                break;


            case 9:

                lock2.gameObject.SetActive(false);
                boto2.gameObject.SetActive(true);
                lock3.gameObject.SetActive(false);
                boto3.gameObject.SetActive(true);
                lock4.gameObject.SetActive(false);
                boto4.gameObject.SetActive(true);
                lock5.gameObject.SetActive(false);
                boto5.gameObject.SetActive(true);
                lock6.gameObject.SetActive(false);
                boto6.gameObject.SetActive(true);
                lock7.gameObject.SetActive(false);
                boto7.gameObject.SetActive(true);
                lock8.gameObject.SetActive(false);
                boto8.gameObject.SetActive(true);
                lock9.gameObject.SetActive(false);
                boto9.gameObject.SetActive(true);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tornar()
    {
        SceneManager.LoadScene(7);

    }

    public void pantalla1()
    {
        PlayerPrefs.SetInt("pantallaSeleccionadaMON2", 1);
        PlayerPrefs.SetInt("pantallaSeleccionada", 0);

        SceneManager.LoadScene(41);
    }


    public void pantalla2()
    {
        PlayerPrefs.SetInt("pantallaSeleccionadaMON2", 2);
        PlayerPrefs.SetInt("pantallaSeleccionada", 0);

        SceneManager.LoadScene(41);
    }


    public void pantalla3()
    {
        PlayerPrefs.SetInt("pantallaSeleccionadaMON2", 3);
        PlayerPrefs.SetInt("pantallaSeleccionada", 0);

        SceneManager.LoadScene(41);
    }


    public void pantalla4()
    {
        PlayerPrefs.SetInt("pantallaSeleccionadaMON2", 4);
        PlayerPrefs.SetInt("pantallaSeleccionada", 0);

        SceneManager.LoadScene(41);
    }


    public void pantalla5()
    {
        PlayerPrefs.SetInt("pantallaSeleccionadaMON2", 5);
        PlayerPrefs.SetInt("pantallaSeleccionada", 0);

        SceneManager.LoadScene(41);
    }


    public void pantalla6()
    {
        PlayerPrefs.SetInt("pantallaSeleccionadaMON2", 6);
        PlayerPrefs.SetInt("pantallaSeleccionada", 0);

        SceneManager.LoadScene(41);
    }


    public void pantalla7()
    {
        PlayerPrefs.SetInt("pantallaSeleccionadaMON2", 7);
        PlayerPrefs.SetInt("pantallaSeleccionada", 0);

        SceneManager.LoadScene(41);
    }


    public void pantalla8()
    {
        PlayerPrefs.SetInt("pantallaSeleccionadaMON2", 8);
        PlayerPrefs.SetInt("pantallaSeleccionada", 0);

        SceneManager.LoadScene(41);
    }


    public void pantalla9()
    {
        PlayerPrefs.SetInt("pantallaSeleccionadaMON2", 9);
        PlayerPrefs.SetInt("pantallaSeleccionada", 0);

        SceneManager.LoadScene(41);
    }




}
