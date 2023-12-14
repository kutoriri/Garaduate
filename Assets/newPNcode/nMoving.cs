using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nMoving : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 initialPosition;

    Vector3 startPos;
    public float speed = 1.0f;

    void Start()
    {
        startPos = transform.position;
        InvokeRepeating("Moving", 0f, 1.0f);
    }

    void Moving()
    {
        float sin = Mathf.Sin(Time.time * speed) + startPos.y; //ゲーム開始からの経過時間を1～-1に変換
        transform.position = new Vector3(startPos.x, sin, startPos.z);
    }

    void Update()
    {

    }
}

