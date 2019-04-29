using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class DataSource
    {
        private DataSource()
        {

        }
        public static string GetProperty(string propertyName)
        {
            return "Stub" + propertyName;
        }

    }

    class HTMLWriter
    {
        TextWriter sw = null; 
        public HTMLWriter(TextWriter t)
        {
            sw = t;
        }

        public void MakeTitle(string title)
        {
            sw.Write($@"<html>
                            <head>
                            <title>{title}</title>
                            </head>
                            <body>");
        }

        public void MakeParagraph(string text)
        {
            sw.Write($@"<p>{text}</p>");
        }

        public void Close()
        {
            sw.Write($@"</body>
                            </html>");
            sw.Flush();
            sw.Close();
        }
    }

    public class PageMaker
    {
        private PageMaker()
        {

        }

        public static void MakePage(string fileName)
        {
            HTMLWriter hw =new HTMLWriter(new StreamWriter(fileName));
            hw.MakeTitle("Hello world!");
            hw.MakeParagraph(DataSource.GetProperty("A1"));
            hw.MakeParagraph(DataSource.GetProperty("A2"));
            hw.MakeParagraph(DataSource.GetProperty("A3"));
            hw.Close();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PageMaker.MakePage("output.html");
        }
    }

}

