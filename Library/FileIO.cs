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

            try
            {
                //check to see whether the file exists
                if (!File.Exists(path))
                {
                    //throw appropriate exception
                    throw new FileNotFoundException("File not found", path);
                }

                return File.ReadLines(path).ToList();
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

            return new List<string>();
        }

        //not yet implemented
        public void UpdateMediaFile(List<string> newMedia)
        {
            throw new NotImplementedException();
        }
    }
}
