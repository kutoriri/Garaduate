using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nColorCange : MonoBehaviour
{

    public float changetime = 6.4f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Change", changetime);
    }

    void Change()
    {

        GetComponent<Renderer>().material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
