using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameoverScreen : MonoBehaviour
{
    public TMP_Text pointsText;
    private bool JuegoPausado = false;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = "" + score.ToString();

        JuegoPausado = true;
        Pausa();
    }

    public void Pausa()
    {
        Time.timeScale = 0f;
        JuegoPausado = true;
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
        Audiomanager.PlaySound("Botones");
        JuegoPausado = false;
    }

    public void ExittButton()
    {
        Application.Quit();
        SceneManager.LoadScene("MenuPrincipal");
        Time.timeScale = 1f;
    }

    //private void Update()
    //{
    //    if (juegoPausado)
    //    {
    //        Pausa();
    //    }
    //}
    //public void Pausa()
    //{
    //    Time.timeScale = 0f;
    //    juegoPausado = true;
        
    //}
}
