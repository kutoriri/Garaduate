using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobjectScale : MonoBehaviour
{
    public float MT = 4.0f;
    public float scale = 3.0f;
    public float x = 6.0f;
    public float y = 6.0f;
    public float z = 0.2f;

    //private bool isMoving = false;

    void Start()
    {
        Invoke("Call", MT);
        //StartCoroutine("ScaleUp");
    }

    void Call()
    {
        StartCoroutine("ScaleUp");
    }

    IEnumerator ScaleUp()
    {
        //if (isMoving == false) return;

        for (float i = 0.1f; i < scale; i += 0.05f)
        {
            this.transform.localScale = new Vector3(x, y - i, z);
            yield return new WaitForSeconds(0.1f);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
