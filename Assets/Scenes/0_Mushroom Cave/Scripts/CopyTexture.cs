using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyTexture : MonoBehaviour
{

    public Texture srcTexture;
    public Texture dstTexture;  // The destination texture needs to be the same
                                // pixel size, mip count (Enable MipMaps), texture format group as the source texture.

    public OVROverlay _overlay;

    public Texture _overlayDestination;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("_Overlay Format: " + _overlay.textures[0].graphicsFormat);
        Debug.Log("_OverlayDestination Format: " + _overlayDestination.graphicsFormat);
        Debug.Log("_Source Format: " + srcTexture.graphicsFormat);
        Debug.Log("_Destination Format: " + dstTexture.graphicsFormat);
        
        //_overlay.OverrideOverlayTextureInfo(srcTexture,  = srcTexture.graphicsFormat;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("_Overlay Format: " + _overlay.textures[0].graphicsFormat);
        Graphics.CopyTexture(_overlay.textures[0], _overlayDestination);
       // _overlayDestination.IncrementUpdateCount();
       //Debug.Log("_UPDATECOUNT: " + _overlayDestination.updateCount);
    }
}
