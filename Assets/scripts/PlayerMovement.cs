using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    float moveX, moveZ;
    Rigidbody rb;
    Vector3 moveDirection;
    Vector3 generalMove;
    public GameObject cam;
    Transform Ctransform;
    Transform tr;
    [SerializeField]
    float speed,shift, mxSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Ctransform = cam.GetComponent<Transform>();
        tr = this.GetComponent<Transform>();


    }
    private void FixedUpdate()
    {
        Ctransform.position = new Vector3(tr.position.x, tr.position.y + shift, tr.position.z);
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");
        moveDirection = this.transform.forward * moveZ + this.transform.right * moveX;
        generalMove = moveDirection.normalized * speed * Time.fixedDeltaTime;
        if (generalMove.magnitude >= mxSpeed)
        {
            rb.velocity = generalMove;
        }
        else
        {
            rb.AddForce(generalMove);
        }

    }
}
