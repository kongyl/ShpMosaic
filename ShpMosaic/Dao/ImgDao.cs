using ShpMosaic.Util;
using System.Collections.Generic;
using System.Data;

namespace ShpMosaic.Dao
{
    class ImgDao
    {
        public static List<string> findNameByYearAndCode(int year, long code)
        {
            List<string> nameList = new List<string>();
            string sql = string.Format("select name from img where year = {0} and ST_Intersects(geom, (select geometry from country where code_new = {1}))", year, code);
            DataTable dataTable = DbUtils.Query(sql);
            foreach (DataRow row in dataTable.Rows)
            {
                nameList.Add(row["name"].ToString());
            }

            return nameList;
        }
    }
}
