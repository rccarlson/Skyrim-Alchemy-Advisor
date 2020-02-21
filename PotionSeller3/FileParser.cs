using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotionSeller3
{
    public class FileParser
    {
        public static List<List<string>> LoadStringsFromFile(string filename, bool ignoreFirstLine = true)
        {
            List<List<string>> fileStrings = new List<List<string>>();
            using (System.IO.StreamReader fileStream = new System.IO.StreamReader(filename))
            {
                if (ignoreFirstLine)
                    fileStream.ReadLine();
                while (!fileStream.EndOfStream)
                {
                    string line = fileStream.ReadLine();
                    List<string> lineStrings = new List<string>();
                    for (int i = 0;//line.IndexOf('\t');
                        i >= 0 && i < line.Length;
                        i = line.IndexOf('\t', i + 1))
                    {
                        int length = line.IndexOf('\t', i + 1) - i;
                        string lineString;

                        if (i + length < line.Length && length > 0)
                            lineString = line.Substring(i, length);
                        else
                            lineString = line.Substring(i);

                        lineStrings.Add(lineString.Trim());
                    }
                    fileStrings.Add(lineStrings);
                }
            }
            return fileStrings;
        }
    }
}
