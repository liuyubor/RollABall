using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    private float speed = 1F;
    private int DirectionY = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, DirectionY * speed * Time.deltaTime, 0),Space.World);
        if (transform.position.y >= 0.75)
        {
            DirectionY = -1;
        }
        if (transform.position.y <= 0.3)
        {
            DirectionY = 1;
        }
        
    }
}
