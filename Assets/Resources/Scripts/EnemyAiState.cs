using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EnemyAiState
{
/*
  WAIT,            //行動を一旦停止
  MOVE,            //移動
  ATTACK,        //停止して攻撃
  MOVEANDATTACK,    //移動しながら攻撃
  IDLE,            //待機
  AVOID,        //回避
}
public EnemyAiState aiState = EnemyAiState.WAIT;

protected void SetAi()
{
  if (isAiStateRunning)
  {
    return;
  }
  AiMainRoutine();
  aiState = nextState;
  StartCoroutine("AiTimer");
}

protected override void AiMainRoutine()
{
  if (wait)
  {
    nextState = EnemyAiState.WAIT;
    wait = false;
    return;
  }
  if (enemyCanShoot && isChasing && distance < Mathf.Pow(shootDistance, 2))
  {
    nextState = EnemyAiState.MOVEANDATTACK;
  }
  else
  {
    nextState = EnemyAiState.MOVE;
  }
*/
}
