using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandMessenger;

namespace MobiFlight
{
    public class MobiFlightServoDriver : IConnectedDevice
    {
        public const string TYPE = "ServoDriver";
        public const int OutputLower = 0;
        public const int OutputUpper = 180;

        private String _name = "ServoDriver";
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private DeviceType _type = DeviceType.ServoDriver;
        public DeviceType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public CmdMessenger CmdMessenger { get; set; }
        public int ServoDriverNumber { get; set; }
        
        
        public MobiFlightServoDriver()
        {
        
        }

        private int map(int value)
        {
            //int outputUpper = (int)Math.Round((float) OutputUpper * MaxRotationPercent / 100);
            //float relVal = (value - Min) / (float)(Max - Min);
            //return (int)Math.Round((relVal * (outputUpper - OutputLower)) + Min, 0);
            return value;
        }

        public void MoveToPosition(int value)
        {
            int mappedValue = map(value);
            
            var command = new SendCommand((int)MobiFlightModule.Command.SetServoDriver);
            command.AddArgument(ServoDriverNumber);
            command.AddArgument(mappedValue);
            Log.Instance.log("Command: SetServoDriver <" + (int)MobiFlightModule.Command.SetServoDriver + "," +
                              ServoDriverNumber + "," +
                              mappedValue + ";>", LogSeverity.Debug);
            // Send command
            CmdMessenger.SendCommand(command);
        }

        public void Stop()
        {
            MoveToPosition(0);
        }
    }
}
