using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    public Animator pacStudentAnimator;
    private Vector2 moveInput;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        UpdateDirection();
    }

    void UpdateDirection()
    {
        // Horizontal movement
        if (Mathf.Abs(moveInput.x) > Mathf.Abs(moveInput.y))
        {
            pacStudentAnimator.SetFloat("MoveDirection", 1f); // Moving horizontally
            spriteRenderer.flipX = moveInput.x < 0; // Flip sprite when moving left
        }
        // Vertical movement
        else
        {
            pacStudentAnimator.SetFloat("MoveDirection", 2f); // Moving vertically
            spriteRenderer.flipY = moveInput.y < 0; // Flip sprite when moving down
        }
    }
}
