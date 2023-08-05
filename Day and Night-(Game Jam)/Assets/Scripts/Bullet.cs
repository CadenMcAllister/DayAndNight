using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public ParticleSystem ExplosionObject;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ExplosionObject, transform.position, transform.rotation);
        Destroy(this, 2f);
    }

    
}
