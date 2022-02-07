using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _horizontalInput;
    private float _moveSpeed = 20.0f;
    private float _xRange = 20;
    public GameObject ProjecTilePrefab;
    public Transform ProjecTilePos;

    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        MoveBoundryes();
        ShootFood();
    }

    void MoveBoundryes()
    {
        // Check for left and right bounds
        if (transform.position.x < -_xRange)
        {
            transform.position = new Vector3(-_xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > _xRange)
        {
            transform.position = new Vector3(_xRange, transform.position.y, transform.position.z);
        }
    }
    void PlayerMovement()
    {
        // Player movement left to right
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * _moveSpeed * _horizontalInput);
    }

    void ShootFood()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ProjecTilePrefab, ProjecTilePos.transform.position, ProjecTilePrefab.transform.rotation);
        }
    }
}
