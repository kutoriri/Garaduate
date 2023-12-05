using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nRotation : MonoBehaviour
{
    private bool isMoving = false;
    private bool isMoving2 = false;

    public float RotateTime = 6.4f;
    public float StopTime = 9.5f;

    // 角速度
    [SerializeField] private float _angleSpeed = 90;

    // 回転軸
    [SerializeField] private Vector3 _axis = Vector3.forward;

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
        Invoke("Call", RotateTime);
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
        if (isMoving == false) return;
        if (isMoving2 == true) return;
        // １フレームで回転する角度を角速度から計算
        var angle = _angleSpeed * Time.deltaTime;

        // 既存のrotationに軸回転のクォータニオンを掛ける
        // クォータニオンを掛ける順序に注意
        _transform.rotation = Quaternion.AngleAxis(angle, _axis) * _transform.rotation;
    }
}
