using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy2 : MonoBehaviour
{
    public float desTime = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        //6秒後にゲームオブジェクトを破棄する
        Destroy(gameObject, desTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
