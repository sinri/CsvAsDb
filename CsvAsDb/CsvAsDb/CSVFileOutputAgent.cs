using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvAsDb
{
    class CSVFileOutputAgent
    {
        
        protected CsvWriter csvWriter;

        public CSVFileOutputAgent(String file,bool append)
        {
            resetOpenWriter(file, append);
        }

        public void resetOpenWriter(String file, bool append)
        {
            csvWriter = new CsvWriter(new StreamWriter(file, append, Encoding.Default));
        }

        public void WriteHeaderRow(List<String> headers)
        {
            foreach(var header in headers)
            {
                csvWriter.WriteField(header);
            }
            csvWriter.NextRecord();
        }
        
        public void WriteOneRowWithColumnIndex(List<String> row)
        {
            foreach (var item in row)
            {
                csvWriter.WriteField(item);
            }
            csvWriter.NextRecord();
        }

        public void FinishWrite()
        {
            csvWriter.Flush();
            csvWriter.Context.Writer.Close();
            csvWriter = null;

        }
    }
}
