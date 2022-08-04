Shader "Custom/VertexColour" {
    SubShader{
        // Start
        CGPROGRAM

        #pragma surface surf Lambert

        strust Input {
            float4 vertColour : COLOR;
        };
        
        void surf(Input IN, inout SurfaceOutput o) {
            // Set the mesh´s albedo to be the vertex colour
            o.Albedo = IN.vertColour;
        }

        // End
        ENDCG
    }

    FallBack "Diffuse"
}
