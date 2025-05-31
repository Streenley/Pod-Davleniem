using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Textter : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI Text;
    [SerializeField]
    GameObject box;
    Transform pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = box.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = "Глубина : " + pos.position.y.ToString();
    }
}
