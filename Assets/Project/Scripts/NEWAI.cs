using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NEWAI : MonoBehaviour
{

    public LayerMask whatIsPlayer;

    public NavMeshAgent agent;    //宣告NavMeshAgent

    public CharacterController CC;

    public BoxCollider BC;


    public Transform P1;    //目標物件
    public Transform P2;    //目標物件


    public float dist;

    public float dist2;
    public float attackRange;//視野範圍 攻擊範圍

    public bool playerInAttackRange;

    Animator 動畫控制器;
    public void 拿起腳色()
    {
        
        Destroy(this.gameObject);
    }
    public void 扣血()
    {
        BC.enabled = true;

        agent.enabled = false;
        動畫控制器.SetBool("死亡", true);
        動畫控制器.SetBool("攻擊", false);
        SaveData.P1拿起 = true;
        Invoke("AIBack", 2.5f);
    }
    private void Awake()
    {
        P1 = GameObject.FindWithTag("Player").transform;//玩家的位置

        P2 = GameObject.FindWithTag("P2").transform;//玩家的位置
        動畫控制器 = GetComponent<Animator>();

        agent = GetComponent<NavMeshAgent>();//AI位置

        CC = GetComponent<CharacterController>();
    }
    

    void Update()
    {
        if (動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("攻擊")|| 動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("死亡")|| 動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("復活"))
        {
            agent.enabled = false;
            
        }

        動畫控制器.SetBool("走路", true);

        dist = Vector3.Distance(P1.position, transform.position);
        dist2 = Vector3.Distance(P2.position, transform.position);

        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);
        if (dist2 < dist )
        {
            agent.SetDestination(P2.position);    //讓紅方塊往目標物的座標移動
        }
        else
        {
            agent.SetDestination(P1.position);    //讓紅方塊往目標物的座標移動
        }
        if (playerInAttackRange|| playerInAttackRange) 
            AttackPlayer();//攻擊
        if (!playerInAttackRange || !playerInAttackRange)
        {
            agent.enabled = true;
            動畫控制器.SetBool("攻擊", false);
            動畫控制器.SetBool("走路", true);
        }
            

    }
    
    private void AttackPlayer()
    {
        動畫控制器.SetBool("走路", false);
        動畫控制器.SetBool("攻擊", true);
        agent.enabled = false;
    }
    
    
    void AIBack()
    {
        動畫控制器.SetBool("死亡", false);
        SaveData.P1拿起 = false;
    }

    
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        
    }
}
