using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //銃弾の動き
        transform.Translate(0, 0.2f, 0);

        if(transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }
    
}

