using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taiming : MonoBehaviour
{
    public float MoveTime = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Call", MoveTime);
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
