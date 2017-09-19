using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Card : MonoBehaviour {

	private int _rank;
	public int Rank { get { return _rank; } }

	private GameObject _card;

	void Start () 
	{
		transform.position = new Vector3(0, 0, 0);
	}

//	public Card(int rank) {
//		Debug.Log ("making new card of rank " + rank);
//		string assetName = string.Format("card_{0}", rank);  // Example:  "card_2" is card with number 2: 2 to 99
//		GameObject asset = GameObject.Find(assetName);
//		if (asset == null) {
//			Debug.LogError("Asset '" + assetName + "' could not be found.");
//		} else {
//			_rank = rank;
//			Debug.Log ("card with rank" + rank + " was found");
//			makeCardVisible (asset);
//		}
//	}

	public void makeCardVisible(int _rank)
	{
//		GO.layer = LayerMask.NameToLayer ("player");
		string assetName = string.Format("card_{0}", _rank);  // Example:  "card_2" is card with number 2: 2 to 99
		_card = GameObject.Find(assetName);
		if (_card == null) {
			Debug.LogError("Asset '" + assetName + "' could not be found.");
		} else {
//			_rank = _rank;
			Debug.Log("making card visible :)");
//			_card.layer = 31;
			SpriteRenderer sprite = _card.GetComponent<SpriteRenderer>();
			sprite.sortingOrder = 0;
			sprite.sortingLayerName = "Player";

			Vector3 newPosition = new Vector3(100, 100, 10.0f);
			transform.position = Camera.main.ScreenToWorldPoint(newPosition);

		}
	}

	void OnMouseDrag()
	{
		Debug.Log ("mouse position is " + Input.mousePosition.x + " and " + Input.mousePosition.y);
		Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
		transform.position = Camera.main.ScreenToWorldPoint(newPosition);
	}
}
