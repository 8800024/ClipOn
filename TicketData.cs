using System.Data.SQLite;


namespace ClipOn
{
    internal class TicketData
    {
        public int? id { get; set; }
        public string? startDate { get; set; }
        public string? endDate { get; set; }
        public string? date { get; set; }
        public string? person { get; set; }
        public string? description { get; set; }

        public string cs = @" DATA SOURCE=" + Path.Combine(Application.StartupPath + "\\dataTable.db");

        /// <summary>
        /// DB に値を書き込む(新規)
        /// </summary>
        internal void AddRecord()
        {
            string add = "INSERT INTO Topicks(Date, Person, Description) VALUES(@date, @person, @description)";
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(add, con))
                {
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@person", person);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// DB に値を書き込む(上書き)
        /// </summary>
        internal void OverWriteRecord()
        {
            string ow = $"UPDATE Topicks SET Date = @date, Person = @person, Description = @description WHERE Id = @id";

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(ow, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@person", person);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.ExecuteNonQuery();
                }
            }

        }

        /// <summary>
        /// 指定した id に該当するレコードの値を DB から取得する SQL
        /// </summary>
        internal void GetTicketDataFromDb(int TicketId)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                var sql = "SELECT * FROM Topicks WHERE id = @id";
                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", TicketId);
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            id = Convert.ToInt32(dr["Id"]);
                            date = (string)dr["Date"];
                            person = (string)dr["Person"];
                            description = (string)dr["Description"];
                        }
                    }
                }
            }
        }

        /// <summary>
        /// DB からレコードを削除する SQL
        /// </summary>
        internal void DeleteTicketFromDb(int TicketId)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                var sql = "DELETE FROM Topicks WHERE id = @id";
                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", TicketId);
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
