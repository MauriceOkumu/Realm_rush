using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
	[SerializeField] List<Waypoint> paths = new List<Waypoint>();
	[SerializeField] float waitTime = 1f;
	void Start()
	{
		StartCoroutine(PrintPath());
	}
	
	IEnumerator PrintPath() 
	{
		foreach(Waypoint waypoint in paths) 
		{
			transform.position = waypoint.transform.position;
			yield return new WaitForSeconds(waitTime);
		}
	}

}
