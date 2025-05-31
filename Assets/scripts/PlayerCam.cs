using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerCam : MonoBehaviour
{
    float xRotation, yRotation;
    
    float dist = 10f;
    RaycastHit hit;
    [SerializeField]
    float sensX, sensY;
    [SerializeField]
    GameObject player;
    Transform pl;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        pl = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        interaction();
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        this.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        pl.transform.rotation = Quaternion.Euler(0, yRotation, 0);

    }
    
    void interaction() { 
        Ray interact = new Ray(this.transform.position, Vector3.forward);
        if (Physics.Raycast(interact, out hit, dist)) {
            if (hit.collider.gameObject.CompareTag("Interactive") && Input.GetAxis("Fire1") == 1) {

            }
        }
    }
}
