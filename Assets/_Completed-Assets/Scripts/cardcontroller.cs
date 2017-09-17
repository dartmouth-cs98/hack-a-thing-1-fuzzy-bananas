using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class cardcontroller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnMouseDrag()
	{
		Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
		transform.position = Camera.main.ScreenToWorldPoint(newPosition);
	}

}

