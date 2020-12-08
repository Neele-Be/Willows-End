using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;

    public GameObject interactIcon;
    private Vector2 boxSize = new Vector2(1f, 1f);

    private Vector2 movement;
    
    //Transitions
    public VectorValue startingPosition;


    // Start

   void Start()
    {
        interactIcon.SetActive(false);

        transform.position = startingPosition.initialValue;
    }


    // Update is called once per frame
    void Update()
    {
        // Input movement
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        // Input Interaction

        if (Input.GetKeyDown(KeyCode.E))
            CheckInteractIcon();

        
    }


    private void FixedUpdate()
    {
        // Movement - hier, weil nicht abhängig von der Framerate

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    // Interaktion mit Objekten

    public void OpenInteractableIcon()
    {
        interactIcon.SetActive(true);
    }

    public void CloseInteractableIcon()
    {
        interactIcon.SetActive(false);
    }

    private void CheckInteractIcon()
    {
        RaycastHit2D[] hits = Physics2D.BoxCastAll(transform.position, boxSize, 0, Vector2.zero);

        if (hits.Length > 0)
        {
            foreach (RaycastHit2D rc in hits)
            {
                if (rc.transform.GetComponent<Interactable>())
                {
                    rc.transform.GetComponent<Interactable>().Interact();
                    return;
                }
            }
        }
    }
}
