using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvAsDb
{
    class PluginInterface
    {
        protected readonly Form1 TheHostForm;

        public PluginInterface(Form1 form)
        {
            this.TheHostForm = form;
        }

        virtual public string GetSqlTemplate(string CurrentTableName)
        {
            //TheHostForm.WriteLog("PluginInterface.GetSqlTemplate running", "DEBUG");
            return "select * \r\nfrom " + CurrentTableName + " \r\nlimit 5";
        }
        virtual public void PreprocessRawRow(Dictionary<string, string> dataRow, Dictionary<string, string> headerFieldNameMap)
        {
            //TheHostForm.WriteLog("PluginInterface.PreprocessRawRow running", "DEBUG");
            // do nothing
        }

        virtual public List<string> ExtraFields()
        {
            return null;
        }

        public static PluginInterface buildPluginByCode(String code,Form1 form)
        {
            string upperCode = code.Trim().ToUpper();
            switch (upperCode)
            {
                case "WSQ_A":
                    return new PluginWsqA(form);
                case "YLN_A":
                    return new PluginYlnA(form);
                default:
                    return new PluginInterface(form);
            }
        }
    }
}
