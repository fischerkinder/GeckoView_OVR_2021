using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class GenerateTextureOnMaterial : MonoBehaviour
{
    private Material _dstMaterial;
    private Texture2D _dstTexture;

    public GameObject srcCube;
    private Material _srcMaterial;
    private Texture _srcTexture;

    // Start is called before the first frame update
    void Start()
    {

        _dstMaterial = GetComponent<Material>();
        _srcMaterial = srcCube.GetComponent<MeshRenderer>().material;
        _srcTexture = _srcMaterial.mainTexture;


        _dstTexture = (Texture2D)_srcTexture;
        //_dstTexture.Create();
        //Graphics.CopyTexture(_srcTexture, _dstTexture);

        

               
        GetComponent<MeshRenderer>().material.mainTexture = _dstTexture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
