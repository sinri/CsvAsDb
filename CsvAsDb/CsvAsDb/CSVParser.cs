using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvAsDb
{
    class CSVParser
    {
        protected bool IgnoreQuotes { get; set; }
        protected int CsvColumnLimit { get; set; }
        protected int TopIgnoreRows { get; set; }
        protected int BottomIgnoreRows { get; set; }
        protected bool HasHeader { get; set; }

        protected CsvReader csvReader;
        //protected CsvWriter csvWriter;
        
        protected List<String> csvHeaders;
        protected List<String> autoFieldNames;
        //protected Dictionary<string, string> headerFieldNameDict;

        protected List<Dictionary<String, String>> cacheForBottomIgnoration;

        public CSVParser(int columnLimit, bool hasHeader, int topIgnoreRows,int bottomIgnoreRows,bool ignoreIllegalQutes)
        {
            this.CsvColumnLimit = columnLimit;
            this.TopIgnoreRows = topIgnoreRows;
            this.BottomIgnoreRows = bottomIgnoreRows;
            this.IgnoreQuotes = ignoreIllegalQutes;
            this.HasHeader = hasHeader;
        }

        public List<string> GetCurrentHeaders()
        {
            return csvHeaders;
        }

        public List<string> GetAutoFieldNames()
        {
            return autoFieldNames;
        }

        public Dictionary<string,string> GetHeaderFieldNameDictionary()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            for(int i = 0; i < csvHeaders.Count; i++)
            {
                dict.Add(csvHeaders[i], autoFieldNames[i]);
            }
            return dict;
        }

        public String[] ReadFilesInDir(String dirPath,String limitExt)
        {
            String[] files = Directory.GetFiles(dirPath);
            List<String> array = new List<String>();
            foreach(String file in files)
            {
                if (Path.GetExtension(file).ToLower().Equals(limitExt))
                {
                    array.Add(file);
                }
            }
            return array.ToArray();
        }

        public bool OpenFileAndLoadFields(String file)
        {
            csvReader = new CsvReader(new StreamReader(file, Encoding.Default));
            if (IgnoreQuotes)
            {
                csvReader.Configuration.IgnoreQuotes = true;
            }

            cacheForBottomIgnoration = new List<Dictionary<string, string>>();

            for (int i = 0; i < TopIgnoreRows; i++)
            {
                csvReader.Read();
            }

            csvHeaders = new List<string>();
            autoFieldNames = new List<string>();
            if (HasHeader)
            {
                csvReader.Read();
                csvReader.ReadHeader();

                for (int i = 0; i < CsvColumnLimit; i++)
                {
                    String s = csvReader.GetField(i);
                    csvHeaders.Add(s);
                }
            }
            else
            {
                for (int i = 0; i < CsvColumnLimit; i++)
                {
                    String s = "Field_" + i;
                    csvHeaders.Add(s);
                }
            }

            for (int i = 0; i < CsvColumnLimit; i++)
            {
                String s = "Field_" + i;
                autoFieldNames.Add(s);
            }

            return true;
        }

        protected Dictionary<String,String> ReadOneRow()
        {
            if (csvReader.Read())
            {
                Dictionary<String, String> row = new Dictionary<string, string>();
                for(int i = 0; i < CsvColumnLimit; i++)
                {
                    if(csvReader.TryGetField<String>(i,out string s))
                    {
                        row.Add(csvHeaders[i], s);
                    }
                    else
                    {
                        row.Add(csvHeaders[i], "");
                    }
                }
                return row;
            }
            return null;
        }

        public Dictionary<String, String> SafeReadOneRow()
        {
            Dictionary<String, String> tempRow;
            while ((tempRow = ReadOneRow()) != null)
            {
                cacheForBottomIgnoration.Add(tempRow);
                if (cacheForBottomIgnoration.Count > BottomIgnoreRows)
                {
                    tempRow = cacheForBottomIgnoration[0];
                    cacheForBottomIgnoration.RemoveAt(0);
                    return tempRow;
                }
            }
            return null;
        }

        public void CloseReader()
        {
            if (csvReader == null) throw new Exception("No CSV Reader");
            this.csvReader.Context.Reader.Close();
            this.csvReader = null;
        }
    }
}
