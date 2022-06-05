using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MobiFlight.OutputConfig
{
    public class ServoDriver 
    {
        public string Address { get; set; }

        

        public ServoDriver()
        {
            
        }
        public override bool Equals(object obj)
        {
            return
                (obj != null) && (obj is ServoDriver) &&
                (this.Address == (obj as ServoDriver).Address);
        }

        public void ReadXml(XmlReader reader)
        {
            // ignore empty values
            if (reader["ServoDriverAddress"] != null && reader["ServoDriverAddress"] != "")
            {
                Address = reader["ServoDriverAddress"]; 
            }
            
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("ServoDriverAddress", Address);
            
        }

        public object Clone()
        {
            ServoDriver clone = new ServoDriver();
            clone.Address = this.Address;
            return clone;
        }
    }
}
