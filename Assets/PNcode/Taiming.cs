using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taiming : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Call", 2);
    }

    void Call()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
