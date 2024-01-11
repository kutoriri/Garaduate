using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LED : MonoBehaviour
{

    private bool isMoving = false;
    private bool isMoving2 = false;

    public float Starttime = 2.0f;
    public float StopTime = 5.0f;

    private Transform _transform;

    // 初期化
    private void Awake()
    {
        // transformに毎回アクセスすると重いので、キャッシュしておく
        _transform = transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
        Invoke("Call", Starttime);
        Invoke("Coll", StopTime);
    }

    void Call()
    {
        isMoving = true;
    }

    void Coll()
    {
        isMoving2 = true;
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");

        if (isMoving == false) return;
        if (isMoving2 == true) return;

        this.gameObject.transform.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        this.gameObject.transform.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);
    }

}
