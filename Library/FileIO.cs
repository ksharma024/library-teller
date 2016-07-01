using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class FileIO : IFileInterface
    {
        public List<string> ReturnMediaFile(string path)
        {
            //initialize the list we'll be returning
            List<string> mediaFile = new List<string>();

            try
            {
                //check to see whether the file exists
                if (!File.Exists(path))
                {
                    //throw appropriate exception
                    throw new FileNotFoundException("File not found", path);
                }

                //initialize the empty string we'll be using for each line
                string line;

                //open a StreamReader to the file specified in the path variable
                using (StreamReader reader = new StreamReader(path))
                {
                    //while reading a new from file, add each line to mediaFile
                    //as long as each new line is not null
                    //implement

                    int count = 0;
                    line = reader.ReadLine(); // get the FIRST line

                    while (line != null)
                    {
                        mediaFile.Add(line);
                        line = reader.ReadLine(); // getting the NEXT line
                    }
                }

            }
            catch (FileNotFoundException)
            {
                //write out appropriate message
                Console.WriteLine("File not found.");
            }
            catch (Exception e)
            {
                //write out the message of e
                Console.WriteLine(e.Message);
            }

            return mediaFile;
        }

        //not yet implemented
        public void UpdateMediaFile(List<string> newMedia)
        {
            throw new NotImplementedException();
        }
    }
}
