using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    void Update()
    {
        //銃弾の動き
        transform.Translate(0, 0.2f * Time.timeScale, 0);

        if(transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }
    
}

