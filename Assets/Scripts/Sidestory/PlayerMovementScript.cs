using System;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    [Header("Movement Settings")]
    public float baseSpeed = 5f;
    public float speedIncreaseRate = 1.2f;
    public float sideForce = 10f;

    private float _currentSpeed;
    private Rigidbody _rb;
    
    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _currentSpeed = baseSpeed;
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdateSpeed();
        MovePlayer();
    }

    private void UpdateSpeed()
    {
        _currentSpeed += speedIncreaseRate * Time.fixedDeltaTime;
    }
    
    private void MovePlayer()
    {
        Vector3 movement = new Vector3(baseSpeed, 0, 0);
        _rb.linearVelocity = new Vector3(_currentSpeed, _rb.linearVelocity.y, 0f);
        
        float horizontal = Input.GetAxis("Horizontal");
        _rb.AddForce(new Vector3(0, 0, horizontal * -sideForce), ForceMode.Force);
    }
}
