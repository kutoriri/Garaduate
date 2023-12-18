using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nMovingSlope : MonoBehaviour
{
    private bool isMoving = false;
    public float x = 0f;
    public float y = 2.5f;
    public float z = 9.0f;
    public float MT = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
       
        Invoke("Call", MT);
    }

    void Call()
    {
        isMoving = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving == false) return;
        Vector3 current = transform.position;
        Vector3 target = new Vector3(x, y, z);
        float step = 2.0f * Time.deltaTime;
        transform.position = Vector3.MoveTowards(current, target, Time.deltaTime * 0.5f);
    }

}
