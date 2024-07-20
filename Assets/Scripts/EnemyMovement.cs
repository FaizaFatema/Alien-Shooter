using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        //speed = horizontalSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boundry")
        {
            
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
            speed *=-1;
        }
    }

}