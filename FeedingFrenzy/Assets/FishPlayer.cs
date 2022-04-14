using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishPlayer : MonoBehaviour
{

    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        // apply forward input
        Vector3 movementHorizontal = Input.GetAxis("Horizontal") * new Vector3(1, 0, 0) * speed;
        Vector3 movementVertical = Input.GetAxis("Vertical") * new Vector3(0, 1, 0) * speed;

        transform.position += movementHorizontal * Time.deltaTime;
        transform.position += movementVertical * Time.deltaTime;

        // GetComponent<Rigidbody2D>().position += velocity * Time.deltaTime;
    }
}
