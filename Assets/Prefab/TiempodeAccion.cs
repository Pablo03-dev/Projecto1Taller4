using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempodeAccion : MonoBehaviour
{
    public float Tiempovida;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, Tiempovida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
