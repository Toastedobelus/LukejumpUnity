using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    private Rigidbody2D PlayerRigidBody;
    public float JumpForce = 250f;

	// Use this for initialization
	void Start () {
        PlayerRigidBody = GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonUp("Jump"))
        {
            PlayerRigidBody.AddForce(transform.up * JumpForce);
        }
	
	}
}
