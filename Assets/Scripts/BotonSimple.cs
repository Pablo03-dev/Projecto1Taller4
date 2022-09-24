using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class BotonSimple : MonoBehaviour
{
    public UnityEvent onEnter, onExit, onDown, onUp;


    private void OnMouseEnter()
    {
        onEnter.Invoke();
    }

    private void OnMouseExit()
    {
        onExit.Invoke();
    }

    private void OnMouseDown()
    {
        onDown.Invoke();
        CinemachineMovimientoCamara.Instance.MoverCamara(2, 2, 0.2f);
        //Audiomanager.PlaySound("Destruir");
    }

    private void OnMouseUpAsButton()
    {
        onUp.Invoke();
    }
}
