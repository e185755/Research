using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIOperation : MonoBehaviour
{
    public GameObject TargetObject; /// 目標位置
    internal NavMeshAgent m_navMeshAgent; // NavMeshAgent
    private float shotInterval; //射撃間隔
    public float shotSpeed;　
    [SerializeField]
    private float searchAngle = 130f; //発見できる角度
    public GameObject Target;



    void Start () {
        // NavMeshAgentコンポーネントを取得
        m_navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update () {
        // NavMeshが準備できているなら
        if(m_navMeshAgent.pathStatus != NavMeshPathStatus.PathInvalid) {
            // NavMeshAgentに目的地をセット
            m_navMeshAgent.SetDestination(TargetObject.transform.position);
        }
    }
}