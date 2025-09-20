using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ClupManagementDataAccessLayer
{
    public class TableDTO
    {
        public int Tab_ID { get; set; }
        public string TableName { get; set; }

        public TableDTO(int Tab_ID, string TableName)
        {
            this.Tab_ID = Tab_ID;

            this.TableName = TableName;
        }
    }

    public class Table_Data
    {
        public static List<TableDTO> GetAllTables()
        {
            List<TableDTO> TableDTOList = new List<TableDTO>();

            try
            {
                using (SqlConnection connection = DataAccessHelper.GetConnection())
                {
                    string query = "select * from [dbo].[Table] ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TableDTOList.Add(new TableDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("Tab_ID")),
                                    reader.GetString(reader.GetOrdinal("TableName"))
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return TableDTOList;
        }

        public static TableDTO FindByID(int id)
        {
            string query = "SELECT Tab_ID, TableName FROM [dbo].[Table] WHERE Tab_ID = @id";

            using (var connection = DataAccessHelper.GetConnection())
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new TableDTO
                        (
                            reader.GetInt32(reader.GetOrdinal("Tab_ID")),
                            reader.GetString(reader.GetOrdinal("TableName"))
                        );
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }


    }

}
