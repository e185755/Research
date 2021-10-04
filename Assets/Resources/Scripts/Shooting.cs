
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Shooting : MonoBehaviour {
 
    public GameObject bulletPrefab;
    public float shotSpeed;
    
    public int FulBullet = 30;
    public int shotCount = 30;
    private float shotInterval;
    RaycastHit hit;
    
    void Start()
    {
        Application.targetFrameRate = 60;
    }
 
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            shotInterval += 1;

            if (shotInterval % 15 == 0 && shotCount > 0)
            {
                shotCount -= 1;

                Physics.Raycast(ray,out hit,10.0f);
                if (hit.tag == Enemy)
                {
                    hit.Destroy.HP -= 50;
                }


                /*
                以下弾丸を射出する場合
                GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.AddForce(transform.forward * shotSpeed);
 
                //射撃されてから3秒後に銃弾のオブジェクトを破壊する.
 
                Destroy(bullet, 3.0f);*/
            }
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            shotCount = FulBullet;
        }
    }
}