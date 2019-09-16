using System;
using System.Collections.Generic;
using System.IO;    // !!!!!   This is required for file I/O   !!!!!
using System.Linq;
using System.Text;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // the easy ways of file I/O

            // first method of writing to a file
            string informationToWrite = "Hello persistent file storage world!";
            File.WriteAllText("C:/Users/Matthew/Desktop/C#_file1.txt", informationToWrite); // change the username as required

            // second method
            string[] arrayOfInformation = new string[2];
            arrayOfInformation[0] = "This is line 1";
            arrayOfInformation[1] = "This is line 2";
            File.WriteAllLines(@"../../C#_file2.txt", arrayOfInformation);
            // use "@" in front of the string for a relative path

            // reading files
            string fileContents = File.ReadAllText("C:/Users/Matthew/Desktop/C#_file1.txt");
            string[] fileContentsByLine = File.ReadAllLines(@"../../C#_file2.txt");


            // harder, more useful methods

            // writing to a file
            FileStream fs = File.OpenWrite(@"../../test3.txt");
            TextWriter tw = new StreamWriter(fs);

            tw.Write(3);
            tw.Write("Hello");

            tw.Flush();
            tw.Close();

            // reading from a file
            fs = File.OpenRead(@"../../test3.txt");
            TextReader tr = new StreamReader(fs);

            char nextChar = (char)tr.Read();

            char[] bufferToPutStuffIn = new char[2];
            tr.Read(bufferToPutStuffIn, 0, 2);

            string restOfLine = tr.ReadLine();

            tr.Close();


            // binary files

            // writing
            FileStream fileStream = File.OpenWrite(@"../../test4.txt");
            BinaryWriter binaryWriter = new BinaryWriter(fileStream);

            binaryWriter.Write(3);
            binaryWriter.Write("Hello");

            binaryWriter.Flush();
            binaryWriter.Close();

            // reading
            fileStream = File.OpenRead(@"../../test4.txt");
            BinaryReader binaryReader = new BinaryReader(fileStream);

            int number = binaryReader.ReadInt32();
            string text = binaryReader.ReadString();

            binaryReader.Close();

            // exit prompt
            Console.WriteLine("/nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

// There are also methods in the File class that can Delete, Copy, and Move files, 
// among other useful methods. Be careful with Delete, as it does not prompt user
// input to double check before it deletes any files
