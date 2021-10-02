using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Target : MonoBehaviour
{

    public float counter = 0.0f;
    public float timecount = 0.0f;
    public GameObject TargetPrefab;
    Transform SpawnerTransform;


    void SpawnTarget()
    {
        Vector3 pos = this.gameObject.transform.position;
        GameObject Target = (GameObject)Instantiate(TargetPrefab, pos, Quaternion.identity);
        Destroy(Target, 2.0f);
        //Rigidbody TargetRb = Target.GetComponent<Rigidbody>();
        //Destroy(Target, 8.0f);
    }

    void MoveSpawner()
    {
        Vector3 pos = this.gameObject.transform.position;
        this.gameObject.transform.position = new Vector3(pos.x,pos.y=Random.Range (5.0f, 10.0f),pos.z);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= counter + 3){
            MoveSpawner();
            SpawnTarget();
            counter = Time.time;
        }
        timecount = Time.time;
    }
}
