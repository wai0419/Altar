using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 大蒜 : MonoBehaviour
{
    public float attackRange;//視野範圍 攻擊範圍

    public bool playerInAttackRange;

    public LayerMask whatIsPlayer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (playerInAttackRange || playerInAttackRange)
            Debug.Log("0000000000000");
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);

    }
}
