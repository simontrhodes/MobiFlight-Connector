using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandMessenger;

namespace MobiFlight
{
    public class MobiFlightPWMDriver : IConnectedDevice
    {
        public const string TYPE = "PWMDriver";
        public const string LABEL_PREFIX = "Output";
        protected bool _initialized = false;
        private int[][] range = new int[16][];
        
        private String _name = "PWMDriver";
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private DeviceType _type = DeviceType.PWMDriver;
        public DeviceType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        protected void Initialize()
        {
            if (_initialized) return;
            _initialized = true;
        }

        public CmdMessenger CmdMessenger { get; set; }
        public int PWMDriverNumber { get; set; }

        public int Pin { get; set; }
        
        public int NumberOfPWMDrivers { get; set; }


        public MobiFlightPWMDriver()
        {
            
        }

        private int map(int value, int inputLower, int inputUpper, int outputLower, int outputUpper)
        {
            if ((inputLower == outputLower) && (outputLower == outputUpper)) return value;
            float relVal = (value - inputLower) / (float)(inputUpper - inputLower);
            return (int)Math.Round((relVal * (outputUpper - outputLower)) + outputLower, 0);
        }

        public void SetPWMDriver(String Pin, String value, int inputLower, int inputUpper, int outputLower, int outputUpper)
        {
            if (!_initialized) Initialize();

            int iValue = int.Parse(value);
            int iPin = int.Parse(Pin);

            int outputValue = map(iValue, inputLower, inputUpper, outputLower, outputUpper);

        
            var command = new SendCommand((int)MobiFlightModule.Command.SetPWMDriver);
            command.AddArgument(this.PWMDriverNumber);
            command.AddArgument(Pin);
            command.AddArgument(outputValue);
            // Send command
            Log.Instance.log("Command: SetPWMDriver <" + (int)MobiFlightModule.Command.SetPWMDriver + "," +
                              PWMDriverNumber + "," +
                              Pin + "," +
                              outputValue + ";>", LogSeverity.Debug);
            // Send command
            CmdMessenger.SendCommand(command);
        }

        public void Stop()
        {
                          
            
        }
    }
}
