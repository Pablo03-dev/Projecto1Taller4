using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoSimple : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.manager.AddScore(10);
            Audiomanager.PlaySound("Puntos");
        }
        if (collision.gameObject.tag == "Bloque")
        {
            GameManager.manager.AddScore(5);
            Audiomanager.PlaySound("Puntos");
        }
    }
}
