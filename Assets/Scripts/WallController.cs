using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public float moveSpeed = 2f; // 初期移動速度
    public float acceleration = 2f; // 加速度

    void Update()
    {
        moveSpeed += acceleration * Time.deltaTime;

        // 移動の処理
        transform.Translate(Vector3.up * -moveSpeed * Time.deltaTime);

        if (transform.position.y < -20)
        {
           Destroy(gameObject);
        }
    }
   
}
