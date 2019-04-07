using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composit
{
    public abstract class Entry
    {
        public abstract string GetName();
        public abstract int GetSize();
        public void PrintList()
        {
            PrintList("");
        }
        public abstract void PrintList(string prefix);
        public abstract void Add(Entry e);
    }

    public class Directory : Entry
    {
        private string name;
        private List<Entry> entries=new List<Entry>();

        public Directory(string n)
        {
            name = n;
        }

        public override string GetName()
        {
            return name;
        }

        public override int GetSize()
        {
            int sum = 0;
            foreach (var e in entries)
            {
                sum += e.GetSize();
            }
            return sum;
        }

        public override void PrintList(string prefix)
        {
            foreach (var e in entries)
            {
                e.PrintList(prefix+"/"+this.name);
            }
        }


        public override void Add(Entry e)
        {
            entries.Add(e);
        }
    }

    public class File : Entry
    {
        private string name;
        private int size;

        public File(string n, int s)
        {
            name = n;
            size = s;
        }

        public override string GetName()
        {
            return name;
        }

        public override int GetSize()
        {
            return size;
        }

        public override void PrintList(string prefix)
        {
            Console.WriteLine(prefix + "/" + this.name);
        }

        public override void Add(Entry e)
        {
            throw new NotImplementedException();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Directory rootDirectory=new Directory("root");
            Directory tmpDirectory = new Directory("tmp");
            Directory binDirectory = new Directory("bin");

            rootDirectory.Add(tmpDirectory);
            rootDirectory.Add(binDirectory);

            File file1= new File("file1",100);
            File file2 = new File("file2", 300);
            File file3 = new File("file3", 500);

            tmpDirectory.Add(file1);
            binDirectory.Add(file2);
            binDirectory.Add(file3);

            rootDirectory.PrintList();

            Console.ReadLine();
        }
    }
}
