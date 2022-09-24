using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchSpawner : MonoBehaviour
{
    public GameObject BloquePrefab;
    public float timerToCreate;
    bool puedoCrearBloques;
    float tiempoDesdelaUltimaCraecion = 0;
    public int counter;
    Vector3 posicionUltimoBloque;
    Transform transformUltimoBloque;
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

        if (counter == 7)
        {
            DetenerCreacion();
        }

        Vector3 posBloque = transform.position;
        Vector3 posicionPlayer = transform.position;
        posicionPlayer.y += 1;
        transform.position = posicionPlayer;


        GameObject elBloque = Instantiate(BloquePrefab, posBloque, transform.rotation);
       
        elBloque.transform.parent = transform.parent;
        counter++;
       

    }

    public void DescontarBloque() => counter--;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Techo")
        {
            DetenerCreacion();
        }
        if (collision.gameObject.tag == "Pared")
        {
            //CinemachineMovimientoCamara.Instance.MoverCamara(2, 2, 0.2f);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Techo")
        {
            Crearbloques();
        }
    }



}
