using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Company.Models
{
    public interface ICommonModel
    {
        void AnalyseData(DataRow row);
    }

    public static class CommanClass
    {
        public static void ConvertTableToList<T>(this List<T> list, DataTable table) where T : ICommonModel, new()
        {
            if (table == null || table.Rows.Count <= 0) return;
            foreach (DataRow row in table.Rows)
            {
                T t = new T();
                t.AnalyseData(row);
                list.Add(t);
            }
        }
    }
}