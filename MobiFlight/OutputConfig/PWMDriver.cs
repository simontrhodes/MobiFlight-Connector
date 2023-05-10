using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MobiFlight.OutputConfig
{
    public class PWMDriver : IXmlSerializable, ICloneable
    {
        public PWMDriver()
        {
            Address = "";
            Pin = "";
            SimLower = "";
            SimUpper = "";
            PWMLower = "1000";
            PWMUpper = "2000";
            MoveValue = "1500";
        }

        public string Address { get; set; }

        public string Pin { get; set; }

        public string SimLower { get; set; }

        public string SimUpper { get; set; }

        public string PWMLower { get; set; }

        public string PWMUpper { get; set; }

        public string MoveValue { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            return
                obj is PWMDriver driver &&
                Pin == driver.Pin &&
                Address == driver.Address &&
                SimLower == driver.SimLower &&
                SimUpper == driver.SimUpper &&
                PWMLower == driver.PWMLower &&
                PWMUpper == driver.PWMUpper &&
                MoveValue == driver.MoveValue;
        }

        public XmlSchema GetSchema()
        {
            return null;
        }
        
        public void ReadXml(XmlReader reader)
        {
            // ignore empty values
            if (!string.IsNullOrEmpty(reader["PWMDriverAddress"]))
                Address = reader["PWMDriverAddress"];

            if (!string.IsNullOrEmpty(reader["PWMDriverPin"])) 
                Pin = reader["PWMDriverPin"];

            if (!string.IsNullOrEmpty(reader["PWMDriverSimLower"]))
                SimLower = reader["PWMDriverSimLower"];

            if (!string.IsNullOrEmpty(reader["PWMDriverSimUpper"]))
                SimUpper = reader["PWMDriverSimUpper"];

            if (!string.IsNullOrEmpty(reader["PWMDriverPWMLower"]))
                PWMLower = reader["PWMDriverPWMLower"];

            if (!string.IsNullOrEmpty(reader["PWMDriverPWMUpper"]))
                PWMUpper = reader["PWMDriverPWMUpper"];

            if (!string.IsNullOrEmpty(reader["PWMDriverMoveValue"]))
                MoveValue = reader["PWMDriverMoveValue"];
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("PWMDriverAddress", Address);
            writer.WriteAttributeString("PWMDriverPin", Pin);
            writer.WriteAttributeString("PWMDriverSimLower", SimLower);
            writer.WriteAttributeString("PWMDriverSimUpper", SimUpper);
            writer.WriteAttributeString("PWMDriverPWMLower", PWMLower);
            writer.WriteAttributeString("PWMDriverPWMUpper", PWMUpper);
            writer.WriteAttributeString("PWMDriverMoveValue", MoveValue);
        }

        public object Clone()
        {
            var clone = new PWMDriver
            {
                Address = Address,
                Pin = Pin,
                SimLower = SimLower,
                SimUpper = SimUpper,
                PWMLower = PWMLower,
                PWMUpper = PWMUpper,
                MoveValue = MoveValue
            };
            return clone;
        }
    }
}