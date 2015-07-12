using UnityEngine;
using System.Collections;

public class ChangeLevel2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("hubo colision");
		if (other.gameObject.tag == "Player") {
			Application.LoadLevel("Scene2");
			//Destroy(gameObject);    
		}
			
	}
}
