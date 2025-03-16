// See https://aka.ms/new-console-template for more information
using tp5_103022330036;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

class Program
{
    static void Main(string[] args)
    {
        string nim = "10302233036";
        DataGeneric<string> data = new DataGeneric<string>(nim);
        data.printData();
    }
}
