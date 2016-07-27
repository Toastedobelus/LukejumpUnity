using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    private Rigidbody2D PlayerRigidBody;
    private Animator PlayerAnimator;
    private SpriteRenderer PlayerSprite;
    public float JumpForce;
    public float MoveSpeed;

	// Use this for initialization
	void Start () {
        PlayerRigidBody = GetComponent<Rigidbody2D>();
        PlayerAnimator = GetComponent<Animator>();
        PlayerSprite = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

        PlayerAnimator.SetBool("Hcheck", false);
        if (Input.GetButtonDown("Jump"))
        {
            PlayerRigidBody.AddForce(transform.up * JumpForce);
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.position += Vector3.left * MoveSpeed * Time.deltaTime;
            PlayerAnimator.SetBool("Hcheck", true);
            PlayerSprite.flipX = false;
        }
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.position += Vector3.right * MoveSpeed * Time.deltaTime;
            PlayerAnimator.SetBool("Hcheck", true);
            PlayerSprite.flipX = true;
        }

        //Animation Checks 
        PlayerAnimator.SetFloat("Vspeed", PlayerRigidBody.velocity.y);

        if (PlayerRigidBody.velocity.y != 0)
        {
            PlayerAnimator.SetBool("Vcheck", true);
        }
        else
        {
            PlayerAnimator.SetBool("Vcheck", false);
        }

    


    }
}
