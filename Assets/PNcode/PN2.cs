using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PN2 : MonoBehaviour
{
    private bool isMoving = false;
    Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = new Vector3(4.375f,0.795f,0.37f);
        isMoving = false;
        Invoke("Call", 2.5f);
    }

    void Call()
    {
        isMoving = true;
    }



    // Update is called once per frame
    void Update()
    {
        if (isMoving == false) return;
        //座標を書き換える
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime);
    }
}
