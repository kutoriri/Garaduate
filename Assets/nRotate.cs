using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nRotate : MonoBehaviour
{

    float speed = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        while (i < 90)
        {
            i++;
            this.transform.Rotate(0, speed, 0);
            yield return null;
        }
        rot = true;
    }
}
