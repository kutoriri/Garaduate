using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    [SerializeField] private GameObject a;
    public float ET = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Call", ET);
    }

    void Call()
    {
        a.SetActive(true);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
