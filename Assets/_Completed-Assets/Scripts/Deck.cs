using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class Deck : MonoBehaviour {
	private List<int> _deck = new List<int>();
	private List<Card> _onTable = new List<Card>();
	public GameObject deck;

	// Use this for initialization
	void Start () 
	{
		for (int i = 2; i <= 98; i++) {
			_deck.Add (i);
		}
	}

	void OnMouseDown() 
	{
		int i = Random.Range (0, _deck.Count - 1);
		int cardRank = _deck [i];
		_deck.RemoveAt (i);

		Debug.Log ("OnMouseDown of Deck.cs called, rank is " + cardRank);

//		Card card = new Card (cardRank);
//		Card card = deck.AddComponent<Card>();
		Card card = getCard(cardRank);
		_onTable.Add (card);
	}

	Card getCard(int _rank) {

		string assetName = string.Format("card_{0}", _rank);  // Example:  "card_2" is card with number 2: 2 to 99
		GameObject cardObj = GameObject.Find(assetName);
		if (cardObj == null) {
			Debug.LogError("Asset '" + assetName + "' could not be found.");
			return null;
		} else {
//			_rank = _rank;
			Debug.Log ("card with rank" + _rank + " was found");
			Card card = cardObj.GetComponent<Card>();
			Debug.Log (card);
			card.makeCardVisible(_rank);
			return card;
		}
	}

}
