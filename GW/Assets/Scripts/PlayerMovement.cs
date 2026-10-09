using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 movement;
    private Rigidbody2D rb;
    private bool isSprinting;
    [SerializeField] private float walkSpeed = 5f;
    [SerializeField] private float runSpeed = 8f;
    private NPCInteraction currentNPC;
    private bool canMove = true;
    
    void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    void OnSprint(InputValue value)
    {
        isSprinting = value.isPressed;
    }

    public void SetCurrentNPC(NPCInteraction npc)
    {
        currentNPC = npc;
    }

    public void ClearCurrentNPC()
    {
        currentNPC = null;
    }

    void OnInteract(InputValue value)
    {
        if (value.isPressed && currentNPC != null)
        {
            currentNPC.Interact();
        }
    }

    public void SetCanMove(bool value)
    {
        canMove = value;

        if (!canMove)
        {
            rb.linearVelocity = Vector2.zero;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Physics-based movement
    void FixedUpdate()
    {
        float currentSpeed;

        if (!canMove)
        {
            return;
        }

        currentSpeed = isSprinting ? runSpeed : walkSpeed;
        rb.linearVelocity = movement.normalized * currentSpeed;
    }
}
