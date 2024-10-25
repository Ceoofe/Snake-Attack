using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private int speed = 8;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "GoodTag")
        {
            Destroy(collision.gameObject);
            score = score + 1;
            Debug.Log("Score = " + score);
        }
        else if(collision.gameObject.tag == "BadTag")
        {
            Destroy(collision.gameObject);
            score = 0;
            Debug.Log("You lost all of your points!");
            Debug.Log("Score = " + score);
        }
    }
}
