using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignPattern.DocumentBuilder
{
    public class Document
    {
        public string Header { get;  }
        public string Footer { get; }
        public List<string> Paragraph { get; }
        public Document(string header, string footer, List<string> paragraph) 
        {
            Header = header;
            Footer = footer;
            Paragraph = paragraph;
        }
    }
}
