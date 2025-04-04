using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CheckProg.Classes.ForPIPAction
{
    internal class PIPConvertClass
    {
        public string Designator { get; set; }
        public string PartNumber { get; set; }
        public char Layer {  get; set; }
        public double CenterX { get; set; }
        public double CenterY { get; set; }
        public int Rotation { get; set; }

        public PIPConvertClass(string designator, string partNumber, char layer, double centerX, double centerY, int rotation)
        {
            Designator = designator;
            PartNumber = partNumber;
            Layer = layer;
            CenterX = centerX;
            CenterY = centerY;
            Rotation = rotation;
        }

        public PIPConvertClass(string designator, string partNumber, string layer, double centerX, double centerY, int rotation)
        {
            Designator = designator;
            PartNumber = partNumber;
            Layer = layer[0];
            CenterX = centerX;
            CenterY = centerY;
            Rotation = rotation;
        }

        public PIPConvertClass(string[] data)
        {
            Designator = data[0];
            PartNumber = data[1];
            Layer = data[3][0];
            CenterX = Convert.ToDouble(data[4].Replace('.', ','));
            CenterY = Convert.ToDouble(data[5].Replace('.', ','));
        }

        public PIPConvertClass() { }

        internal List<PIPConvertClass> CreateFromFile(string[][] data)
        {
            List<PIPConvertClass> list = new List<PIPConvertClass>();
            foreach (string[] row in data)
            {
                list.Add(new PIPConvertClass(row));
            }
            return list;
        }
    }
}
