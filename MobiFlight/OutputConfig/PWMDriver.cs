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

        public String PWMMax { get; set; }

        public String PWMMin { get; set; }


        public PWMDriver()
        {
            Address = "";
            Pin = "";
            PWMMax = "4095";
            PWMMax = "0";
        }
        public override bool Equals(object obj)
        {
            return
                (obj != null) && (obj is PWMDriver) &&
                (this.Pin == (obj as PWMDriver).Pin) &&
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
                Pin = reader["PWMDriverPin"];
            }

        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("PWMDriverAddress", Address);
            writer.WriteAttributeString("PWMDriverPin", Pin);

        }

        public object Clone()
        {
            PWMDriver clone = new PWMDriver();
            clone.Address = this.Address;
            clone.Pin = this.Pin;
            return clone;
        }
    }
}
