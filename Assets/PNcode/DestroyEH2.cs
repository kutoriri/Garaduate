using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEH2 : MonoBehaviour
{
    public float desTime = 6.5f;

    // Start is called before the first frame update
    void Start()
    {
        //6.5秒後ゲームオブジェクトを破棄する
        Destroy(gameObject, desTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
