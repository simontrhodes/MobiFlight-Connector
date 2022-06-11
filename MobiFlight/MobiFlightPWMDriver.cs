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
        public int outputLower;
        public int outputUpper;
        public int NumModules = 16;

        private String _name = "PWMDriver";
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        protected bool _initialized = false;

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

        public int NumberOfPins { get; set; }

        public int NumberOfPWMDrivers { get; set; }

        public int inputLower { get; set; }

        public int inputUpper { get; set; }


        public MobiFlightPWMDriver()
        {
            inputLower = 0;
            inputUpper = 59;
            outputLower = 400;
            outputUpper = 2200;
        }

        private int map(int value, int inputLower, int inputUpper, int outputLower, int outputUpper)
        {
            float relVal = (value - inputLower) / (float)(inputUpper - inputLower);
            return (int)Math.Round((relVal * (outputUpper - outputLower)) + outputLower, 0);
        }

        public void MoveToPosition(String Pin, String value)
        {

            if (!_initialized) Initialize();


            int iValue = int.Parse(value);
            int mappedValue = map(iValue, inputLower, inputUpper, outputLower, outputUpper);
            
            
            var command = new SendCommand((int)MobiFlightModule.Command.SetPWMDriver);
            command.AddArgument(this.PWMDriverNumber);
            command.AddArgument(Pin);
            command.AddArgument(mappedValue);
            Log.Instance.log("Command: SetPWMDriver <" + (int)MobiFlightModule.Command.SetPWMDriver + "," +
                              PWMDriverNumber + "," +
                              Pin + "," +
                              mappedValue + ";>", LogSeverity.Debug);
            // Send command
            CmdMessenger.SendCommand(command);
        }

        public void Stop()
        {
            //int i;
            //int pin = 0;
            //for (i = 0; i != NumberOfPins; i++)
            //    pin = i.ToString;
            //    MoveToPosition(pin, "0");
        }
    }
}
