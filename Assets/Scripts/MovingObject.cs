using System.Collections;
using UnityEngine;

public abstract class MovingObject : MonoBehaviour {

	public float moveTime = 2.0f;
	//public LayerMask blockingLayer;

	private BoxCollider2D boxCollider;
	private Rigidbody2D rb2D;


	// Use this for initialization
	protected virtual void Start () 
	{
		boxCollider = GetComponent<BoxCollider2D>();
		rb2D = GetComponent<Rigidbody2D> ();
	}

	protected void Move (int xDir, int yDir, bool stopped)
	{
		if (!stopped) {
			rb2D.MovePosition(rb2D.position + Vector2.up * moveTime);
		}
	}

}