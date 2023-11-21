using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingHole : MonoBehaviour
{

    private float time;
    private float vecX;
    private float vecY;
    private float vecZ;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            vecX = Random.Range(-4.0f, 4.0f);
            vecY = Random.Range(0.43f, 1.15f);
            vecZ = Random.Range(3.5f, 4f);
            this.transform.position = new Vector3(vecX, vecY, vecZ);
            time = 0.5f;
        }

    }
}
