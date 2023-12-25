using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNewEandH : MonoBehaviour
{
    [SerializeField] private GameObject electron;
    [SerializeField] private GameObject hole;
    public float ET = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Call", ET);
    }

    void Call()
    {
        electron.SetActive(true);
        hole.SetActive(true);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
