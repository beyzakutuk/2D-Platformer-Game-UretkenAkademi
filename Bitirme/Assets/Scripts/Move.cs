using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D rg;
    Vector3 velocity;

    float speed = 5.0f;
    float jumpForce = 5.0f;

    public Animator _animator;

    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        transform.position += velocity * speed * Time.deltaTime;

        _animator.SetFloat("Speed" , Mathf.Abs( Input.GetAxis("Horizontal")));

        if(Input.GetButtonDown("Jump") && !_animator.GetBool("isJumping"))
        {
            rg.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            _animator.SetBool("isJumping", true);
        }

        if(_animator.GetBool("isJumping") && Mathf.Approximately(rg.velocity.y, 0))
        {
            _animator.SetBool("isJumping", false);
        }

        if(Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }

        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }

    private void OnCollisionEnter2D(Collision collision)
    {
        if(collision.gameObject.name == "Ground")
        {
            _animator.SetBool("isJumping", false);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Ground")
        {
            _animator.SetBool("isJumping", true);
        }
    }

}
