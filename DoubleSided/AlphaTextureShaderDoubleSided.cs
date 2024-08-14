Shader "Custom/AlphaTextureShaderDoubleSided"
{
    Properties
    {
        _MainTex("Albedo", 2D) = "white" {}
        _MetallicGlossMap("Metallic", 2D) = "white" {}
        _AlphaTex("Alpha Texture", 2D) = "white" {}
        _Glossiness("Smoothness", Range(0, 1)) = 0.5
        _BumpMap("Normal Map", 2D) = "bump" {}
    }

    SubShader
    {
        Tags { "Queue" = "Transparent" }
        Cull Off // Disables face culling

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows alpha:fade
        #pragma target 3.0

        sampler2D _MainTex;
        sampler2D _MetallicGlossMap;
        sampler2D _AlphaTex;
        sampler2D _BumpMap;

        struct Input
        {
            float2 uv_MainTex;
            float2 uv_AlphaTex;
            float2 uv_BumpMap;
        };

        half _Glossiness;

        void surf(Input IN, inout SurfaceOutputStandard o)
        {
            half4 c = tex2D(_MainTex, IN.uv_MainTex);
            half4 alphaColor = tex2D(_AlphaTex, IN.uv_AlphaTex);

            o.Albedo = c.rgb;
            o.Alpha = alphaColor.r;
            o.Metallic = tex2D(_MetallicGlossMap, IN.uv_MainTex).r;
            o.Smoothness = _Glossiness;
            o.Normal = UnpackNormal(tex2D(_BumpMap, IN.uv_BumpMap));
        }
        ENDCG
    }

    FallBack "Diffuse"
}
