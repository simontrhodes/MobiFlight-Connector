using System;
using System.Linq;
using System.Xml.Serialization;

namespace MobiFlight.Config
{
    public class PWMDriver : BaseDevice
    {
        const ushort _paramCount = 2;
        [XmlAttribute]
        public Byte I2CAddress = 0x40;
        [XmlAttribute]
        public String NumModules = "16";

        public PWMDriver() { Name = "PWMDriver"; _type = DeviceType.PWMDriver; }

        override public String ToInternal()
        {
            return base.ToInternal() + Separator
                 + I2CAddress + Separator
                 + Name + End;

        }

        override public bool FromInternal(String value)
        {
            if (value.Length == value.IndexOf(End) + 1) value = value.Substring(0, value.Length - 1);
            String[] paramList = value.Split(Separator);
            if (paramList.Count() != _paramCount + 1)
            {
                throw new ArgumentException("Param count does not match. " + paramList.Count() + " given, " + _paramCount + " expected");
            }

            I2CAddress = byte.Parse(paramList[1]);
            Name = paramList[2];

            return true;
        }
    }    
}
