using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 2f;
    private float minY; // Minimum Y position where enemy will stop

    void Update()
    {
        MoveDown();
    }

    public void SetMovementBounds(float minBoundary)
    {
        minY = minBoundary;
    }

    void MoveDown()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // Check if enemy is below minY boundary, destroy if true
        if (transform.position.y <= minY)
        {
            Destroy(gameObject);
        }
    }
}