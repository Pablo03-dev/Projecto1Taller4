using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SacarDelParent : MonoBehaviour
{
    public Transform elTransform;
    TouchSpawner touchSpawner;
    public void Sacar()
    {
        touchSpawner.DescontarBloque();
        elTransform.parent = null;
    }

    private void Start()
    {
        touchSpawner = transform.parent.parent.GetComponentInChildren<TouchSpawner>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pared")
        {
            //Destroy(gameObject, .5f);
        }
    }


}
