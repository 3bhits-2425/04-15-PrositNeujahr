
using UnityEngine;

public class ControlHand : MonoBehaviour
{
    public Transform hand; 
    public Camera playerCamera;  
    public Vector3 handOffset = new Vector3(0f, 120f, -10f);  
    public float mouseSensitivity = 100f;  
    private float xRotation = 0f; 
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
       
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        playerCamera.transform.Rotate(Vector3.up * mouseX);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); 
        playerCamera.transform.localRotation = Quaternion.Euler(xRotation, playerCamera.transform.localRotation.eulerAngles.y, 0f);

        hand.position = handOffset + playerCamera.transform.position;

        hand.rotation = playerCamera.transform.rotation * Quaternion.Euler(0f, 180f, 0f);  
    }
}
