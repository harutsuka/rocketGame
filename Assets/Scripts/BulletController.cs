using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//銃弾の動きをコントロールするスクリプト
public class BulletController : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0, 0.2f * Time.timeScale, 0);

        if(transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }
    
}

