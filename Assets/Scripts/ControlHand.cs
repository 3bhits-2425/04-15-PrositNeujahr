using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlHand : MonoBehaviour
{
    public Transform hand;  
    public float moveSpeed = 2f;  
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        hand.localPosition += move * moveSpeed * Time.deltaTime;
    }
}
