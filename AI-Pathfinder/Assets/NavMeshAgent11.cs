using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgent11 : MonoBehaviour {

    private NavMeshAgent navMeshAgent;
    [SerializeField] private List<Transform> waypoints;

    private int currentWaypointIndex = 0;

    // Start is called before the first frame update
    void Start() {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update() {

        if (waypoints.Count == 0) {
            return;
        }
        float distanceToWaypoint = Vector3.Distance(waypoints[currentWaypointIndex].position, transform.position);

        if (distanceToWaypoint <= 3) {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Count;
        }
        navMeshAgent.SetDestination(waypoints[currentWaypointIndex].position);
    }
}
