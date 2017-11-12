using UnityEngine;
using System.Collections;

public class light : MonoBehaviour
{	
	public int intensity;


	void Start()
	{
		Light mi_luz = GetComponent<Light>();
		mi_luz.color = Color.red;
	}

	// Update is called once per frame
	void Update ()
	{

		GetComponent<Light>().intensity = (float)intensity/10;

		/*
		if(Input.GetKeyDown(KeyCode.Space))
			GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
		*/
	}
}
