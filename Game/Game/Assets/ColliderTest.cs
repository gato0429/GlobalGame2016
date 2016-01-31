using UnityEngine;
using System.Collections;

public class ColliderTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnterCollider(Collision col) 
	{
		Debug.Log (col.gameObject.name);
		Debug.Log ("Entre Nigga");
		Destroy (col.gameObject);
	}

	void OnTriggerEnter(Collider col)
	{
		Debug.Log ("Entre collider");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
