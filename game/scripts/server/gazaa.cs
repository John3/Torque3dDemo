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

function GazAACar::onAdd(%this, %obj)
{
   Parent::onAdd(%this, %obj);

   %obj.setWheelTire(0,GazAACarTire);
   %obj.setWheelTire(1,GazAACarTire);
   %obj.setWheelTire(2,GazAACarTireRear);
   %obj.setWheelTire(3,GazAACarTireRear);

   // Setup the car with some tires & springs
   for (%i = %obj.getWheelCount() - 1; %i >= 0; %i--)
   {
      %obj.setWheelPowered(%i, true);
      %obj.setWheelSpring(%i, CheetahCarSpring);
   }

   // Steer with the front tires
   %obj.setWheelSteering(0, 1);
   %obj.setWheelSteering(1, 1);

   %obj.leftBrakeLight = new PointLight() 
   {
      radius = "1";
      isEnabled = "0";
      color = "1 0 0.141176 1";
      brightness = "2";
      castShadows = "1";
      priority = "1";
      animate = "0";
      animationPeriod = "1";
      animationPhase = "1";
      flareScale = "1";
      attenuationRatio = "0 1 1";
      shadowType = "DualParaboloidSinglePass";
      texSize = "512";
      overDarkFactor = "2000 1000 500 100";
      shadowDistance = "400";
      shadowSoftness = "0.15";
      numSplits = "1";
      logWeight = "0.91";
      fadeStartDistance = "0";
      lastSplitTerrainOnly = "0";
      representedInLightmap = "0";
      shadowDarkenColor = "0 0 0 -1";
      includeLightmappedGeometryInShadow = "0";
      rotation = "1 0 0 0";
      canSave = "1";
      canSaveDynamicFields = "1";
         splitFadeDistances = "10 20 30 40";
   };

   // Mount the brake lights
   %obj.mountObject(%obj.leftBrakeLight, %this.leftBrakeSlot);
}

function GazAACar::onRemove(%this, %obj)
{
   Parent::onRemove(%this, %obj);

   if(isObject(%obj.leftBrakeLight))
      %obj.leftBrakeLight.delete();

}

function serverCmdtoggleBrakeLights(%client)
{
   %car = %client.player.getControlObject();

   if (%car.getClassName() $= "WheeledVehicle")
   {
      if(%car.leftBrakeLight.isEnabled)
      {
         %car.leftBrakeLight.setLightEnabled(0);
      }
      else
      {
         %car.leftBrakeLight.setLightEnabled(1);
      }
   }
}

