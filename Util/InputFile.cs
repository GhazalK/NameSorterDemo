

namespace Util
{
    public class InputFile : IOInterface
    {
        public string[] GetInputName(string file_path)
        {
            if (System.IO.File.Exists(file_path))
            {
                string[] lines = System.IO.File.ReadAllLines(file_path);
                return lines;


                
            }
            return null;
        }
    }
}
