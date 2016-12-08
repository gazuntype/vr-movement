using UnityEngine;
using System.Collections;

public class WaypointSpawner : MonoBehaviour {
	NavMeshAgent agent;
	public Transform target;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		agent.SetDestination(target.position);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
