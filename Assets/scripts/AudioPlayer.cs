using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField]
    static AudioClip clip1,clip2,clip3,clip4;
    [SerializeField]
    AudioSource player;
    int point = 0;
    public static Dictionary<int, AudioClip> Audio = new Dictionary<int, AudioClip>() {
        {0,clip1},
        {1,clip2},
        {2,clip3},
        {3,clip4}
    };
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<AudioSource>();
    }
    void Changer() {
        point = (point + 1) % 4;
        player.PlayOneShot(Audio[point]);
    }
}
