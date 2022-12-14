using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent agent;
    float speed;
    void Start()
    {
        speed = GetComponent<NavMeshAgent>().speed;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }
    void Update()
    {
       
        agent.SetDestination(new Vector3(target.transform.position.x, target.transform.position.y, 0));
    }
}
