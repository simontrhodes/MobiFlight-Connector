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

        public String Servo { get; set; }

        public PWMDriver()
        {
            Address = "";
            Servo = "";
        }
        public override bool Equals(object obj)
        {
            return
                (obj != null) && (obj is PWMDriver) &&
                (this.Servo == (obj as PWMDriver).Servo) &&
                (this.Address == (obj as PWMDriver).Address);
        }

        public void ReadXml(XmlReader reader)
        {
            // ignore empty values
            if (reader["PWMDriverAddress"] != null && reader["PWMDriverAddress"] != "")
            {
                Address = reader["PWMDriverAddress"]; 
            }

            if (reader["PWMDriverServo"] != null && reader["PWMDriverServo"] != "")
            {
                Servo = reader["PWMDriverServo"];
            }

        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("PWMDriverAddress", Address);
            writer.WriteAttributeString("PWMDriverServo", Servo);

        }

        public object Clone()
        {
            PWMDriver clone = new PWMDriver();
            clone.Address = this.Address;
            clone.Servo = this.Servo;
            return clone;
        }
    }
}
