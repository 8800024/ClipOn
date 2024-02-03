using ClipOn;
using System.Data.SQLite;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private NotifyIcon? notifyIcon;
        Detail detail = new Detail();
        TicketData ticketData = new TicketData();
        public Form1()
        {
            InitializeComponent();
            InitializeTrayIcon();
        }

        private void InitializeTrayIcon()
        {
            notifyIcon = new NotifyIcon
            {
                Icon = new Icon("Icon.ico"),
                Visible = true
            };

            notifyIcon.Click += NotifyIcon_Click;

            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("表示", null, ShowFormClick);
            contextMenu.Items.Add("終了", null, ExitClick);
            notifyIcon.ContextMenuStrip = contextMenu;
        }

        private void ShowFormClick(object? sender, EventArgs e)
        {
            ShowForm();
        }

        private void ExitClick(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NotifyIcon_Click(object? sender, EventArgs e)
        {
            if (e is MouseEventArgs mouseEventArgs && mouseEventArgs.Button == MouseButtons.Left)
            {
                ShowForm();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
            }
            else if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                // 通知アイコンからの終了処理の場合は何もしない
            }
        }
        private void ShowForm()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
            }

            Activate();
        }


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