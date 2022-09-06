using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PantallaInicio : MonoBehaviour
{
    private bool juego_Pausado = true;

    // Start is called before the first frame update
    void Start()
    {
        //juego_Pausado = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Empezando()
    {
        //gameObject.SetActive(true);
        juego_Pausado = true;
        Time.timeScale = 0f;

        Pausado();
    }

    public void Pausado()
    {
        Time.timeScale = 0f;
        juego_Pausado = true;
    }

    public void PlayButton()
    {
        //SceneManager.LoadScene("SampleScene");
        gameObject.SetActive(false);
        juego_Pausado = false;
        Time.timeScale = 1f;
    }
}
