using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addforce : MonoBehaviour
{
    public float power = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
        Vector3 force = new Vector3(0.0f, 0.0f, power);    // 力を設定
        rb.AddForce(force,ForceMode.Impulse);  // 力を加える
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
