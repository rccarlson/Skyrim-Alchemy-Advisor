using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PotionSeller2
{
    class FileParser:IDisposable
    {
        readonly FileStream fileStream;
        readonly StreamReader streamReader;
        public FileParser(string filename)
        {
            fileStream = new FileStream(filename, FileMode.Open);
            streamReader = new StreamReader(fileStream);
        }
        public string[] ParseLine()
        {
            List<string> lineEntries = new List<string>();
            string line = streamReader.ReadLine();
            if (line != null)
            {
                using (StringReader reader = new StringReader(line))
                {
                    StringBuilder builder = new StringBuilder();
                    char c;
                    while ((c = (char)reader.Read()) != 65535)
                    {
                        if (c == '\t')
                        {
                            lineEntries.Add(builder.ToString());
                            builder.Clear();
                        }
                        else
                        {
                            builder.Append(c);
                        }
                    }
                    lineEntries.Add(builder.ToString());
                }
                return lineEntries.ToArray();
            }
            else
            {
                return null;
            }
        }
        public string ReadLine()
        {
            return streamReader.ReadLine();
        }
        public string ReadTo(char terminatorExclusive)
        {
            StringBuilder builder = new StringBuilder();
            char c;
            while((c = (char)streamReader.Read())!= terminatorExclusive)
            {
                builder.Append(c);
            }
            return builder.ToString();
        }

        public void Dispose()
        {
            streamReader.Dispose();
            fileStream.Dispose();
        }
    }
}
