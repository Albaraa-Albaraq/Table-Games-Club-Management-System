using System.Data.SqlClient;
using System;
using static ClupManagementDataAccessLayer.Playedtypes;

namespace ClupManagementDataAccessLayer
{
    public class DuesDTO
    {
        public int Dus_ID { get; set; }
        public int Tab_ID { get; set; }
        public int TF_ID { get; set; }
        public string Person_Name { get; set; } = String.Empty;
        public DateTime DateAndTime { get; set; }
        public enPlayedtypes PlayedType { get; set; }
        public short Value { get; set; }


        public DuesDTO(int Dus_ID, int Tab_ID, int TF_ID, string Person_Name, DateTime DateAndTime, enPlayedtypes PlayedType, short Value)
        {
            this.Dus_ID = Dus_ID;
            this.Tab_ID = Tab_ID;
            this.TF_ID = TF_ID;
            this.Person_Name = Person_Name;
            this.DateAndTime = DateAndTime;
            this.PlayedType = PlayedType;
            this.Value = Value;
        }
    }

    public class DuesData
    {
        public static int AddDuse(DuesDTO due)
        {
            string query = @"INSERT INTO [dbo].[Dues]([Tab_ID],[TF_ID],[PersonNamed],[DateAndTime],[TimeSpendInMin],[NumberOfTimesPlayed]) VALUES (@Tab_ID,@TF_ID,@PersonNamed,@DateAndTime,@TimeSpendInMin,@NumberOfTimesPlayed) ; select SCOPE_IDENTITY();";

            using (var connection = DataAccessHelper.GetConnection())
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Tab_ID", due.Tab_ID);
                command.Parameters.AddWithValue("@TF_ID", due.TF_ID);
                command.Parameters.AddWithValue("@PersonNamed", due.Person_Name);
                command.Parameters.AddWithValue("@DateAndTime", due.DateAndTime);
                if (due.PlayedType == enPlayedtypes.Hourly)
                {
                    command.Parameters.AddWithValue("@TimeSpendInMin", due.Value);
                    command.Parameters.AddWithValue("@NumberOfTimesPlayed", DBNull.Value);
                }
                else if (due.PlayedType == enPlayedtypes.Matches)
                {
                    command.Parameters.AddWithValue("@TimeSpendInMin", DBNull.Value);
                    command.Parameters.AddWithValue("@NumberOfTimesPlayed", due.Value);
                }
                else
                {
                    return -1;
                }


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
