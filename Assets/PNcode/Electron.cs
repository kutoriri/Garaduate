using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electron : MonoBehaviour
{
    [SerializeField] private GameObject electron1;
    [SerializeField] private GameObject electron2;
    [SerializeField] private GameObject electron3;
    [SerializeField] private GameObject electron4;

    [SerializeField] private GameObject hole1;
    [SerializeField] private GameObject hole2;
    [SerializeField] private GameObject hole3;
    [SerializeField] private GameObject hole4;

    [SerializeField] private GameObject band1;
    [SerializeField] private GameObject band2;
    [SerializeField] private GameObject band3;
    [SerializeField] private GameObject band4;

    [SerializeField] private GameObject a;
    [SerializeField] private GameObject b;
    [SerializeField] private GameObject c;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Call", 2);
    }

    void Call()
    {
        electron1.SetActive(true);
        electron2.SetActive(true);
        electron3.SetActive(true);
        electron4.SetActive(true);

        hole1.SetActive(true);
        hole2.SetActive(true);
        hole3.SetActive(true);
        hole4.SetActive(true);

        band1.SetActive(true);
        band2.SetActive(true);
        band3.SetActive(true);
        band4.SetActive(true);

        a.SetActive(true);
        b.SetActive(true);
        c.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
