using System.Data.SQLite;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Detail detail = new Detail();
        Ticket t = new Ticket();

        public string path = "dataTable.db";
        public string cs = @" Data Source=" + Path.Combine(Application.StartupPath + "\\dataTable.db");

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateDB();
            CountRecord();
            GenerateTicket();

        }

        /// <summary>
        ///  DB ÇçÏê¨
        /// </summary>
        private void CreateDB()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@" Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "CREATE TABLE Topicks(Id INTEGER, Date TEXT, Person TEXT, Description TEXT)";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            detail.ShowDialog();
            if (string.IsNullOrEmpty(detail.person) | string.IsNullOrEmpty(detail.description))
                return;
            else
                AddParam();
            GenerateTicket();
        }

        private void AddParam()
        {
            string add = $"Insert Into Topicks(Id, Date, Person, Description) Values('{detail.count}','{detail.date}','{detail.person}','{detail.description}')";

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(add, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void CountRecord()
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                var sql = "SELECT coalesce(max(id), 0) + 1 FROM Topicks";
                using (var cmd = new SQLiteCommand(sql, con))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private void GenerateTicket()
        {
            flowLayoutPanel1.Controls.Clear();
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                var sql = "SELECT * FROM Topicks";
                using (var cmd = new SQLiteCommand(sql, con))
                {
                    using (var dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            Ticket t = new Ticket();
                            t.SetData(
                                Convert.ToInt32(dr["Id"]),
                                (string)dr["Date"],
                                (string)dr["Person"],
                                (string)dr["Description"]);
                            flowLayoutPanel1.Controls.Add(t);
                            t.Show();
                            t.BringToFront();
                        }
                    }
                }
            }
        }
    }
}