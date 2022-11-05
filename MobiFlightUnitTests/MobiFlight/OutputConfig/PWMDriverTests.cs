using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobiFlight.OutputConfig;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MobiFlight.OutputConfig.Tests
{
    [TestClass()]
    public class PWMDriverTests
    {
        [TestMethod()]
        public void PWMDriverTest()
        {
            PWMDriver o = new PWMDriver();
            Assert.IsNotNull(o);
        }

        [TestMethod()]
        public void ReadXmlTest()
        {
            PWMDriver o = new PWMDriver();

            String s = System.IO.File.ReadAllText(@"assets\MobiFlight\OutputConfig\PWMDriver\ReadXmlTest.1.xml");
            StringReader sr = new StringReader(s);
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            System.Xml.XmlReader xmlReader = System.Xml.XmlReader.Create(sr, settings);
            xmlReader.ReadToDescendant("display");
            o.ReadXml(xmlReader);

            Assert.AreEqual("PWMDriver", o.Address);
            Assert.AreEqual("0", o.Pin);
            Assert.AreEqual("1", o.SimLower);
            Assert.AreEqual("100", o.SimUpper);
            Assert.AreEqual("400", o.PWMLower);
            Assert.AreEqual("2000", o.PWMUpper);
            Assert.AreEqual("50", o.MoveValue);
        }

        [TestMethod()]
        public void WriteXmlTest()
        {
            StringWriter sw = new StringWriter();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = System.Text.Encoding.UTF8;
            settings.Indent = true;
            //settings.NewLineHandling = NewLineHandling.Entitize;
            System.Xml.XmlWriter xmlWriter = System.Xml.XmlWriter.Create(sw, settings);

            PWMDriver o = new PWMDriver();
            o.Address = "Address";
            o.Pin = "0";
            o.SimLower = "1";
            o.SimUpper = "100";
            o.PWMLower = "400";
            o.PWMUpper = "2000";
            o.MoveValue = "50";

            xmlWriter.WriteStartElement("display");
            xmlWriter.WriteAttributeString("type", "PWMDriver");
            xmlWriter.WriteAttributeString("serial", "DisplayPWMDriver");
            xmlWriter.WriteAttributeString("trigger", "normal");
            o.WriteXml(xmlWriter);
            xmlWriter.WriteEndElement();
            xmlWriter.Flush();
            string s = sw.ToString();

            String result = System.IO.File.ReadAllText(@"assets\MobiFlight\OutputConfig\PWMDriver\WriteXmlTest.1.xml");

            Assert.AreEqual(result, s, "The both strings are not equal");
        }

        [TestMethod()]
        public void CloneTest()
        {
            PWMDriver o = new PWMDriver();
            o.Address = "Address";
            o.Pin = "0";
            o.SimLower = "1";
            o.SimUpper = "100";
            o.PWMLower = "400";
            o.PWMUpper = "2000";
            o.MoveValue = "50";

            PWMDriver clone = o.Clone() as PWMDriver;

            Assert.AreEqual(o.Address, clone.Address);
            Assert.AreEqual(o.Pin, clone.Pin);
            Assert.AreEqual(o.SimLower, clone.SimLower);
            Assert.AreEqual(o.SimUpper, clone.SimUpper);
            Assert.AreEqual(o.PWMLower, clone.PWMLower);
            Assert.AreEqual(o.PWMUpper, clone.PWMUpper);
            Assert.AreEqual(o.MoveValue, clone.MoveValue);
        }

        [TestMethod()]
        public void EqualsTest()
        {
            PWMDriver o1 = new PWMDriver();
            PWMDriver o2 = new PWMDriver();

            Assert.IsTrue(o1.Equals(o2));

            o1.Address = "Address";
            o1.Pin = "0";
            o1.SimLower = "1";
            o1.SimUpper = "100";
            o1.PWMLower = "400";
            o1.PWMUpper = "2000";
            o1.MoveValue = "50";

            Assert.IsFalse(o1.Equals(o2));

            o2.Address = "Address";
            o2.Pin = "0";
            o2.SimLower = "1";
            o2.SimUpper = "100";
            o2.PWMLower = "400";
            o2.PWMUpper = "2000";
            o2.MoveValue = "50";

            Assert.IsTrue(o1.Equals(o2));
        }
    }
}