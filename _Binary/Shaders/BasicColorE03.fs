#version 330

in vec3 Color;

uniform vec3 SolidColor = vec3(-1,-1,-1);
uniform bool Comp = false;

out vec4 Fragment;

void main()
{
	vec3 colorChange = Color;
	Fragment = vec4(Color,1);
	
	if(SolidColor.r != -1.0 && SolidColor.g != -1.0 && SolidColor.b != -1.0)
	{
		Fragment = vec4(SolidColor, 1);
	}

	if(Comp == true)
	{
		colorChange = vec3(1.0f, 1.0f, 1.0f) - colorChange;

	}
	
	Fragment = vec4(colorChange, 1);

	return;
}