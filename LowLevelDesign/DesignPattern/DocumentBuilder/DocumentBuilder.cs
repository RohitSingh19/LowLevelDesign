using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignPattern.DocumentBuilder
{
    public class DocumentBuilder
    {
        private string _header;
        private string _footer;
        private List<string> _paragraph = new();
        
        public DocumentBuilder AddHeader(string headerText)
        {
             //validate header
             if(string.IsNullOrEmpty(headerText)) throw new ArgumentNullException("header");
             _header = headerText;
            return this;
        }

        public DocumentBuilder AddFooter(string footerText)
        {
            //validate footer
            if (string.IsNullOrEmpty(footerText)) throw new ArgumentNullException("footer");
            _footer = footerText;
            return this;
        }

        public DocumentBuilder AddParagraph(string para)
        {
            //validate paragraph
            if (string.IsNullOrEmpty(para)) throw new ArgumentNullException("paragraph");
            _paragraph.Add(para);
            return this;
        }

        public Document CreateDocument()
        {
            return new Document(_header, _footer, _paragraph);
        }
             
    }

}
