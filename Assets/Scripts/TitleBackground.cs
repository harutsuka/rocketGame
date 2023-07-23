using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//タイトル画面の背景の動きを制御するスクリプト
public class TitleBackground : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0, -0.003f, 0);
        if (transform.position.y < -4.9f)
        {
            transform.position = new Vector3(0, 4.9f, 0);
        }
    }
}
