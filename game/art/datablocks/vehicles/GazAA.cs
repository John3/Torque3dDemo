
datablock SFXProfile(gazaaEngine)
{
   preload = "1";
   description = "AudioCloseLoop3D";
   fileName = "art/sound/gazaa/gaz_engine.ogg";
};
datablock ParticleData(GazAATireParticle)
{
   textureName          = "art/particles/dustParticle";
   dragCoefficient      = "1.99902";
   gravityCoefficient   = "-0.100122";
   inheritedVelFactor   = "0.0998043";
   constantAcceleration = 0.0;
   lifetimeMS           = 1000;
   lifetimeVarianceMS   = 400;
   colors[0]            = "0.456693 0.354331 0.259843 1";
   colors[1]            = "0.456693 0.456693 0.354331 0";
   sizes[0]             = "0.997986";
   sizes[1]             = "3.99805";
   sizes[2]             = "1.0";
   sizes[3]             = "1.0";
   times[0]             = "0.0";
   times[1]             = "1";
   times[2]             = "1";
   times[3]             = "1";
};
datablock ParticleEmitterData(GazAATireEmitter)
{
   ejectionPeriodMS = 20;
   periodVarianceMS = 10;
   ejectionVelocity = "14.57";
   velocityVariance = 1.0;
   ejectionOffset   = 0.0;
   thetaMin         = 0;
   thetaMax         = 60;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   overrideAdvance = false;
   particles = "GazAATireParticle";
   blendStyle = "ADDITIVE";
};
datablock WheeledVehicleTire(GazAACarTire)
{
   // Tires act as springs and generate lateral and longitudinal
   // forces to move the vehicle. These distortion/spring forces
   // are what convert wheel angular velocity into forces that
   // act on the rigid body.
   shapeFile = "art/shapes/gazaa/wheel.DAE";
   staticFriction = 4.2;
   kineticFriction = "1";

   // Spring that generates lateral tire forces
   lateralForce = 8000;
   lateralDamping = 2000;
   lateralRelaxation = 1;

   // Spring that generates longitudinal tire forces
   longitudinalForce = 8000;
   longitudinalDamping = 2000;
   longitudinalRelaxation = 1;
   radius = "0.609998";
}; 
datablock WheeledVehicleTire(GazAACarTireRear)
{
   // Tires act as springs and generate lateral and longitudinal
   // forces to move the vehicle. These distortion/spring forces
   // are what convert wheel angular velocity into forces that
   // act on the rigid body.
   shapeFile = "art/shapes/gazaa/wheelBack.DAE";
   staticFriction = "7.2";
   kineticFriction = "1";

   // Spring that generates lateral tire forces
   lateralForce = "9000";
   lateralDamping = 2000;
   lateralRelaxation = 1;

   // Spring that generates longitudinal tire forces
   longitudinalForce = 8000;
   longitudinalDamping = 2000;
   longitudinalRelaxation = 1;
   radius = "0.840293";
};
datablock WheeledVehicleSpring(GazAACarSpring)
{
   // Wheel suspension properties
   length = 0.02;             // Suspension travel
   force = 2;              // Spring force
   damping = 1;             // Spring damping
   antiSwayForce = 0.2;         // Lateral anti-sway force
};

datablock WheeledVehicleData(GazAACar)
{
   category = "Vehicles";
   shapeFile = "art/shapes/gazaa/GazAA_Body.DAE";
   emap = 1;

   mountPose[0] = sitting;
   numMountPoints = 2;

   useEyePoint = true;  // Use the vehicle's camera node rather than the player's

   maxSteeringAngle = 0.585;  // Maximum steering angle, should match animation

   // 3rd person camera settings
   cameraRoll = false;        // Roll the camera with the vehicle
   cameraMaxDist = 7.8;       // Far distance from vehicle
   cameraOffset = 1.0;        // Vertical offset from camera mount point
   cameraLag = "0.3";           // Velocity lag of camera
   cameraDecay = 1.25;        // Decay per sec. rate of velocity lag

   // Rigid Body
   mass = "400";
   massCenter = "0 0.5 0";    // Center of mass for rigid body
   massBox = "0 0 0";         // Size of box used for moment of inertia,
                              // if zero it defaults to object bounding box
   drag = 0.6;                // Drag coefficient
   bodyFriction = 0.6;
   bodyRestitution = 0.4;
   minImpactSpeed = 5;        // Impacts over this invoke the script callback
   softImpactSpeed = 5;       // Play SoftImpact Sound
   hardImpactSpeed = 15;      // Play HardImpact Sound
   integration = 8;           // Physics integration: TickSec/Rate
   collisionTol = "0.1";        // Collision distance tolerance
   contactTol = "0.4";          // Contact velocity tolerance

   // Engine
   engineTorque = 300;       // Engine power
   engineBrake = "500";         // Braking when throttle is 0
   brakeTorque = "1000";        // When brakes are applied
   maxWheelSpeed = 10;        // Engine scale by current speed / max speed

   // Energy
   maxEnergy = 100;
   jetForce = 3000;
   minJetEnergy = 30;
   jetEnergyDrain = 2;

   // Sounds
   engineSound = gazaaEngine;
   //squealSound = cheetahSqueal;
   softImpactSound = softImpact;
   hardImpactSound = hardImpact;

   // Dynamic fields accessed via script
   nameTag = 'GazAA';
   maxDismountSpeed = 10;
   maxMountSpeed = 5;
   mountPose0 = "sitting";
   tireEmitter = "CheetahTireEmitter";
   dustEmitter = "CheetahTireEmitter";
   dustHeight = "1";
   leftBrakeSlot = 1;
};
