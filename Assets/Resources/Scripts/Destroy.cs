using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject God;
    private Spowner script;
    public int HP = 100;
    public int DM = 50; //ダメージ

    void Start()
    {  
        script = God.GetComponent<Spowner>(); //スクリプト取得
    }
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            HP -= DM;
        }
        if (HP <= 0)
        {
            Debug.Log("Chenge!");
            script.GoSing = 1; //取得したスクリプトの変数の値を変更
            Destroy (this.gameObject);
        }
    }

}
