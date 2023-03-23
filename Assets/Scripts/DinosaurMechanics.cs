using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinosaurMechanics : MonoBehaviour
{
    [SerializeField] private float upForce;
    private Rigidbody2D dinoRb;
    private bool isGrounded;
    public Animator animator;


    
    void Start()
    {
        dinoRb = GetComponent<Rigidbody2D>();   
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) 
        {
            dinoRb.AddForce(Vector2.up * upForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            animator.SetBool("Suelo", true);
            Debug.Log(isGrounded);
        }

        if(other.gameObject.CompareTag("Obstacle"))
        {
            GameManager.Instance.ShowGameOverScreen();
            Time.timeScale = 0f;
            
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            animator.SetBool("Suelo", false);
            Debug.Log(isGrounded + "Segundo");
        }
    }

    
}
