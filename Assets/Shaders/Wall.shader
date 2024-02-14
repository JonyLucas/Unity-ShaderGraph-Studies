Shader "Custom/Wall"
{
    Properties
    {
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "Queue"="Geometry" }
        
        Stencil
        {
            Ref 1
            Comp Equal
            Pass Keep
        }
        
        Pass
        {
            SetTexture[_MainTex] { combine texture }
        }
    }
}
