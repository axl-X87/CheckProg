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
        public string GlobalPath { get; set; }

        public void SetPath(string path)
        {
            GlobalPath = path;
        }

        public DataVersion XmlParceClassStart() 
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DataVersion));
            using ( StreamReader reader = new StreamReader(GlobalPath))
            {
                return (DataVersion)serializer.Deserialize(reader);
            }
        }
    }
}
