using System;
using System.IO;

namespace FileHandlingDemo
{
    class FileHandling
    {
        static void Main(string[] args)
        {
            // Step 1: Define the file paths
            string filepath = "Amit.txt";
            string copyPath = "copy.txt";

            try
            {
                // Step 2: Create file
                Console.WriteLine("Creating a file...");
                File.Create(filepath).Close(); // closing the file is important

                // Step 3: Write data to the file
                Console.WriteLine("Writing to a file...");
                File.WriteAllText(filepath, "Hello, this is a DAY7 Session of a .NFSD..!!");

                // Step 4: Append data to file
                Console.WriteLine("Appending data to the file...");
                File.AppendAllText(filepath, "\nThis data is appended to the text");

                // Step 5: Read from the file
                Console.WriteLine("Reading from the file...");
                string content = File.ReadAllText(filepath);
                Console.WriteLine(content);

                // Step 6: Copy file
                Console.WriteLine("Copying file...");
                File.Copy(filepath, copyPath, true);

                // Step 7: Delete original file
                Console.WriteLine("Deleting original file...");
                File.Delete(filepath);

                Console.WriteLine("File operations completed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}