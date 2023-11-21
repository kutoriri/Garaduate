using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBand2 : MonoBehaviour
{
    private bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
        Invoke("Call", 5);
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
        Vector3 target = new Vector3(-0.01f, 3.6f, 3.72f);
        float step = 2.0f * Time.deltaTime;
        transform.position = Vector3.MoveTowards(current, target, Time.deltaTime*0.8f);
    }
}
