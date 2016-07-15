//-----------------------------------------------------------------------------
// Copyright (c) 2012 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

singleton Material(Cheetah_Main)
{
   mapTo = "Cheetah_Main";
   diffuseMap[0] = "art/shapes/Cheetah/Cheetah_D";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "art/shapes/Cheetah/Cheetah_N";
   specularMap[0] = "art/shapes/Cheetah/Cheetah_S";
   castDynamicShadows = true;
};

singleton Material(Cheetah_TailLights)
{
   mapTo = "Cheetah_TailLights";
   diffuseColor[0] = "0.588235 0 0 1";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   glow[0] = "1";
   emissive[0] = "1";
};

singleton Material(Cheetah_MuzzleFlash)
{
   mapTo = "Cheetah_MuzzleFlash";
   diffuseMap[0] = "art/shapes/Cheetah/Cheetah_MuzzleFlash_D";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "AddAlpha";
   glow[0] = "1";
   emissive[0] = "1";
   castShadows = "0";
   translucent = "1";
};

singleton Material(Cheetah_Collider)
{
   mapTo = "Collider";
   diffuseColor[0] = "1 0 0 0.75";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucent = "1";
};

singleton Material(wheel_gaz_aa_wheel)
{
   mapTo = "gaz-aa_wheel";
   diffuseMap[0] = "art/shapes/Cheetah/images/0_gaz-aa_wheel";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
};

singleton Material(Cheetah_Body_gaz_aa_detail)
{
   mapTo = "gaz-aa_detail";
   diffuseMap[0] = "art/shapes/Cheetah/images/4_gaz-aa_detail";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
};

singleton Material(Cheetah_Body_gaz_aa_cabin)
{
   mapTo = "gaz-aa_cabin";
   diffuseMap[0] = "art/shapes/Cheetah/images/3_gaz-aa_cabin";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
};

singleton Material(Cheetah_Body_gaz_aa_wing)
{
   mapTo = "gaz-aa-wing";
   diffuseColor[3] = "White";
   diffuseMap[0] = "art/shapes/Cheetah/images/2_gaz-aa-wing";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
};

singleton Material(Cheetah_Body_gaz_aa_box)
{
   mapTo = "gaz-aa_box";
   diffuseMap[0] = "art/shapes/Cheetah/images/0_gaz-aa_box";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
};

singleton Material(Cheetah_Body_gaz_aa_frame)
{
   mapTo = "gaz-aa_frame";
   diffuseMap[0] = "art/shapes/Cheetah/images/5_gaz-aa_frame";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
};

singleton Material(Cheetah_Body_Tex_0012_0_dds)
{
   mapTo = "Tex_0012_0.dds";
   diffuseMap[0] = "art/shapes/Cheetah/images/0_Tex_0012_0";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
};

singleton Material(Cheetah_Body_Tex_0009_0_dds)
{
   mapTo = "Tex_0009_0.dds";
   diffuseMap[0] = "art/shapes/Cheetah/images/2_Tex_0009_0";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
};

singleton Material(Cheetah_Body_Tex_0011_0_dds)
{
   mapTo = "Tex_0011_0.dds";
   diffuseMap[0] = "art/shapes/Cheetah/images/1_Tex_0011_0";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
};

singleton Material(Cheetah_Body_Tex_0013_0_dds)
{
   mapTo = "Tex_0013_0.dds";
   diffuseMap[0] = "art/shapes/Cheetah/images/4_Tex_0013_0";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
};

singleton Material(Cheetah_Body_Tex_0010_0_dds)
{
   mapTo = "Tex_0010_0.dds";
   diffuseMap[0] = "art/shapes/Cheetah/images/3_Tex_0010_0";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
};

singleton Material(Cheetah_Body__2___Default)
{
   mapTo = "_2_-_Default";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
};

singleton Material(Cheetah_Body_Default)
{
   mapTo = "Default";
   diffuseColor[0] = "0.7 0.7 0.7 1";
   specularPower[0] = "90.496";
   translucentBlendOp = "None";
};

singleton Material(Cheetah_Body_Reflect)
{
   mapTo = "Reflect";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
};

singleton Material(Cheetah_Body_ColorEffectR184G155B229_material)
{
   mapTo = "ColorEffectR184G155B229-material";
   diffuseColor[0] = "0.721569 0.607843 0.898039 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
