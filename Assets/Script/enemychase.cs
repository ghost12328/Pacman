using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemychase : MonoBehaviour
{
 public Transform player;
    private NavMeshAgent agent;
    public float rotationSpeed = 5f;

    private bool isFrozen = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
    }

    void Update()
    {
        if (!isFrozen && agent.isOnNavMesh && player != null)
        {
            agent.SetDestination(player.position);
            RotateTowards(player.position);
        }
    }

    public void Freeze(bool freeze)
    {
        isFrozen = freeze;
        agent.isStopped = freeze; // Stop the NavMeshAgent from moving when frozen
    }

    void RotateTowards(Vector3 targetPosition)
    {
        Vector3 direction = (targetPosition - transform.position).normalized;
        direction.y = 0;

        Quaternion lookRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player collided with the frozen enemy
        if (isFrozen && other.CompareTag("Player"))
        {
            Destroy(gameObject); // Destroy the enemy if it is frozen and the player touches it
        }
    }
}
