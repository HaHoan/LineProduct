using Line_Production.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Production.Database
{
    /*
     * db : 172.28.10.9 / UMC3000 / BCLBFLM 
     */
    public class HondaLocks
    {
        public object Insert(object o)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insert into HondaLock(ProductionID,BoxID,BoardNo,UpdateTime,Status,Updator_Code,Updator_Name) values(@ProductionID,@BoxID,@BoardNo,@UpdateTime,@Status,@Updator_Code,@Updator_Name);SELECT CAST(scope_identity() AS int)", DataProvider.Instance.DB))
                {
                    cmd.Parameters.AddWithValue("@ProductionID", (o as HondaLock).ProductionID);
                    cmd.Parameters.AddWithValue("@BoxID", (o as HondaLock).BoxID);
                    cmd.Parameters.AddWithValue("@BoardNo", (o as HondaLock).BoardNo);
                    cmd.Parameters.AddWithValue("@UpdateTime", (o as HondaLock).UpdateTime);
                    cmd.Parameters.AddWithValue("@Status", (o as HondaLock).Status ?? "");
                    cmd.Parameters.AddWithValue("@Updator_Code", (o as HondaLock).Update_Code ?? "");
                    cmd.Parameters.AddWithValue("@Updator_Name", (o as HondaLock).Update_Name ?? "");
                    (o as HondaLock).ID = (int)cmd.ExecuteScalar();
                    return o;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return null;
            }
        }
        public bool KiemTraBanMachDaBan(string mathung, string banmach)
        {
            var list = new List<int>();
            try
            {
                string sql = "select * from HondaLock where BoxID = '" + mathung + "' and BoardNo = '" + banmach + "';";
                SqlCommand command = new SqlCommand(sql, DataProvider.Instance.DB);

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message.ToString());
                return false;
            }
            return false;
        }

        public int SoLuongBanMachDaDem(string mathung, string Model)
        {
            try
            {
                string sql = "select count(BoxID) from HondaLock where ProductionID = '" + Model + "' and BoxID = '" + mathung + "'";
                SqlCommand command = new SqlCommand(sql, DataProvider.Instance.DB);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
            catch (Exception e)
            {
                Console.Write(e.Message.ToString());
                return 0;
            }
        }

        public int SoLuongThungDaDem(string Model)
        {
            try
            {
                string sql = "select count(BoxID) from (select BoxID,count(*) sothung from HondaLock where ProductionID = '" + Model + "' group by BoxID) as thungdadem";
                SqlCommand command = new SqlCommand(sql, DataProvider.Instance.DB);
                Int32 count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
            catch (Exception e)
            {
                Console.Write(e.Message.ToString());
                return 0;
            }
        }

    }
}
