using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class Deck : MonoBehaviour {
	private List<int> _deck = new List<int>();
	private List<Card> _onRow1 = new List<Card>();	// Descending 1
	private List<Card> _onRow2 = new List<Card>();	// Descending 2
	private List<Card> _onRow3 = new List<Card>();	// Ascending 3
	private List<Card> _onRow4 = new List<Card>();	// Ascending 4
	private List<Card> _onHand = new List<Card>();
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
		if (_onHand.Count >= 8) {
			//display
			Debug.Log("table count is 8, can't draw from deck");
		} else {
			int i = Random.Range (0, _deck.Count - 1);
			int cardRank = _deck [i];
			_deck.RemoveAt (i);

			Debug.Log ("OnMouseDown of Deck.cs called, rank is " + cardRank);

//		Card card = new Card (cardRank);
//		Card card = deck.AddComponent<Card>();
			Card card = getCard (cardRank);
			_onHand.Add (card);
		}
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

	public void moveHandToRow (Card card, int row) {
		Debug.Log ("moved card " + card + " to row " + row);
		_onHand.Remove (card);
		if (row == 1) {
			_onRow1.Add (card);
		} else if (row == 2) {
			_onRow2.Add (card);
		} else if (row == 3) {
			_onRow3.Add (card);
		} else if (row == 4) {
			_onRow4.Add (card);
		}
	}

	public int numOnHand()
	{
		return _onHand.Count;
	}

//	public List<Card> getOnTable()
//	{
//		return _onTable;
//	}

}
