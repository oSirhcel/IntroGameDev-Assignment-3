using UnityEngine;

public class PacStudentMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private float bounds = 0.5f; 
    
    private Vector3 direction = Vector3.right;
    
    void Start()
    {
    }
    
    void Update()
    {
        MovePacStudent();
    }
    
    void MovePacStudent()
    {
        transform.position += direction * speed * Time.deltaTime;
        
 
        if (transform.position.x >= bounds && direction == Vector3.right)
        {
            direction = Vector3.down;
        }
        else if (transform.position.y <= -bounds && direction == Vector3.down)
        {
            direction = Vector3.left;
        }
        else if (transform.position.x <= -bounds && direction == Vector3.left)
        {
            direction = Vector3.up;
        }
        else if (transform.position.y >= bounds && direction == Vector3.up)
        {
            direction = Vector3.right;
        }
    }
}
