using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    public float desTime = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        //4.5秒後にゲームオブジェクトを破棄する
        Destroy(gameObject, desTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
