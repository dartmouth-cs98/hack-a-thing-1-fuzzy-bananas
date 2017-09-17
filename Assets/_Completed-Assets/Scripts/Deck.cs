using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class Deck : MonoBehaviour {
	private List<int> _deck = new List<int>();
	private List<Card> _onTable = new List<Card>();
	private List<Card> _onHand = new List<Card>();

	private Queue<int> _inDeck = new Queue<int> ();

	// Use this for initialization
	void Start () 
	{
		for (int i = 2; i <= 98; i++) {
			_deck.Add (i);
		}
	}

	void OnMouseDown() 
	{
		Debug.Log("asdfdasf");
		int i = Random.Range (0, _deck.Count - 1);
		int cardRank = _deck [i];
		_deck.RemoveAt (i);
		Vector3 positions = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10.0f); 
		Card card = new Card (cardRank);
		_onTable.Add (card);

	}

//	public Card TakeCard() {
//		if (_deck.Count == 0)
//			return null; // the deck is depleted
//
//		// take the first card off the deck and add it to the discard pile
//		Card card = _deck[0];
//		_deck.RemoveAt(0);
//		_onTable.Add(card);
//
//		return card;
//	}
}
