using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float runSpeed = 10f;

    Vector2 moveInput;
    Rigidbody2D myRigidbody;
    Animator myAnimator;
    CapsuleCollider2D myBodyCollider;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myBodyCollider = GetComponent<CapsuleCollider2D>();
    }

    void Update()
    {
        Run();
        Animate();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
    void Run()
    {
        Vector2 playerVelocity = new Vector2(moveInput.x * runSpeed, moveInput.y * runSpeed);
        myRigidbody.velocity = playerVelocity;
        bool playerHasHorizontalSpeed = Mathf.Abs(myRigidbody.velocity.x) > Mathf.Epsilon;
        myAnimator.SetBool("isRunning", playerHasHorizontalSpeed);
    }
 
       void Animate()
    {
        myAnimator.SetFloat("AnimMoveX", moveInput.x);
        myAnimator.SetFloat("AnimMoveY", moveInput.y);
        myAnimator.SetFloat("AnimMoveMagnitude", moveInput.magnitude);
    }
   
}
