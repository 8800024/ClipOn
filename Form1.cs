using System;
using System.Data;
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

        SQLiteConnection? con;
        SQLiteCommand? cmd;
        SQLiteDataReader? dr;

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateDB();
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
                    string sql = "CREATE TABLE Topicks(date TEXT, person TEXT, description TEXT)";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
                return;
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
            string add = $"Insert Into Topicks(date, person, description) Values('{detail.date}','{detail.person}','{detail.description}')";

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(add, con))
                {
                    cmd.ExecuteNonQuery();
                }
                con!.Close();
            }
        }

        private void GenerateTicket()
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                var sql = "SELECT * FROM Topicks";
                using (var cmd = new SQLiteCommand(sql, con))
                {
                    using(var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            flowLayoutPanel1.Controls.Add(t);
                            t.labelTicketDate.Text = (string)dr["date"];
                            t.labelTicketPerson.Text = (string)dr["person"];
                            t.labelTicketDescription.Text = (string)dr["description"];
                            t.Show();
                            t.BringToFront();
                        }
                        dr!.Close();
                    }
                }
                con!.Close();
            }
        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            MessageBox.Show("Control is Removed.");
        }
    }
}
