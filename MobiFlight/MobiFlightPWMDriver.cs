using System;
using CommandMessenger;

namespace MobiFlight
{
    public class MobiFlightPWMDriver : IConnectedDevice
    {
        public const string TYPE = "PWMDriver";


        public CmdMessenger CmdMessenger { get; set; }
        public int PWMDriverNumber { get; set; }

        public int Pin { get; set; }
        public int NumberOfPWMDrivers { get; set; }

        public string Name { get; set; } = "PWMDriver";

        public DeviceType Type => DeviceType.PWMDriver;

        public void Stop()
        {
        }

        public const string LABEL_PREFIX = "Output";
        
        private bool _initialized;
        private void Initialize()
        {
            if (_initialized) return;
            _initialized = true;
        }

        private static int Map(int value, int inputLower, int inputUpper, int outputLower, int outputUpper)
        {
            if (inputLower == outputLower && outputLower == outputUpper) return value;
            var relVal = (value - inputLower) / (float)(inputUpper - inputLower);
            return (int)Math.Round(relVal * (outputUpper - outputLower) + outputLower, 0);
        }

        public void SetPWMDriver(string pin, int value, int inputLower, int inputUpper, int outputLower,
            int outputUpper)
        {
            if (!_initialized) Initialize();

            var outputValue = Map(value, inputLower, inputUpper, outputLower, outputUpper);


            var command = new SendCommand((int)MobiFlightModule.Command.SetPWMDriver);
            command.AddArgument(PWMDriverNumber);
            command.AddArgument(pin);
            command.AddArgument(outputValue);
            // Send command
            Log.Instance.log("Command: SetPWMDriver <" + (int)MobiFlightModule.Command.SetPWMDriver + "," +
                             PWMDriverNumber + "," +
                             pin + "," +
                             outputValue + ";>", LogSeverity.Debug);
            // Send command
            CmdMessenger.SendCommand(command);
        }
    }
}