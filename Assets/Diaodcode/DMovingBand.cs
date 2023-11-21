using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMovingBand : MonoBehaviour
{
    private bool isMoving = false;
    [SerializeField] private float x = 0.0f;
    [SerializeField] private float y = 0.0f;
    [SerializeField] private float z = 0.0f;
    // -0.01f, 4.75f, -2.8f

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
        Vector3 target = new Vector3(x, y, z);
        float step = 2.0f * Time.deltaTime;
        transform.position = Vector3.MoveTowards(current, target, Time.deltaTime * 0.8f);
    }
}
