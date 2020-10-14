using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirow : MonoBehaviour
{
    private MeshRenderer Rend; 
    private RenderTexture MirrorTexture;
    [SerializeField] 
    private Camera MirrorCamera;
    void Start()
    {
        Rend = GetComponent<MeshRenderer>();
        MirrorTexture = new RenderTexture(256, 256, 16, RenderTextureFormat.ARGB32);
        Rend.material.SetTexture("_MainTex", MirrorTexture);
        MirrorCamera.targetTexture = MirrorTexture;
    }
}
