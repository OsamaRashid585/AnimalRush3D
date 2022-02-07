using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    private float _moveSpeed = 30f;
    private void Start()
    {
        
    }
    void Update()
    {
        Movement(_moveSpeed);
    }

    private void Movement(float speed)
   {
       transform.Translate(Vector3.forward * speed * Time.deltaTime);
   }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("OFFSETDESTORY"))
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Animal"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject.gameObject);
            GameManager.Instance._score += 1;
        }
    }
    

}
