using System.Data.SQLite;

namespace WinFormsApp1
{
    public partial class Ticket : UserControl
    {
        public Ticket()
        {
            InitializeComponent();
        }

        int TicketId = 0;
        public string cs = @" Data Source=" + Path.Combine(Application.StartupPath + "\\dataTable.db");

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteTicketFromDatabase();
            Parent.Controls.Remove(this);
            var sql = $"DELETE FROM Topicks WHERE id = {TicketId}";

        }

        private void DeleteTicketFromDatabase()
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

        public void SetData(int id, string date, string person, string description)
        {
            TicketId = id;
            labelCount.Text = TicketId.ToString();
            labelTicketDate.Text = date;
            labelTicketPerson.Text = person;
            labelTicketDescription.Text = description;
        }

    }
}
