using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nMoveThree : MonoBehaviour
{
    private bool isMoving = false;
    private bool isMoving2 = false;
    private bool isMoving3 = false;
    public float MoveTime = 5.0f;
    public float MoveTime2 = 6.5f;
    public float MoveTime3 = 9.0f;

    //最初の目的地
    public float x = 2.21f;
    public float y = -1.09f;
    public float z = -1.0f;

    //次の目的地
    public float a = 2.21f;
    public float b = 0.8f;
    public float c = 4.5f;

    //最後の目的地
    public float d = 2.21f;
    public float e = -1.09f;
    public float f = -4.04f;

    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
        Invoke("Call", MoveTime);
        Invoke("Call2", MoveTime2);
        Invoke("Call3", MoveTime3);
    }

    void Call()
    {
        isMoving = true;
    }

    void Call2()
    {
        isMoving2 = true;
    }

    void Call3()
    {
        isMoving3 = true;
    }

    // Update is called once per frame

    void Update()
    {
        if (isMoving == false && isMoving2 == false && isMoving3 == false) return;


        if (isMoving == true && isMoving2 == false && isMoving3 == false)
        {
            Vector3 current = transform.position;
            Vector3 target = new Vector3(x, y, z);
            float step = 2.0f * Time.deltaTime;
            transform.position = Vector3.MoveTowards(current, target, Time.deltaTime * 2.0f);
        }

        if (isMoving == true && isMoving2 == true && isMoving3 == false)
        {
            Vector3 current2 = transform.position;
            Vector3 target2 = new Vector3(a, b, c);
            float step2 = 2.0f * Time.deltaTime;
            transform.position = Vector3.MoveTowards(current2, target2, Time.deltaTime * 2.0f);
        }

        if (isMoving == true && isMoving2 == true && isMoving3 == true)
        {
            Vector3 current3 = transform.position;
            Vector3 target3 = new Vector3(d, e, f);
            float step3 = 2.0f * Time.deltaTime;
            transform.position = Vector3.MoveTowards(current3, target3, Time.deltaTime * 2.0f);
        }
    }
}
