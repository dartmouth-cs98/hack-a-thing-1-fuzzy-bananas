using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class Deck : MonoBehaviour {
	private List<int> _deck = new List<int>();
	private List<Card> _onTable = new List<Card>();

	// Use this for initialization
	void Start () 
	{
		for (int i = 2; i <= 98; i++) {
			_deck.Add (i);
		}
	}

	void OnMouseDown() 
	{
		Debug.Log ("saowiaejfawijg");
		int i = Random.Range (0, _deck.Count - 1);
		int cardRank = _deck [i];
		_deck.RemoveAt (i);

		Card card = new Card (cardRank);
		_onTable.Add (card);
	}

}
