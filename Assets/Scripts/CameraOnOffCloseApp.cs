using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOnOffCloseApp : MonoBehaviour
{
    WebCamTexture webcam;
    public void WebcamPlay()
    {
        Debug.Log("Web cab play");
        if (webcam == null)
        {
            Debug.Log("webcam start");
            webcam = new WebCamTexture();
            webcam.Play();
        }
        else
        {
            webcam.Play();
            Debug.Log("not null");
        }
        Debug.Log("play finished");
    }
    public void WebcamStop()
    {
        Debug.Log("stop started");
        if (webcam != null && webcam.isPlaying)
        {
            Debug.Log("webcam not null stop");
            webcam.Stop();
            Destroy(webcam);
            webcam=null;
            Resources.UnloadUnusedAssets();
            System.GC.Collect(0);
        }
        Debug.Log("Stop");
    }

    public void CloseApp()
    {
        GameManager.Instance.QuitApp();
    }
}
