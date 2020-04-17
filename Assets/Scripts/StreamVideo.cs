﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using  UnityEngine.Video;

public class StreamVideo : MonoBehaviour
{
    public RawImage rawImage;
    public VideoPlayer videoplayer;
    public AudioSource audioSource;

    private void Start()
    {
        StartCoroutine(PlayVideo()); 
    }

    IEnumerator PlayVideo()
    {
        videoplayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while (!videoplayer.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        rawImage.texture = videoplayer.texture;
        videoplayer.Play();
        audioSource.Play();
    }
}
