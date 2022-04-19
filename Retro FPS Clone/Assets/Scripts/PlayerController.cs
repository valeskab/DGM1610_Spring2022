using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody rb;
    private Vector3 moveInput;
    private Vector2 mouseInput;
    public float mouseSensitivity = 1.0f;

    public Camera viewCam;

    public GameObject projectileImpact;
    public int currentAmmo;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Hide and lock coursor
        Cursor.visible = false;
        Cursor. lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); // Getting keyboard input
        Vector3 moveH = transform.right * moveInput.x;
        Vector3 moveV = transform.forward * moveInput.z;
        rb.velocity = (moveH + moveV) * moveSpeed;

        mouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")) * mouseSensitivity;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y - mouseInput.x, transform.rotation.eulerAngles.z );
        
        if(currentAmmo> 0)
        {
            Ray ray = 
        }
    }
}
