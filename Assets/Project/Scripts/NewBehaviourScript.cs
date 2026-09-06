using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    float nexttime;

    public NavMeshAgent agent;

    public Transform player;

    public Transform player2;

    public LayerMask whatIsGround, whatIsPlayer;


    public float health;//設定血量

    //Patroling巡邏系統
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //Attacking攻擊系統
    public float timeBetweenAttacks;
    bool alreadyAttacked;
    public GameObject projectile;

    //States狀態
    public float sightRange, attackRange;//視野範圍 攻擊範圍
    public bool playerInSightRange, playerInAttackRange; //視線範圍內的玩家 攻擊範圍內的玩家

    public float dist;

    public float dist2;
    private void Awake()
    {
        player = GameObject.FindWithTag("Player").transform;//玩家的位置



        agent = GetComponent<NavMeshAgent>();//AI位置
    }

    private void Update()
    {
        player = GameObject.FindWithTag("Player").transform;//玩家的位置

        dist = Vector3.Distance(player.position, transform.position);
        


        player2 = GameObject.FindWithTag("P2").transform;//玩家的位置

        dist2 = Vector3.Distance(player2.position, transform.position);
        


        //檢查視線和攻擊範圍
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInSightRange && !playerInAttackRange) Patroling();//巡邏
        if (playerInSightRange && !playerInAttackRange) ChasePlayer();//追逐
        //if (playerInAttackRange && playerInSightRange) AttackPlayer();//攻擊
    }

    private void Patroling()//巡邏
    {
        if (!walkPointSet) 
            SearchWalkPoint();

        if (walkPointSet)
            agent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        //Walkpoint reached
        if (distanceToWalkPoint.magnitude < 1f)
            walkPointSet = false;
    }
    private void SearchWalkPoint()//搜索步行點
    {
        //Calculate random point in range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
            walkPointSet = true;
    }

    private void ChasePlayer()//追逐
    {
        if (dist2 <6)
        {
            agent.SetDestination(player2.position);    //讓紅方塊往目標物的座標移動
        }
        if (dist <6)
        {
            agent.SetDestination(player.position);    //讓紅方塊往目標物的座標移動
        }
        
        
    }

    private void AttackPlayer()//攻擊玩家

    {
        //Make sure enemy doesn't move
        agent.SetDestination(transform.position);

        transform.LookAt(player);

        if (!alreadyAttacked)
        {
            ///Attack code here
            Rigidbody rb = Instantiate(projectile, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            rb.AddForce(transform.up * 8f, ForceMode.Impulse);
            ///End of attack code

            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
    }


    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0) Invoke(nameof(DestroyEnemy), 0.5f);
    }//血量
    private void DestroyEnemy()
    {
        Destroy(gameObject);
    }

    float newtime;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }

    private void OnTriggerStay(Collider col)
    {
        if(col.tag=="P2"&&Time.time>=newtime)
        {
            newtime = Time.time + 2f;
            Debug.Log(Time.time.ToString()+"扣血");
        }
    }
}
