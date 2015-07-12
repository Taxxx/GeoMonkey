using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public float speed = 0.1f;
	void Update () {
		if(Input.GetKey(KeyCode.RightArrow))
		{
			this.transform.Translate(Vector3.right * speed);
			//transform.position = new Vector3(speed * Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			this.transform.Translate(Vector3.left * speed);
			//transform.position = new Vector3(speed * Time.deltaTime,0,0);
		}
//		if(Input.GetKey(KeyCode.DownArrow))
//		{
//			this.transform.Translate(Vector3.down * speed);
//			//transform.position = new Vector3(0,speed * Time.deltaTime,0);
//		}
//		if(Input.GetKey(KeyCode.UpArrow))
//		{
//			this.transform.Translate(Vector3.up * speed);
//			//transform.position = new Vector3(0,speed * Time.deltaTime,0);
//		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			this.transform.Translate(Vector3.back * speed);
			//transform.position = new Vector3(0,speed * Time.deltaTime,0);
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			this.transform.Translate(Vector3.forward * speed);
			//transform.position = new Vector3(0,speed * Time.deltaTime,0);
		}
	}
}
