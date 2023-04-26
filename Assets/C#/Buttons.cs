using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject exersice;
    public GameObject timerComplete;
    public GameObject HelperCanvas;
    public GameObject SettingsCanvas;
    public GameObject complete;
    public GameObject wrong;
    public y_hanox y_Hanox;
    public bool gameIsStarted = false;

    private void Awake()
    {
        if (exersice.active)
            exersice.gameObject.SetActive(false);
    }

    public void _ExersiceBtn()
    {
        exersice.gameObject.SetActive(true);
    }
    public void _ExersiceDecline()
    {
        exersice.gameObject.SetActive(false);
    }
    public void _WaitCanvasBtn()
    {
        timerComplete.gameObject.SetActive(true);
    }

    public void _WaitCanvasDecline()
    {
        timerComplete.gameObject.SetActive(false);
    }

    public void _CompleteBtn()
    {
        complete.gameObject.SetActive(true);
    }

    public void _CompleteDecline()
    {
        complete.gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void _WrongBtn()
    {
        wrong.gameObject.SetActive(true);
    }

    public void _WrongDecline()
    {
        wrong.gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void _Confirm()
    {
        gameIsStarted = true;
        y_Hanox.tagWithWeight();
    }

    public void _Clear()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void _Quit()
    {
        Application.Quit();
    }

    public void _HelperCanvasActivate()
    {
        HelperCanvas.gameObject.SetActive(true);
    }
    public void _HelperCanvasDeActivate()
    {
        HelperCanvas.gameObject.SetActive(false);
    }

    public void _SettingsCanvasActivate()
    {
        SettingsCanvas.gameObject.SetActive(true);
    }

    public void _SettingsCanvasDeActivate()
    {
        SettingsCanvas.gameObject.SetActive(false);
    }
    public void _Weight()
    {

    }
}
