using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScale4 : MonoBehaviour
{
    public float MT = 13.0f;
    public float scale = 1.2f;
    public float x = 0.1f;
    public float y = 7.5f;
    public float z = 0.1f;

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

        for (float i = 0.1f; i < scale; i += 0.3f)
        {
            this.transform.localScale = new Vector3(x, y + i, z);
            yield return new WaitForSeconds(0.1f);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
