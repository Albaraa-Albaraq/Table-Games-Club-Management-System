using System;
using System.Data.SqlClient;

namespace ClupManagementDataAccessLayer
{
    public class TableFeesDTO
    {
        public int FeeId { get; set; }
        public int TableId { get; set; }
        public float? FeesByHour { get; set; }
        public float? FeesByMatch { get; set; }
        public DateTime CreatedAt { get; set; }

        public TableFeesDTO(int TF_ID, int Tab_ID, float? FeesByHour, float? FeesByMatch, DateTime CreatedAt)
        {
            this.FeeId = TF_ID;
            this.TableId = Tab_ID;
            this.FeesByHour = FeesByHour;
            this.FeesByMatch = FeesByMatch;
            this.CreatedAt = CreatedAt;
        }
    }


    public class TableFeesData
    {
        public static TableFeesDTO FindById(int Tab_ID)
        {
            string query = "select top 1 [Table].Tab_ID,TF_ID ,TableName,FeesByHour,FeesByMatch,CreatedAt from [dbo].[Table] inner join Table_Fees TF on TF.Tab_ID =  [Table].Tab_ID where [Table].Tab_ID = " + Tab_ID + "  order by CreatedAt desc";

            using (var connection = DataAccessHelper.GetConnection())
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new TableFeesDTO(
                            reader.GetInt32(reader.GetOrdinal("TF_ID")),
                            reader.GetInt32(reader.GetOrdinal("Tab_ID")),
                            reader.IsDBNull(reader.GetOrdinal("FeesByHour"))
                                ? (float?)null
                                : (float)reader.GetDouble(reader.GetOrdinal("FeesByHour")),
                            reader.IsDBNull(reader.GetOrdinal("FeesByMatch"))
                                ? (float?)null
                                : (float)reader.GetDouble(reader.GetOrdinal("FeesByMatch")),
                            reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
);
                    }
                    else
                        return null;
                }
            }
        }

        public static int Save(TableFeesDTO tablefees)
        {
            string query = @"INSERT INTO [dbo].[Table_Fees] ([Tab_ID],[FeesByHour],[FeesByMatch],[CreatedAt])VALUES(@Tab_ID,@FeesByHour,@FeesByMatch,SYSDATETIME()) select SCOPE_IDENTITY()";

            using (var connection = DataAccessHelper.GetConnection())
            using (var command = new SqlCommand(query, connection))
            {
                if (tablefees.FeesByHour == null && tablefees.FeesByMatch == null)
                    return -1;
                command.Parameters.AddWithValue("@Tab_ID", tablefees.TableId);

                if (tablefees.FeesByHour == null)
                    command.Parameters.AddWithValue("@FeesByHour", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@FeesByHour", tablefees.FeesByHour);

                if (tablefees.FeesByMatch == null)
                    command.Parameters.AddWithValue("@FeesByMatch", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@FeesByMatch", tablefees.FeesByMatch);

                connection.Open();
                object obj = command.ExecuteScalar();
                if (obj == DBNull.Value)
                    return -1;
                else
                    return Convert.ToInt32(obj);
            }

        }

    }
}
