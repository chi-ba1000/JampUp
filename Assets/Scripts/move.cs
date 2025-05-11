using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed = 2.0f; // 移動速度
    public float moveDistance = 5.0f; // 移動する距離
    private Vector3 initialPosition;
    private bool movingForward = true;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // 前後に移動
        if (movingForward)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }

        // 移動距離をチェックし、進行方向を切り替える
        if (Vector3.Distance(initialPosition, transform.position) >= moveDistance)
        {
            movingForward = !movingForward;
        }
    }
}
