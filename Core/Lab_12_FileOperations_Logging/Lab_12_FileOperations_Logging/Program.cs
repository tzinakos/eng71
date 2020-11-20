using System;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace Lab_12_FileOperations_Logging
{
    class Program
    {
        static void Main(string[] args)
        {

            //File Operations////
            ////set path
            string path1 = Directory.GetCurrentDirectory();
            string path2 = Path.GetFullPath(Path.Combine(path1, @"..\..\..\\Lyrics\"));
            ////ReadAllText(string): Opens text file, reads all text, closes file
            //string lyrics = File.ReadAllText(path2 + "/Wonderwall.txt");
            //Console.WriteLine(lyrics);

            ////writeAllText(string, string), creates a new file which writes a specified string to said file.
            //File.WriteAllText(path2 + "ChampagneSupernova.txt", "In Champagne Supernova in the sky!");

            ////WriteAllText(string, string[]), creates a new file which writes an array as lines

            //string[] Lyrics = { "So", "Sally", "Can", "Wait" };
            //File.WriteAllLines(path2 + "/DontLookBackInAnger.txt", Lyrics);

            //Exists(string) Checks if file exists

            //var path3 = path2 + @"\myLyrics.txt";

            //if (!File.Exists(path3))
            //{
            //    //create a File to write to
            //    string[] createText = {"Hello", "I'm","Jino" };
            //    File.WriteAllLines(path3, createText);
            //}
            //string[] readText = File.ReadAllLines(path3);
            //foreach (var item in readText)
            //{

            //    Console.WriteLine(item);
            //}

            //Append Text (string, string). Append text to existing text file

            //string appendText = "And I am happy" + Environment.NewLine;
            //File.AppendAllText(path3, appendText);

            ////Coppy(string, strin, bool)

            //File.WriteAllText(path2 + @"/oldLyrics", "Hey now, I'm an Allstar");

            ////copy new lyrics.txt into old lyrics.txt and ovewride if oldlyrics.txt exists
            //string oldLyrics = path2 + @"/oldLyrics";
            //string newLyrics = path2 + @"/newLyrics";

            //File.Copy(oldLyrics, newLyrics, false);

            ////Delete(string)

            ////File.Delete(path2 + @"/oldLyrics.txt");

            ////Information about our files
            //DateTime lastWriteTime = File.GetLastWriteTime(path3);
            //DateTime creatinTime = File.GetCreationTime(path3);
            //var fileInfo = new FileInfo(path3);

            //Console.WriteLine("last Write time: "+lastWriteTime + " Creation Time"+creatinTime);
            //Console.WriteLine(fileInfo.DirectoryName +" "+ fileInfo.Extension);

            //Folder Operations////
            //var fileArray = Directory.GetFiles(path2);
            //foreach (var item in fileArray)
            //{
            //    Console.WriteLine(item);
            //}

            //////Create Directory.
            //Directory.CreateDirectory(path2 + "/FolderA");

            ////Delete Directory.
            //Directory.Delete(path2 + "/FolderA");

            ////////Logging//////////////
            ///
            //We can Log to VS output window as well as the console
            int total = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
                total += 1;
                Debug.WriteLine($"Debug - The Value Of i is: {i}");
                Trace.WriteLine($"Trace - The Value of i is: {i}");
            } 

            /// Conditionally Compiling Code
#if DEBUG
            Console.WriteLine("Yello");
#endif
        }
    }
}
