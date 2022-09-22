using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float Speed_Scroll;

    public float DistanciaNegativa;
    public float DistanciaPositiva;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Speed_Scroll * Time.deltaTime, 0);

        if (transform.position.x < DistanciaNegativa)
        {
            transform.position = new Vector3(DistanciaPositiva, transform.position.y);
        }
    }
}
