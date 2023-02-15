using SPGenerator.DataModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPGenerator.Core
{
    class SearchSPGenerator : BaseSPGenerator
    {

        protected override string GetSpName(string tableName)
        {
            return prefixSearchSp + tableName;
        }

        protected override void GenerateStatement(string tableName, StringBuilder sb, List<DBTableColumnInfo> selectedFields, List<DBTableColumnInfo> whereConditionFields)
        {
            StringBuilder sbFields = new StringBuilder();
            StringBuilder sbValues = new StringBuilder();
            foreach (DBTableColumnInfo colInf in selectedFields)
            {
                if (colInf.Exclude)
                    continue;
                //sbValues.Append(prefixInputParameter + colInf.ColumnName + ",");
                sbFields.Append(WrapIfKeyWord(colInf.ColumnName) + ",");
            }
            sb.Append(Environment.NewLine + "\tSelect  " + sbFields.ToString().TrimEnd(',') + " From " + WrapIfKeyWord(tableName));
            sb[sb.Length - 1] = ' ';
            GenerateWhereStatement(whereConditionFields, sb);
            //sb.Append(Environment.NewLine + "\tvalues(" + sbValues.ToString().TrimEnd(',') + ")");
        }
    }
}
