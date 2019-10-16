using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

        class Program
        {
            static void Main(string[] args)
            {
                //variable declarations
                string strChoice = "";

                //menu loop
                while (strChoice != "3")
                {
                    //main menu
                    Console.WriteLine("-------Main Menu--------");
                    Console.WriteLine("1.\tAdd Names to a File");
                    Console.WriteLine("2.\tView Names in a File");
                    Console.WriteLine("3.\tExit");
                    strChoice = Console.ReadLine();


                    //process choice
                    switch (strChoice)
                    {
                        case "1":
                            addNames();
                            break;
                        case "2":
                            viewNames();
                            break;
                        case "3":
                            break;
                        default:
                            Console.WriteLine(strChoice + " is not a valid choice.");
                            break;
                    }
                }

            }//end Main()


            static void addNames()
            {
                //Instantiate a FileStream that will open a file named "names.txt", 
                FileStream stream1 = new FileStream("names.txt", FileMode.Append, FileAccess.Write);
                StreamWriter textFile1 = new StreamWriter(stream1);

                Console.WriteLine("Enter a name or type -99 to quit:");
                string userInput = Console.ReadLine();

                //input loop
                while (userInput != "-99")
                {
                    textFile1.WriteLine(userInput);
                    Console.WriteLine("Enter a name or type -99 to quit:");
                    userInput = Console.ReadLine();
                }

                textFile1.Close();



            }//end addNames()

            static void viewNames()
            {
            //instantiate a FileStream Object to open "names.txt" with FileMode.Open and FileAccess.Read
             FileStream stream1 = new FileStream("names.txt", FileMode.Open, FileAccess.Read);
             StreamReader textFile1 = new StreamReader(stream1);

            string lines;
            int lineCount = 0;

            //instantiate a StreamReader Object and pass to it the FileStream Object you created

            // ReadAllLines(@"names.txt", FileMode.Open, FileAccess.Read);
            Console.WriteLine("Name List\n==================\n");
            while ((lines = textFile1.ReadLine()) != null)
            {
                Console.WriteLine(lines);
                lineCount++;
            }



            //read file in loop while the reader is not at the EndOfStream and display the lines of text

            /*
             * 
            while (...)
            {
                textFile1.ReadLine();
                Console.WriteLine(///);


            }

            */

            //Close the file
            textFile1.Close();

        }//end viewNames()

        }


}
