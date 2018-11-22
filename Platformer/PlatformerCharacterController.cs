using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerCharacterController : MonoBehaviour {

	[SerializeField]
	private float walkSpeed;

	[SerializeField]
	private float jumpSpeed;

	private void Start () {

	}

	private void Update () {
		//Controle de movimento do personagem
		if(Input.GetKey(KeyCode.D)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(walkSpeed, GetComponent<Rigidbody2D>().velocity.y);
			Flip(false);
		}
		if(Input.GetKey(KeyCode.A)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(-walkSpeed, GetComponent<Rigidbody2D>().velocity.y);
			Flip(true);
		}

		if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, GetComponent<Rigidbody2D>().velocity.y);
		}

		//Controle de pulo do personagem
		if(Input.GetKeyDown(KeyCode.W)){
			GetComponent<Rigidbody2D>().AddForce(transform.up * jumpSpeed);
		}
	}

	//True para esquerda, false para direita
	private void Flip(bool dir){
		GetComponent<SpriteRenderer>().flipX = dir;
	}
}
