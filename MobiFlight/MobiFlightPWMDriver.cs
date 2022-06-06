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
        public int NumberOfServos { get; set; }

        public int inputLower { get; set; }

        public int inputUpper { get; set; }


        public MobiFlightPWMDriver()
        {
            outputLower = 0;
            outputUpper = 4095;
        }

        private int map(int value, int inputLower, int inputUpper, int outputLower, int outputUpper)
        {
            float relVal = (value - inputLower) / (float)(inputUpper - inputLower);
            return (int)Math.Round((relVal * (outputUpper - outputLower)) + inputLower, 0);
        }

        public void MoveToPosition(int servo, int value)
        {

            if (!_initialized) Initialize();

            int mappedValue = map(value, inputLower, inputUpper, outputLower, outputUpper);
            
            var command = new SendCommand((int)MobiFlightModule.Command.SetPWMDriver);
            command.AddArgument(PWMDriverNumber);
            command.AddArgument(mappedValue);
            Log.Instance.log("Command: SetPWMDriver <" + (int)MobiFlightModule.Command.SetPWMDriver + "," +
                              PWMDriverNumber + "," +
                              mappedValue + ";>", LogSeverity.Debug);
            // Send command
            CmdMessenger.SendCommand(command);
        }

        public void Stop()
        {
            for (int i = 0; i != NumberOfServos; i++)
                MoveToPosition(i, 0);
        }
    }
}
