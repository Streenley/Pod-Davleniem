using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    float xRotation, yRotation, inp_mousex, inp_mousey;
    float moveX, moveZ;
    Vector3 moveDirection;
    public GameObject cam;
    Rigidbody rb;
    float dist = 10f;
    RaycastHit hit;
    [SerializeField]
    float sensX, sensY;
    [SerializeField]
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        interaction();
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX ;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY ;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");


        cam.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        this.gameObject.transform.rotation = Quaternion.Euler(0, yRotation, 0);
        moveDirection = this.transform.forward*moveZ + this.transform.right*moveX;
        if (moveDirection.magnitude !=0) {
            rb.velocity = moveDirection.normalized * speed * Time.deltaTime * 100;
        }
        else
        {
            rb.velocity = Vector3.zero;
        }

    }
    void interaction() { 
        Ray interact = new Ray(cam.transform.position, Vector3.forward);
        if (Physics.Raycast(interact, out hit, dist)) {
            if (hit.collider.gameObject.CompareTag("Interactive") && Input.GetAxis("Fire1") == 1) { 
                
            }
        }
    }
}
