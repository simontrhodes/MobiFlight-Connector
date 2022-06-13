using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MobiFlight.OutputConfig
{
    public class PWMDriver 
    {
        public string Address { get; set; }

        public String Pin { get; set; }

        public String SimLower { get; set; }

        public String SimUpper { get; set; }

        public String PWMLower { get; set; }

        public String PWMUpper { get; set; }


        public PWMDriver()
        {
            Address = "";
            Pin = "";
            SimLower = "";
            SimUpper = "";
            PWMLower = "";
            PWMUpper = "";
        }
        public override bool Equals(object obj)
        {
            return
                (obj != null) &&  (obj is PWMDriver) &&
                (this.Pin ==      (obj as PWMDriver).Pin) &&
                (this.Address ==  (obj as PWMDriver).Address) &&
                (this.SimLower == (obj as PWMDriver).SimLower) &&
                (this.SimUpper == (obj as PWMDriver).SimUpper) &&
                (this.PWMLower == (obj as PWMDriver).PWMLower) &&
                (this.PWMUpper == (obj as PWMDriver).PWMUpper);
        }

        public void ReadXml(XmlReader reader)
        {
            // ignore empty values
            if (reader["PWMDriverAddress"] != null && reader["PWMDriverAddress"] != "")
            {
                Address = reader["PWMDriverAddress"];
            }

            if (reader["PWMDriverPin"] != null && reader["PWMDriverPin"] != "")
            {
                Pin = reader["PWMDriverPin"];
            }

            if (reader["PWMDriverSimLower"] != null && reader["PWMDriverSimLower"] != "")
            { 
                SimLower = reader["PWMDriverSimLower"];
            }

            if (reader["PWMDriverSimUpper"] != null && reader["PWMDriverSimUpper"] != "")
            {
                SimUpper = reader["PWMDriverSimUpper"];
            }

            if (reader["PWMDriverPWMLower"] != null && reader["PWMDriverPWMLower"] != "")
            {
                PWMLower = reader["PWMDriverPWMLower"];
            }

            if (reader["PWMDriverPWMUpper"] != null && reader["PWMDriverPWMUpper"] != "")
            {
                PWMUpper = reader["PWMDriverPWMUpper"];
            }

        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("PWMDriverAddress", Address);
            writer.WriteAttributeString("PWMDriverPin", Pin);
            writer.WriteAttributeString("PWMDriverSimLower", SimLower);
            writer.WriteAttributeString("PWMDriverSimUpper", SimUpper);
            writer.WriteAttributeString("PWMDriverPWMLower", PWMLower);
            writer.WriteAttributeString("PWMDriverPWMUpper", PWMUpper);

        }

        public object Clone()
        {
            PWMDriver clone = new PWMDriver();
            clone.Address = this.Address;
            clone.Pin = this.Pin;
            clone.SimLower = this.SimLower;
            clone.SimUpper = this.SimUpper;
            clone.PWMLower = this.PWMLower;
            clone.PWMUpper = this.PWMUpper;
            return clone;
        }
    }
}
