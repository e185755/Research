using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Destroy (this.gameObject);
    }
}
