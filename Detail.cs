namespace WinFormsApp1
{
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
        }

        public int count { get; set; } = 0;
        public string date { get; private set; } = "";
        public string person { get; private set; } = "";
        public string description { get; private set; } = "";

        private void Detail_Load(object sender, EventArgs e)
        {

        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            date = monthCalendar1.SelectionEnd.ToShortDateString();
            person = textBoxPerson.Text;
            description = textBoxDescription.Text;
            if (string.IsNullOrEmpty(person) | string.IsNullOrEmpty(description))
            {
                MessageBox.Show("データを入力してください。");
                return;
            }

            MessageBox.Show("予定を追加しました。\r\n[" + description + "]");
            textBoxPerson.Clear();
            textBoxDescription.Clear();
            this.Close();
        }

        private void textBoxDetail_TextChanged(object sender, EventArgs e)
        {
            const int COUNT = 72;
            int count = COUNT - textBoxDescription.Text.Length;
            labelStrCount.Text = $"残り：{count} 文字";
        }


    }
}
