using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{

    public GameObject targetObject;
    GameObject Root;
/*
    void OnCollisionStay(Collider other)
    {
        //接触したオブジェクトのタグが"Player"のとき
        if(other.CompareTag("Player")){
            //ルート親オブジェクトを参照
            Root = transform.root.gameObject ;
            //オブジェクトの色を赤に変更する
            GetComponent<Transform>().rotation = Root.transform.LookAt(targetObject.transform);
        }
    }

*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(targetObject.transform);
    }
}
