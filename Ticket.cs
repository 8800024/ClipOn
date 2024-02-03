using ClipOn;


namespace WinFormsApp1
{
    public partial class Ticket : UserControl
    {
        public Ticket()
        {
            InitializeComponent();
        }

        TicketData ticketData = new TicketData();

        int TicketId = 0;
        public string cs = @" Data Source=" + Path.Combine(Application.StartupPath + "\\dataTable.db");

        /// <summary>
        /// コントロールに情報を表示
        /// </summary>
        public void SetData(int id, string date, string person, string description)
        {
            TicketId = id;
            labelTicketId.Text = TicketId.ToString();
            labelTicketDate.Text = date;
            labelTicketPerson.Text = person;
            labelTicketDescription.Text = description;
        }

        /// <summary>
        /// 対応する id の レコードを DB から削除し、チケットを削除する
        /// </summary>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ticketData.DeleteTicketFromDb(TicketId);
            Dispose();
        }


        /// <summary>
        /// 対応する id の レコードを DB から取得し、Detail 画面を表示する
        /// </summary>
        private void buttonModify_Click(object sender, EventArgs e)
        {
            ticketData.GetTicketDataFromDb(TicketId);
            Detail detail = new Detail();
            detail.SetTicketData(ticketData);
            detail.ShowDialog();

        }
    }
}
