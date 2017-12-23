using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SelectName : MonoBehaviour
{
    public VideoClip[] clips;
    public VideoPlayer player;

    public void Select(int number)
    {
        player.clip = clips[number];
        gameObject.SetActive(false);
    }

}
