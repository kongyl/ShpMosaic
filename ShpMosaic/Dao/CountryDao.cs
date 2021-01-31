using ShpMosaic.Util;
using System;
using System.Collections.Generic;
using System.Data;

namespace ShpMosaic.Dao
{
    class CountryDao
    {
        private CountryDao() { }

        public static List<long> FindAllCode()
        {
            List<long> codeList = new List<long>();

            string sql = "SELECT code_new from country";
            try
            {
                DataTable table = DbUtils.Query(sql);
                foreach (DataRow row in table.Rows)
                {
                    codeList.Add((long)row["code_new"]);
                }
            }
            catch (Exception)
            {
                return null;
            }

            return codeList;
        }
    }
}
