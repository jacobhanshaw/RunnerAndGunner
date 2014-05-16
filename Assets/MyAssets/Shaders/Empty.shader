Shader "Custom/Empty" 

{

    SubShader 

    {
    	Tags {"Queue" = "Background" }
        ColorMask 0

        Pass

        {

            ZWrite On
			Color (1,1,1,1)

        }   


    } 

}