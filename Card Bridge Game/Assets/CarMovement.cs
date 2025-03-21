using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 5f;
    public float rotateSpeed = 50f;

    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {   

        if (Input.GetMouseButtonDown(0)) 
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
            //Vector2 direction = target - transform.position;

            //if(direction != Vector2.zero)
            //{
            //    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            //    transform.rotation = Quaternion.Euler(0, 0, angle - 90); // Adjust to align with 'up' direction
            //}
        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed *Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Object1"))
        {
            Destroy(this.gameObject);
        }
    }
}