using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nMoveElectron : MonoBehaviour
{
    private bool isMoving = false;
    public float MoveTime = 2.0f;

    public float x = 0.6f;
    public float y = -1.02f;
    public float z = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
        Invoke("Call", MoveTime);
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
        Vector3 target = new Vector3(x,y,z);
        float step = 2.0f * Time.deltaTime;
        transform.position = Vector3.MoveTowards(current, target, Time.deltaTime * 2.0f);
    }
}
