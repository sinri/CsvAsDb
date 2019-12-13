using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvAsDb
{
    class PluginYlnA : PluginInterface
    {
        public PluginYlnA(Form1 form):base(form)
        {
            LoadCategoryDictionary();
        }

        
        override public string GetSqlTemplate(string CurrentTableName)
        {
            return @"select 
Field_Category as 归类,
sum(Field_6) as 收入金额,
sum(Field_7) as 支出金额
from "+CurrentTableName+@"
group by Field_Category";
        }
        

        private List<String> RuleColumnNames;
        private List<Dictionary<string, string>> CategoryRules;

        public void LoadCategoryDictionary()
        {
            CategoryRules = TheHostForm.FetchCategoryRules(out RuleColumnNames);
        }

        override public void PreprocessRawRow(Dictionary<string, string> dataRow, Dictionary<string, string> headerFieldNameMap)
        {
            /*
            foreach(var columnName in RuleColumnNames)
            {
                TheHostForm.WriteLog("YLN_A Rule column : " + columnName);
            }
            */

            var v1 = dataRow[headerFieldNameMap["业务类型"]];
            var v2 = dataRow[headerFieldNameMap["备注"]];

            dataRow[headerFieldNameMap["Field_Category"]] = "Unknown Category";
            foreach (var rule in CategoryRules)
            {
                if(v1.Equals(rule["业务类型"]) && v2.StartsWith(rule["备注"]))
                {
                    dataRow[headerFieldNameMap["Field_Category"]] = rule["归类"];
                }
            }
        }

        public override List<string> ExtraFields()
        {
            var x = new List<string>();
            x.Add("Field_Category");
            return x;
        }
    }
}
