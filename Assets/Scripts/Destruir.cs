using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SacarDelCounter()
    {
        transform.parent.GetComponentInChildren<TouchSpawner>().counter--;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pared")
        {

            Destroy(gameObject, 2f);
        }
    }
}
