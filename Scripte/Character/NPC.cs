//This is just supposed to be pseudo code

using UnityEngine;
using System.Collections;
using System;
 
[System.Serializable]
public class NPC { 

  public Transform npc;
	public Transform goal;
	Random rnd = new Random;
	private NavMeshPath path;
	private float elapsed = 0.0f; 

	void start()
	{
		path = new NavMeshPath();
		elapsed = 0.0f;
		NavMeshAgent agent = GetComponent<NavMeshAgent>();
    Move();
	}

	//Either NavMeshPath or just NavMeshAgent.SetDestination
	void Update(){
		elapsed += Time.deltaTime;
		if (elapsed > 1.0f) {
			elapsed -= 1.0f;
			NavMesh.CalculatePath(transform.position, target.position, NavMesh.AllAreas, path);
		}
		for (int i = 0; i < path.corners.Length-1; i++)
			Debug.DrawLine(path.corners[i], path.corners[i+1], Color.red);	
	}

	void Move(){
		SetDestination();
		agent.destination = goal.position; 
	}

	void DestinationReached(){

	}

	void SetDestination(){
		goal.position = new Vector3(rnd.Next()); 
	}

}