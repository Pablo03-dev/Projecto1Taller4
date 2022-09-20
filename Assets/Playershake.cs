using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playershake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pared")
        {
            //CinemachineMovimientoCamara.Instance.MoverCamara(2, 2, 0.2f);
        }
    }
}
