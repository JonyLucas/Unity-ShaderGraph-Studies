Shader "Holistic/FirstShader"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _EmissionColor ("Emission Color", Color) = (0,0,0,0)
    }
    SubShader
    {

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        struct Input
        {
            float2 uv_MainTex;
        };

        fixed4 _Color;
        fixed4 _EmissionColor;
        sampler2D main_tex;

        void surf(Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D(main_tex, IN.uv_MainTex) * _Color;
            o.Albedo = _Color.rgb;
            o.Emission = _EmissionColor.rgb;
        }
        ENDCG
    }
    FallBack "Diffuse"
}