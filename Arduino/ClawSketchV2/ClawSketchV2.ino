// MeArmMeCon-A041.ino
//Sample Arduino Code for MeCon Motion Control Software
// For Arm.Uno, MeArm and Compatible Robotic Arms
// Go to WWW.MICROBOTLABS.COM for updates and more info


#include <Servo.h>

//MeArm HAS 4 SERVOS
Servo xServo;  // create servo object, arm base servo - left right motion
Servo yServo;  // create servo object, left side servo - forward backwards motion
Servo zServo;  // create servo object, right side servo - forward backwards motion
Servo clawServo;  // create servo object, end of arm srevo - open,close the claw hand

//servo positions values, expects 1-180 deg.
int xPos;
int yPos;
int zPos;
int clawPos;

//servo positions values, expects 1-2 microseconds for servo position.
double xPosFloat;
double yPosFloat;
double zPosFloat;
double clawPosFloat;

//*************** INIT AT STARTUP *******************************************************************

void setup() {        // the setup function runs once when you press reset or power the board

  // assign servo to pin numbers
  xServo.attach(11);  // attaches the servo on pin 11 to the servo object
  yServo.attach(10);  // attaches the servo on pin 10 to the servo object
  zServo.attach(9);  // attaches the servo on pin 9 to the servo object
  clawServo.attach(6);  // attaches the servo on pin 6 to the servo object

  // initialize serial port
  Serial.begin(9600);

  // Debug only send serial message to host com port terminal window in Arduino IDE
  //Serial.print("*** MeCon com Test V04 ***");   // send program name, uncomment for debug connection test

  //clawServo.writeMicroseconds(1600);

}

// ******************************************************************************************************
// ********************************** MAIN PROGRAM LOOP START *******************************************
// ******************************************************************************************************

void loop() {

  //Get servo position values from serial port
  //serial in packet patern = xVal,yVal,zVal,clawVal + end of packet char 'x'
  while (Serial.available() > 0) {
    xPos = Serial.parseInt();
    yPos = Serial.parseInt();
    zPos = Serial.parseInt();
    clawPos = Serial.parseInt();

    

    if (Serial.peek() == 'x') { // Detect end of packet char 'x', go ahead and update servo positions
      Serial.read();
      
      // UPDATE SERVO POSITIONS 
      //xServo.write(xPos);//COUNTERCLOCKWISE - uncomment to use this rotation and comment out the next line
      xServo.write(180 - xPos);//CLOCKWISE- Example of how to Reverse rotation of servo motor
      yServo.write(yPos);//COUNTERCLOCKWISE rotation
      zServo.write(zPos);//COUNTERCLOCKWISE rotation
      clawServo.write(clawPos);//COUNTERCLOCKWISE rotation


    }
    else if (Serial.peek() == 'y')
    {
        Serial.read();
     
        // UPDATE SERVO POSITIONS 
        xServo.writeMicroseconds(xPos);//CLOCKWISE- Example of how to Reverse rotation of servo motor
        yServo.writeMicroseconds(yPos);//COUNTERCLOCKWISE rotation
        zServo.writeMicroseconds(zPos);//COUNTERCLOCKWISE rotation
        clawServo.writeMicroseconds(clawPos);//COUNTERCLOCKWISE rotation
    }

  }

}

