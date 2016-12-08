using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WaypointSpawner : MonoBehaviour {
	public Camera playerCamera;
	[Tooltip("The maximum distance you want a waypoint to be created")]
	public float maximumDistance = 10;

	[Tooltip("The minimum distance between two waypoints")]
	public float intervalDistance = 1;

	[Tooltip("The GameObject to use as a waypoint")]
	public GameObject waypointObject;

	NavMeshAgent agent;
	IEnumerator coroutine;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		coroutine = UpdateWayPointCreation();
		StartCoroutine(coroutine);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator UpdateWayPointCreation()
	{
		while (true)
		{
			for (int i = 0; i < maximumDistance; i += (int)intervalDistance)
			{
				NavMeshHit hit;
				Vector3 randomDirection = Quaternion.Euler(0, Random.Range(-30, 30), 0) * transform.forward;
				Vector3 randomPoint = transform.position + (randomDirection * i);
				NavMesh.SamplePosition(randomPoint, out hit, 2, NavMesh.AllAreas);
				Instantiate(waypointObject, hit.position, Quaternion.identity);
			}
			yield return new WaitForSeconds(100);
		}
	}
}
