// See https://aka.ms/new-console-template for more information
using tp5_103022330036;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp5_103022330036;
using tp5_103022330036.tp5_103022330036;

namespace tp5_103022330036
{
    class HaloGeneric
    {
        public void SapaUser<T>(T x)
        {
            Console.WriteLine($"Halo, user{x}");
        }
    }

namespace tp5_103022330036
{
    class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T Data)
        {
            this.data = Data;
        }

        public void printData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);

        }
    }
}



    // See https://aka.ms/new-console-template for more information

    class program
    {
        static void Main(string[] args)
        {
            HaloGeneric hai = new HaloGeneric();

            hai.SapaUser<string>(" Praktikan");
            string nim = "10302233036";
            DataGeneric<string> data = new DataGeneric<string>(nim);
            data.printData();
        }
    }
}


