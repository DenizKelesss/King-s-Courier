using UnityEngine;

public class NPCMovements : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    private Animator animator;
    private Vector3 movement;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Example input for demonstration purposes
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        movement = new Vector3(horizontal, 0, vertical).normalized;

        Move();
        Animate();
    }

    void Move()
    {
        // Move the NPC
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
    }

    void Animate()
    {
        // Update Animator parameters
        if (movement != Vector3.zero)
        {
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.z);
        }
        else
        {
            animator.SetFloat("Horizontal", 0);
            animator.SetFloat("Vertical", 0);
        }
    }
}
