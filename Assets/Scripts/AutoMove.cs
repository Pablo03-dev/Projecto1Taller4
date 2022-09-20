using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float speed = 10;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(transform.right * speed * Time.deltaTime);
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
