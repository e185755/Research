using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spowner : MonoBehaviour
{
    private int ChooseSpown; //スポーン選択（１～４の数字に割り振る）
    public GameObject Spowner1; //スポーン位置
    public GameObject Spowner2;
    public GameObject Spowner3;
    public GameObject Spowner4;
    public GameObject Chara; //スポーンさせるキャラクター
    private List<int> SpownNmber = new List<int>() { 1, 2, 3, 4 }; //全てのスポーンの選択肢
    internal int GoSing = 0;//スポーンのタイミング
    private float countTime = 0;//
    private GameObject enemy; 
    private Destroy enemyScript;
    private AIOperation AIScript;
    private NavMeshAgent StartNavMeshAgent; // NavMeshAgent
    private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        // NavMeshAgentコンポーネントを取得
        StartNavMeshAgent = GetComponent<NavMeshAgent>();

    }

    void Update()
    {
        Spown();
    }

    internal static T GetRandom<T> (params T [] Params)
    {
        return Params[Random.Range (0, Params.Length)];
    }
   
     void Spown()
    {
        if (GoSing == 1)
        {
            Debug.Log("Chenge!");
            countTime += Time.deltaTime;
            //GetRandom (SpownNmber)
            ChooseSpown = Random.Range(1, 5);;
            Player = GameObject.Find("FPSController");
            if(countTime >= 3)
            {
                countTime = 0;
                switch(ChooseSpown)
                {
                    case 1:
                        enemy = Instantiate (Chara, Spowner1.transform.position, Spowner1.transform.rotation);
                        break;
                    case 2:
                        enemy = Instantiate (Chara, Spowner2.transform.position, Spowner2.transform.rotation);
                        break;
                    case 3:
                        enemy = Instantiate (Chara, Spowner3.transform.position, Spowner3.transform.rotation);
                        break;
                    case 4:
                        enemy = Instantiate (Chara, Spowner4.transform.position, Spowner4.transform.rotation);
                        break;
                }
            enemyScript = enemy.GetComponent<Destroy>();
            enemyScript.God = this.gameObject;
            AIScript = enemy.GetComponent<AIOperation>();
            AIScript.m_navMeshAgent = StartNavMeshAgent;
            AIScript.TargetObject = Player;
            GoSing = 0;
            }
        }
    }
}
