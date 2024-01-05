using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D3appeartiming : MonoBehaviour
{
    [SerializeField] private GameObject a;
    [SerializeField] private GameObject b;
    [SerializeField] private GameObject c;
    public float ET = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Call", ET);
    }

    void Call()
    {
        a.SetActive(true);
        b.SetActive(true);
        c.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
