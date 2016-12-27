using System;

namespace ClawController
{
    public class ArmPosition
    {
        public double ClawPosition { get; set; }
        public double DistanceArmPosition { get; set; }
        public double HeightArmPosition { get; set; }
        public double BasePosition { get; set; }

        public int ServoMicroSecMin = 580;
        public int ServoMicroSecMax = 2380;

        public ArmPosition()
        {
        }

        public ArmPosition(string pathData)
        {
            string[] positions = pathData.Split(new char[] { ',', 'x', 'y' }, StringSplitOptions.RemoveEmptyEntries);
            if (positions.Length != 4)
            { throw new Exception("Could not read path data"); }

            int x = 0;
            BasePosition = Convert.ToInt32(positions[x++]);
            HeightArmPosition = Convert.ToInt32(positions[x++]);
            DistanceArmPosition = Convert.ToInt32(positions[x++]);
            ClawPosition = Convert.ToInt32(positions[x++]);

            if (BasePosition > 180) BasePosition = ConvertFromServoPositionToDegrees(Convert.ToInt32(BasePosition));
            if (HeightArmPosition > 180) HeightArmPosition = ConvertFromServoPositionToDegrees(Convert.ToInt32(HeightArmPosition));
            if (DistanceArmPosition > 180) DistanceArmPosition = ConvertFromServoPositionToDegrees(Convert.ToInt32(DistanceArmPosition));
            if (ClawPosition > 180) ClawPosition = ConvertFromServoPositionToDegrees(Convert.ToInt32(ClawPosition));
        }

        public override string ToString()
        {
            return $"Base: {BasePosition:n2}, Distance: {HeightArmPosition:n2}, Height: {DistanceArmPosition:n2}, Claw: {ClawPosition:n2}";
        }

        public string GetStringCommand(bool HighAccuracy)
        {
            string returnValue = $"{BasePosition:n0},{HeightArmPosition:n0},{DistanceArmPosition:n0},{ClawPosition:n0}x";

            if (HighAccuracy)
            {
                int basepos = ConvertToServoPosition(BasePosition / 180);
                int heightpos = ConvertToServoPosition(HeightArmPosition / 180);
                int distancepos = ConvertToServoPosition(DistanceArmPosition / 180);
                int clawpos = ConvertToServoPosition(ClawPosition / 180);
                returnValue = $"{basepos},{heightpos},{distancepos},{clawpos}y";
            }

            return returnValue;
        }

        public int ConvertToServoPosition(double value)
        {
            int diff = ServoMicroSecMax - ServoMicroSecMin;
            int returnVal = Convert.ToInt32(ServoMicroSecMin + (value * diff));
            return returnVal;
        }

        public double ConvertFromServoPositionToDegrees(int value)
        {
            int diff = ServoMicroSecMax - ServoMicroSecMin;
            return (Convert.ToDouble(value - ServoMicroSecMin) / diff) * 180;
        }
    }
}
