using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField]
    AudioClip clip1,clip2,clip3,clip4;
    [SerializeField]
    AudioSource player;
    int point = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<AudioSource>();
    }
    public void Changer() {
        player.Stop();
        point = (point + 1) % 4;
       switch (point) {
            case 0 :
                player.clip = clip1;
                break;
            case 1:
                player.clip = clip2;
                break;
            case 2:
                player.clip = clip3;
                break;
            case 3:
                player.clip = clip4;
                break;

        }
        player.Play();
    }
}
