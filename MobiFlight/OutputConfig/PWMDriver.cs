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

        public String PWMPin { get; set; }

        public String PWMMax { get; set; }

        public String PWMMin { get; set; }


        public PWMDriver()
        {
            Address = "";
            PWMPin = "";
            PWMMax = "4095";
            PWMMax = "0";
        }
        public override bool Equals(object obj)
        {
            return
                (obj != null) && (obj is PWMDriver) &&
                (this.PWMPin == (obj as PWMDriver).PWMPin) &&
                (this.Address == (obj as PWMDriver).Address);
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
                PWMPin = reader["PWMDriverPin"];
            }

        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("PWMDriverAddress", Address);
            writer.WriteAttributeString("PWMDriverServo", PWMPin);

        }

        public object Clone()
        {
            PWMDriver clone = new PWMDriver();
            clone.Address = this.Address;
            clone.PWMPin = this.PWMPin;
            return clone;
        }
    }
}
