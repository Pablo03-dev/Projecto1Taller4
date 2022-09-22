using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    [SerializeField] private Material mat;
    [SerializeField] private float parallax = 2f;
    private Vector2 offset;
    private SpriteRenderer sp;


    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        mat = sp.material;
    }

    void Update()
    {
        offset.x += Time.deltaTime / parallax;
        mat.mainTextureOffset = offset;
    }
}
