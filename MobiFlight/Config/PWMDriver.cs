using System;
using System.Linq;
using System.Xml.Serialization;

namespace MobiFlight.Config
{
    public class PWMDriver : BaseDevice
    {
        private const ushort ParamCount = 2;

        [XmlAttribute] public byte I2CAddress = 0x40;

        [XmlAttribute] public string NumModules = "16";

        public PWMDriver() { Name = "PWMDriver"; _type = DeviceType.PWMDriver; }

        public override string ToInternal()
        {
            return base.ToInternal() + Separator
                                     + I2CAddress + Separator
                                     + Name + End;
        }

        public override bool FromInternal(string value)
        {
            if (value.Length == value.IndexOf(End) + 1) value = value.Substring(0, value.Length - 1);
            var paramList = value.Split(Separator);
            if (paramList.Count() != ParamCount + 1)
                throw new ArgumentException("Param count does not match. " + paramList.Count() + " given, " +
                                            ParamCount + " expected");

            I2CAddress = byte.Parse(paramList[1]);
            Name = paramList[2];

            return true;
        }
    }
}