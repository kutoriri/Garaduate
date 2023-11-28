using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nDestroyDE : MonoBehaviour
{
    public float desTime = 6.4f;

    // Start is called before the first frame update
    void Start()
    {
        //5秒後ゲームオブジェクトを破棄する
        Destroy(gameObject, desTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
