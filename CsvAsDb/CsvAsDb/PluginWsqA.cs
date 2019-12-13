using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvAsDb
{
    class PluginWsqA : PluginInterface
    {
        List<string> wsq_a_target_list { get; set; }

        public PluginWsqA(Form1 form) : base(form)
        {
            wsq_a_target_list = new List<string>();
            wsq_a_target_list.Add("交易付款");
            wsq_a_target_list.Add("交易退款");
            wsq_a_target_list.Add("在线支付");
        }

        override public string GetSqlTemplate(string CurrentTableName)
        {
            /*
            return  @"select 
Field_10 as  业务类型,
Field_11 as 备注,
Field_5 as 对方账号,
sum(Field_6) as 总收入 ,
sum(Field_7) as 总支出
from " + CurrentTableName + @" 
group by Field_10 ,Field_11 ,Field_5 ";
*/
            return @"select 
Field_10 as  业务类型,
Field_11 as 备注,
Field_5 as 对方账号,
sum(Field_6) as 总收入 ,
sum(Field_7) as 总支出,
sum(Field_6)+sum(Field_7) as 合计
from " + CurrentTableName + @" 
group by Field_10 ,Field_11 ,Field_5 

union all

select
'合计' as  业务类型,
'合计' as 备注,
'合计' as 对方账号,
sum(Field_6) as 总收入 ,
sum(Field_7) as 总支出,
sum(Field_6) + sum(Field_7) as 合计
from  " + CurrentTableName;
        }

        override public void PreprocessRawRow(Dictionary<string,string> dataRow, Dictionary<string, string> headerFieldNameMap)
        {
            if (wsq_a_target_list.Contains(dataRow[headerFieldNameMap["业务类型"]]))
            {
                dataRow[headerFieldNameMap["备注"]] = "";
                dataRow[headerFieldNameMap["对方账号"]] = "";
            }
        }
    }
}
