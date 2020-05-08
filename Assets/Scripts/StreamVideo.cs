using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using  UnityEngine.Video;

public class StreamVideo : MonoBehaviour
{
    public RawImage rawImage;
    public VideoPlayer videoplayer;
    public AudioSource audioSource;
    public GameObject textWait;
    /*
private void Awake()
    {
        StartCoroutine(PlayVideo());
    }
    */
    private void Start()
    {
        StartCoroutine(PlayVideo());
        audioSource.Play();
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
        Destroy(textWait);
        videoplayer.Play();
        
    }

}
