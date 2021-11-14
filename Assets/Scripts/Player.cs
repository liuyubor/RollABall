using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody rd;
    
    public int score;

    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rd.AddForce(new Vector3(5*h,0,5*v));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            Destroy(collision.gameObject);
            score++;
            ScoreText.text = "  分数:" + score;
            if (score == 21)
            {
                ScoreText.text = "  分数:" + score + "   好棒啊！坏蛋都被吃掉惹！";
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Food")
        {
            Destroy(other.gameObject);
            score++;
            ScoreText.text = "  分数:" + score;
            if (score == 21)
            {
                ScoreText.text = "  分数:" + score + "   好棒啊！坏蛋都被吃掉惹！";
            }
        }
    }
}
