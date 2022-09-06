using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchSpawner : MonoBehaviour
{
    public GameObject BloquePrefab;
    public float timerToCreate;
    bool puedoCrearBloques;
    float tiempoDesdelaUltimaCraecion = 0;

    Vector3 posicionUltimoBloque;

    // Start is called before the first frame update
    void Start()
    {
        //Player
        posicionUltimoBloque = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        if (puedoCrearBloques)
        {
            tiempoDesdelaUltimaCraecion += Time.deltaTime;

            if (tiempoDesdelaUltimaCraecion >= timerToCreate)
            {
                SpawnBloque();
                tiempoDesdelaUltimaCraecion = 0;
            }
        }   
    }

    public void Crearbloques()
    {
        puedoCrearBloques = true;
        tiempoDesdelaUltimaCraecion = 0;
    }


    public void DetenerCreacion()
    {
        puedoCrearBloques = false;
    }

    void SpawnBloque()
    {
        Vector3 posicionPlayer = transform.position;
        posicionPlayer.y += 1;
        transform.position = posicionPlayer;

        GameObject elBloque = Instantiate(BloquePrefab, posicionUltimoBloque, transform.rotation);
        elBloque.transform.parent = transform.parent;
        posicionUltimoBloque = transform.position;
    }

}
