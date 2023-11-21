using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TyuwaColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Change", 4.5f);
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
