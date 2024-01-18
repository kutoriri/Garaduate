using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceRepeat : MonoBehaviour
{
    public float Time = 0f;
    public float Time2 = 1.0f;
    public float xpower = 1.0f;
    public float ypower = 1.0f;
    public float zpower = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Call",Time , Time2);
        //Invoke("Call", Time);
    }

    void Call()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
        Vector3 force = new Vector3(xpower, ypower, zpower);    // 力を設定
        rb.AddForce(force, ForceMode.Impulse);  // 力を加える
    }

    // Update is called once per frame
    void Update()
    {

    }
}
