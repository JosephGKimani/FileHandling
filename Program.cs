using System.IO;
using System;
using System.Text;
class Program
{


    static void Main()
    {

        string path = @"D:\txt1.txt";
      

        if (File.Exists(path))
        {
            string[] lines = { "i want you", "why are you doing that" };
            File.WriteAllLines(path, lines);
        }



    }


}

