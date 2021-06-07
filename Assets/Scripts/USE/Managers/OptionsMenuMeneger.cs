using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenuMeneger : MonoBehaviour
{
    // Ссылка на класс состояний кнопки
    ButtonState buttonState;

    // Для того, чтобы активировать руки
    public GameObject realHandsObject;
    public GameObject lowHandsObject;

    // MainMenu and OptionsMenu
    public GameObject mmObject;
    public GameObject omObject;

    public string nameButtonfrom;

    public bool isMusic;
    public bool isRealHands;
    public bool isLowHands;
    public bool isBack;


    public bool isPlay;
    public bool isOptions;
    public bool isQuit;

    private void Start()
    {
        buttonState = GetComponent<ButtonState>();
    }

    private void Update()
    {
        // Главное меню
        if (isPlay == true)
        {
            SceneManager.LoadScene(1);
            isPlay = false;
        }
        if (isOptions == true)
        {
            Desactive(mmObject);
            Active(omObject);
            isOptions = false;
        }
        if (isQuit == true)
        {
            Debug.Log("Quit");
            isQuit = false;
        }

        //Меню настроек
        if (isBack == true)
        {
            Desactive(omObject);
            Active(mmObject);
            isBack = false;
        }
        if (isMusic == true)
            Debug.Log("Music");
        if (isRealHands == true)
            Desactive(realHandsObject);
        if (isLowHands == true)
            Desactive(lowHandsObject);
    }



    // Активация и  дезактивация объектов
    public void Active(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }
    public void Desactive(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }
}
