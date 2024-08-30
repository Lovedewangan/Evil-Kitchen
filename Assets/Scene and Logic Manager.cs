using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneandLogicManager : MonoBehaviour
{
    public void changeToSequence()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void changeToSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void changeToMainMenu()
    {
        SceneManager.LoadScene("Loading");

    }

    public void exitGame()
    {
        Application.Quit();

    }


    public void changeToCutScene()
    {

        SceneManager.LoadScene("CutScene");
        Invoke("changeToSequence()", 12.0f);


    }



}
