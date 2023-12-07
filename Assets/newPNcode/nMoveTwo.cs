using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nMoveTwo : MonoBehaviour
{
    private bool isMoving = false;
    private bool isMoving2 = false;
    public float MoveTime = 1.0f;
    public float MoveTime2 = 2.0f;

    //最初の目的地
    public float x = 1.5f;
    public float y = 1.5f;
    public float z = 1.5f;

    //次の目的地
    public float a = 2.0f;
    public float b = 2.0f;
    public float c = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
        Invoke("Call", MoveTime);
        Invoke("Call2", MoveTime2);
    }

    void Call()
    {
        isMoving = true;
    }

    void Call2()
    {
        isMoving2 = true;
    }

    // Update is called once per frame

    void Update()
    {
        if (isMoving == false && isMoving2 == false) return;


        if (isMoving == true && isMoving2 == false)
        {
            Vector3 current = transform.position;
            Vector3 target = new Vector3(x, y, z);
            float step = 2.0f * Time.deltaTime;
            transform.position = Vector3.MoveTowards(current, target, Time.deltaTime * 2.0f);
        }

        if (isMoving == true && isMoving2 == true)
        {
            Vector3 current2 = transform.position;
            Vector3 target2 = new Vector3(a, b, c);
            float step2 = 2.0f * Time.deltaTime;
            transform.position = Vector3.MoveTowards(current2, target2, Time.deltaTime * 2.0f);
        }
    }
}
