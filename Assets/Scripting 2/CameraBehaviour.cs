using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
	public GameObject mine = null;

	public GameObject tank = null;
	// Use this for initialization
	void Start () {
		if(tank == null)
		{
			GameObject.Find("Tank");
		}
	}
	
	// Update is called once per frame
	void LateUpdate ()
	{
		if (mine != null)
			transform.LookAt(mine.transform);
		else
			transform.LookAt(tank.transform);

	}
}
