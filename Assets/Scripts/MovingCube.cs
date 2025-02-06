using UnityEngine;

public class MovingCube : MonoBehaviour
{
    public float speed = 0.25f; // Slower speed
    private bool isMoving = true;
    private Vector3 moveDirection;

    void Start()
    {
        // Set a random direction for the cube to move in
        moveDirection = new Vector3(
            Random.Range(-1.0f, 1.0f),
            0.0f,
            Random.Range(-1.0f, 1.0f)
        ).normalized;
    }

    void Update()
    {
        if (isMoving)
        {
            transform.Translate(moveDirection * speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger with Player detected!");
            isMoving = false;
        }
    }
}