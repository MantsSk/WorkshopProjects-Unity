using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFish : MonoBehaviour
{
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        float sizeOfFish = Random.Range(0.1f, 2f);
        transform.localScale = new Vector3(sizeOfFish, sizeOfFish, sizeOfFish);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }



    void Movement()
    {
        Vector3 movement = new Vector3(1, 0, 0) * speed;

        transform.position += movement * Time.deltaTime;
    }
}
