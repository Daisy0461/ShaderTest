using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LitSahderScript : MonoBehaviour
{
    public Renderer RD;
    public Material MT;
    public Texture2D T2D;
    public Texture2DArray T2DArray;
    public Texture3D T3D;
    public Cubemap cubemap;

    void Start()
    {
        RD.material.SetFloat("_Float", 1);
        RD.material.SetVector("_Vector2", new Vector2(0, 1));
        RD.material.SetVector("_Vector3", new Vector3(0, 1, 2));
        RD.material.SetVector("_Vector4", new Vector4(0, 1, 2, 3));
        RD.material.SetColor("_Color", new Color(1, 1, 1, 1));
        RD.material.SetTexture("_Texture2D", T2D);
        RD.material.SetTexture("_Texture2DArray", T2DArray);
        RD.material.SetTexture("_Texture3D", T3D);
        RD.material.SetTexture("_Cubemap", cubemap);
        RD.material.SetInt("_Boolean", 1);   

        //MT.SetFloat("_Float", 1);
    }
}
