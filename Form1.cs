using ClipOn;
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
        TicketData ticketData = new TicketData();

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateDB();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            GenerateTicket();
        }

        /// <summary>
        ///  DBが存在しない場合、DB を作成
        /// </summary>
        private void CreateDB()
        {
            string path = "dataTable.db";
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@" Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "CREATE TABLE Topicks(Id INTEGER PRIMARY KEY, Date TEXT, Person TEXT, Description TEXT)";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            detail.ShowDialog();
        }

        /// <summary>
        /// DB からレコードを読み出してユーザーコントロールを連続描画
        /// </summary>
        private void GenerateTicket()
        {
            flowLayoutPanel1.Controls.Clear();
            using (var con = new SQLiteConnection(ticketData.cs))
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