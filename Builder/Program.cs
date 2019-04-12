using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class Builder
    {
        abstract public void MakeTitle(string title);
        abstract public void MakeString(string str);
        abstract public void MakeItems(IList<string> items);
        abstract public void Close();
    }

    class FileBuilder : Builder
    {
        FileStream fs;
        StreamWriter sw;
        public FileBuilder(string fileName)
        {
            fs = new FileStream(fileName,FileMode.Create);
            sw = new StreamWriter(fs);
        }
        public override void Close()
        {
            sw.Write("End of Text");
            sw.WriteLine();
        }

        public void GetResult()
        {
            sw.Flush();
            fs.Close();
            return;
        }

        public override void MakeItems(IList<string> items)
        {
            foreach (var i in items)
            {
                sw.Write("#" + i);
                sw.WriteLine();
            }
        }

        public override void MakeString(string str)
        {
            sw.Write(">>");
            sw.Write(str);
            sw.WriteLine();
        }

        public override void MakeTitle(string title)
        {
            sw.Write("[");
            sw.Write(title);
            sw.Write("]");
            sw.WriteLine("");
        }
    }

    class TextBuilder : Builder
    {
        StringBuilder stringBuilder = new StringBuilder();
        public override void Close()
        {
            stringBuilder.Append("End of Text");
            stringBuilder.AppendLine();
        }

        public string GetResult()
        {
            return stringBuilder.ToString();
        }

        public override void MakeItems(IList<string> items)
        {
            foreach (var i in items)
            {
                stringBuilder.Append("#"+i);
                stringBuilder.AppendLine();
            }
        }

        public override void MakeString(string str)
        {
            stringBuilder.Append(">>");
            stringBuilder.Append(str);
            stringBuilder.AppendLine();
        }

        public override void MakeTitle(string title)
        {
            stringBuilder.Append("[");
            stringBuilder.Append(title);
            stringBuilder.Append("]");
            stringBuilder.AppendLine();
        }
    }

    class Director
    {
        Builder builder;

        public void SetBuilder(Builder b)
        {
            builder = b;
        }

        public void Construct()
        {
            builder.MakeTitle("Title");
            builder.MakeString("String 1");
            builder.MakeItems(new List<string>(){ "Items 1","Items 2","Items 3"});
            builder.MakeString("String 2");
            builder.MakeItems(new List<string>(){ "Items 4", "Items 5", "Items 6" });
            builder.Close();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            TextBuilder textBuilder = new TextBuilder();
            director.SetBuilder(textBuilder);
            director.Construct();
            string r1 = textBuilder.GetResult();
            Console.WriteLine(r1);

            FileBuilder htmlBuilder = new FileBuilder("Test.txt");
            director.SetBuilder(htmlBuilder);
            director.Construct();
            htmlBuilder.GetResult();
  
            Console.ReadLine();
        }
    }
}
