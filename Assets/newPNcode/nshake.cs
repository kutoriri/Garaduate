using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nshake : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FunctionTest", 0f, 1.0f);
       // rb.AddForce(0, 5.0f, 100.0f, ForceMode.Force);
    }

    void FunctionTest()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * 5.0f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
