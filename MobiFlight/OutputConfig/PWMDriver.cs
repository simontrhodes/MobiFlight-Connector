using System.Xml;

namespace MobiFlight.OutputConfig
{
    public class PWMDriver
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
            return
                obj != null && obj is PWMDriver driver &&
                Pin == driver.Pin &&
                Address == driver.Address &&
                SimLower == driver.SimLower &&
                SimUpper == driver.SimUpper &&
                PWMLower == driver.PWMLower &&
                PWMUpper == driver.PWMUpper &&
                MoveValue == driver.MoveValue;
        }

        public void ReadXml(XmlReader reader)
        {
            // ignore empty values
            if (reader["PWMDriverAddress"] != null && reader["PWMDriverAddress"] != "")
                Address = reader["PWMDriverAddress"];

            if (reader["PWMDriverPin"] != null && reader["PWMDriverPin"] != "") Pin = reader["PWMDriverPin"];

            if (reader["PWMDriverSimLower"] != null && reader["PWMDriverSimLower"] != "")
                SimLower = reader["PWMDriverSimLower"];

            if (reader["PWMDriverSimUpper"] != null && reader["PWMDriverSimUpper"] != "")
                SimUpper = reader["PWMDriverSimUpper"];

            if (reader["PWMDriverPWMLower"] != null && reader["PWMDriverPWMLower"] != "")
                PWMLower = reader["PWMDriverPWMLower"];

            if (reader["PWMDriverPWMUpper"] != null && reader["PWMDriverPWMUpper"] != "")
                PWMUpper = reader["PWMDriverPWMUpper"];

            if (reader["PWMDriverMoveValue"] != null && reader["PWMDriverMoveValue"] != "")
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