using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SacarDelParent : MonoBehaviour
{
    public Transform elTransform;
    public void Sacar()
    {
        elTransform.parent = null;
    }
}
