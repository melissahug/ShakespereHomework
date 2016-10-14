using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ShakespereHomework
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Read and print the first line from the file only.
            Read and print the entire text file.
            Read and print the entire text file and capitalize all lowercase vowels.*/

            //StreamReader reader = new StreamReader("C:\\Users\\WeCanCodeIT\\Documents\\Visual Studio 2015\\Projects\\Shakespere.txt");

            //This prints line one only
            /*string newLine = reader.ReadLine();
            Console.WriteLine("Line 1: " +newLine);
            */
            
            StreamReader reader = new StreamReader("C:\\Users\\WeCanCodeIT\\Documents\\Visual Studio 2015\\Projects\\Shakespere.txt");
            string line = reader.ReadLine();

            int lineNumber = 1;
            

            while (line != null)
            {
                lineNumber++;
                Console.WriteLine(lineNumber);
                lineNumber = lineTwo.ReadLine();
            }
            lineTwo.Close();
           
            


        
    }
}
