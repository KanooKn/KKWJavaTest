using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class JavaTest : MonoBehaviour
{
    private AndroidJavaClass jc;
    private AndroidJavaObject native;

    bool testbool = true;
    // Start is called before the first frame update
    void Start()
    {
        jc = new AndroidJavaClass("kr.mediascope.audio.hlsplayer.DINGAHLSPlayer");
        Debug.Log(string.Format("jc is {0}null", jc == null ? "" : "not"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
