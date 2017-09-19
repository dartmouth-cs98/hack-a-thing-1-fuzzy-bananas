using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Card : MonoBehaviour {

	private int _rank;
	public int Rank { get { return _rank; } }

	private GameObject _card;
	private Deck deck;

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
		deck = GameObject.Find("Deck").GetComponent<Deck>();

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

			int numOnHand = deck.numOnHand();
			int xPos = numOnHand * 50 + 150;
//			int yPos = 365 - numOnHand * 80;

			Vector3 newPosition = new Vector3(xPos, 40, 10.0f);
//			Vector3 newPosition = new Vector3(300, yPos, 10.0f);
			transform.position = Camera.main.ScreenToWorldPoint(newPosition);

		}
	}

	void OnMouseDrag()
	{
//		Debug.Log ("mouse position is " + Input.mousePosition.x + " and " + Input.mousePosition.y);
		Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
		transform.position = Camera.main.ScreenToWorldPoint(newPosition);
	}

	void OnMouseUp()
	{
		// Move from hand to row 4
		if (transform.position.y > -14.89 && transform.position.y <= -7.16)
		{
			Debug.Log ("moved to row 4");
			transform.position = new Vector3 (transform.position.x, -9f, transform.position.z);
			deck.moveHandToRow (this, 4);
		} else if (transform.position.y > -7.16 && transform.position.y <= 0.572) {
			Debug.Log ("moved to row 3");
			transform.position = new Vector3 (transform.position.x, -1.2f, transform.position.z);
			deck.moveHandToRow (this, 3);
		} else if (transform.position.y > 0.572 && transform.position.y <= 8.3) {
			Debug.Log ("moved to row 2");
			transform.position = new Vector3 (transform.position.x, 6.6f, transform.position.z);
			deck.moveHandToRow (this, 2);
		} else if (transform.position.y > 8.3) {
			Debug.Log ("moved to row 1");
			transform.position = new Vector3 (transform.position.x, 14.4f, transform.position.z);
			deck.moveHandToRow (this, 1);
		}
	}
}
