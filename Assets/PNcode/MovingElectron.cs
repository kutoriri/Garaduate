using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingElectron : MonoBehaviour
{
    private float time;
    private float vecX;
    private float vecY;
    private float vecZ;

    void Update()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            vecX = Random.Range(-4.0f, 4.0f);
            vecY = Random.Range(0f, 1.15f);
            vecZ = Random.Range(-2.5f, -3.2f);
            this.transform.position = new Vector3(vecX, vecY, vecZ);
            time = 0.5f;
        }
    }
}
