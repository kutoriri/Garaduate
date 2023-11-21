using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotPN : MonoBehaviour
{
    private bool isMoving = false;
    Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = new Vector3(-0.65f, 2.37f, 0);
        isMoving = false;
        Invoke("Call", 5.5f);
        Invoke("Call2", 9.5f);
    }

    void Call()
    {
        isMoving = true;
    }

    void Call2()
    {
        isMoving = false;
    }



    // Update is called once per frame
    void Update()
    {
        if (isMoving == false) return;
        //座標を書き換える
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime);
    }

}
