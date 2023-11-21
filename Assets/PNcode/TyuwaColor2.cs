using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TyuwaColor2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Change",6.0f);
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
