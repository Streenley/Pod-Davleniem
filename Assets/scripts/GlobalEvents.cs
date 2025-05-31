using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalEvents : MonoBehaviour
{
    Transform tr;
    [SerializeField]
    AudioSource as_;
    [SerializeField]
    GameObject Bu,Bu2;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tr.position.y < -2000f & as_.volume >= 0) {
            as_.volume -= 0.01f;
        }
        if (as_.volume == 0)
        {
            Bu.SetActive(true);
            Bu2.SetActive(true);
        }
    }
}
