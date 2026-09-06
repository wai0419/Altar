using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class 敵人控制 : MonoBehaviour
{
    public LayerMask whatIsPlayer;

    public NavMeshAgent agent;    //宣告NavMeshAgent

    public BoxCollider BC;

    public CharacterController CC;

    public float dist;

    public float dist2;

    public float attackRange;//視野範圍 攻擊範圍

    public bool playerInAttackRange;

    Animator 動畫控制器;

    public bool 死亡;

    public ParticleSystem 攻擊特效;

    public GameObject 武器;
    public void 拿起腳色()
    {
        Destroy(this.gameObject);
    }

    private void Start()
    {
        攻擊特效.Stop();
    }
    public void 扣血()
    {
        
            攻擊特效.Play();
            BC.enabled = true;
            CC.enabled = false;
            agent.enabled = false;
            動畫控制器.SetBool("死亡", true);
            動畫控制器.SetBool("攻擊", false);
            SaveData.P1拿起 = true;
            武器.SetActive(false);
            死亡 = true;
            Invoke("AIBack", 6f);
        

    }
    public void 扣血2()
    {
        if (SaveData.P2攻擊中 == true)
        {
            攻擊特效.Play();
            BC.enabled = true;
            CC.enabled = false;
            agent.enabled = false;
            動畫控制器.SetBool("死亡", true);
            動畫控制器.SetBool("攻擊", false);
            SaveData.P2拿起 = true;

            武器.SetActive(false);
            死亡 = true;
            Invoke("AIBack", 6f);
        }

    }
    private void Awake()
    {
        動畫控制器 = GetComponent<Animator>();

        agent = GetComponent<NavMeshAgent>();//AI位置
    }


    void Update()
    {
        if (動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("正在倒下"))
        {
            動畫控制器.SetBool("死亡", false);

        }
        if (動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("攻擊") || 動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("死亡") || 動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("復活") || 動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("正在倒下"))
        {
            
            動畫控制器.SetBool("攻擊", false);
            //BC.enabled = false;
            agent.enabled = false;//關閉會導致78行找不到

        }

        動畫控制器.SetBool("走路", true);

        if(GameObject.FindWithTag("Player")==true)
        {
            dist = Vector3.Distance(GameObject.FindWithTag("Player").transform.position, transform.position);
        }
        if (GameObject.FindWithTag("P2") == true)
        {
            dist2 = Vector3.Distance(GameObject.FindWithTag("P2").transform.position, transform.position);
        }
        

        if (SaveData.暫停 == true)
        {
            agent.speed = 0;
        }

        if (SaveData.暫停 == false)
        {
            agent.speed = 1.5f;
        }
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);
        if (GameObject.FindWithTag("Player") == true && GameObject.FindWithTag("P2") == true)
        {
            if (dist2 < dist)
            {
                agent.SetDestination(GameObject.FindWithTag("P2").transform.position);    //讓紅方塊往目標物的座標移動
                if (動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("死亡") || 動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("復活"))
                {
                    transform.LookAt(this.gameObject.transform);
                }
                else
                    transform.LookAt(GameObject.FindWithTag("P2").transform);
            }
            else
            {
                agent.SetDestination(GameObject.FindWithTag("Player").transform.position);    //讓紅方塊往目標物的座標移動

                if (動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("死亡") || 動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("復活"))
                {
                    transform.LookAt(this.gameObject.transform);
                }
                else
                    transform.LookAt(GameObject.FindWithTag("Player").transform);
            }
        }


        if (GameObject.FindWithTag("P2") == false)
        {
            動畫控制器.SetBool("攻擊", false);
            agent.SetDestination(GameObject.FindWithTag("Player").transform.position);    //讓紅方塊往目標物的座標移動

            if (動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("死亡") || 動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("復活"))
            {
                transform.LookAt(this.gameObject.transform);
            }
            else
                transform.LookAt(GameObject.FindWithTag("Player").transform);
        }

        if (GameObject.FindWithTag("Player") == false)
        {
            動畫控制器.SetBool("攻擊", false);
            agent.SetDestination(GameObject.FindWithTag("P2").transform.position);    //讓紅方塊往目標物的座標移動

            if (動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("死亡") || 動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("復活"))
            {
                transform.LookAt(this.gameObject.transform);
            }
            else
                transform.LookAt(GameObject.FindWithTag("P2").transform);
        }

        if (playerInAttackRange || playerInAttackRange)
            AttackPlayer();//攻擊
        if ((!playerInAttackRange || !playerInAttackRange) && (GameObject.FindWithTag("P2") == true || GameObject.FindWithTag("Player") == true ))
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

    }


    void AIBack()
    {
        武器.SetActive(true);
        BC.enabled = false;
        死亡 = false;
        動畫控制器.SetBool("死亡", false);
        SaveData.P1拿起 = false;
        Invoke("碰撞器消除", 3.6f);
    }
    void 碰撞器消除()
    {
        BC.enabled = false;
        CC.enabled = true;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);

    }
}
