using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WaypointSpawner : MonoBehaviour {
	public Camera playerCamera;
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
			
			yield return new WaitForSeconds(100);
		}
	}
}
