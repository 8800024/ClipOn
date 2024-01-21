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
        public string cs = @"URI=file" + Path.Combine(Application.StartupPath + "\\dataTable.db");

        SQLiteConnection? con;
        SQLiteCommand? cmd;
        SQLiteDataReader? dr;

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateDB();
        }

        // DB を作成
        private void CreateDB()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@" Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "CREATE TABLE Topicks(date TEXT, person TEXT, description TEXT)";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
                return;
        }

        private void DataShow()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM Topicks";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                // ここで DB から読みだしたデータを使って処理をする
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            detail.ShowDialog();
            GenerateTicket();
        }

        private void GenerateTicket()
        {
            flowLayoutPanel1.Controls.Add(t);
            t.labelTicketDate.Text = detail.date;
            t.labelTicketPerson.Text = detail.person;
            t.labelTicketDescription.Text = detail.description;
            t.Show();

            t.BringToFront();
        }

    }
}
