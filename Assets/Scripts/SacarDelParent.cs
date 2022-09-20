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

    
}
