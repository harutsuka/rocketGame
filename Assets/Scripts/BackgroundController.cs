using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 背景の表示を制御するスクリプト
public class BackgroundController : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0, -0.1f * Time.timeScale, 0);
        
        if (transform.position.y < -4.9f)
        {
            transform.position = new Vector3(0, 4.9f, 0);
        }
    }
}
