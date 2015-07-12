function OnTriggerEnter (other : Collider) {
	//Debug.Log("hola");
	if(other.gameObject.tag == "Player")
		Application.LoadLevel("Scene2");
}