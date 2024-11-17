using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xaml.Permissions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace CheckProg.Classes.DataClasses
{
    internal class XmlParceClass
    {
        public DataVersion XmlParceClassStart() 
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DataVersion));
            using (StreamReader reader = new StreamReader("C:\\Users\\Привет!\\Pictures\\RS@ARKTUR-BOT-2.0@241113 160931 1 5@5@A@NG@20241113160931.xml"))
            {
                return (DataVersion)serializer.Deserialize(reader);
            }
        }
    }
}
