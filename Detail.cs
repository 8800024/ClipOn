using ClipOn;

namespace WinFormsApp1
{
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
        }

        TicketData ticketData = new TicketData();
        string? dateS, dateE;

        /// <summary>
        /// フォームに入力した値を ticketData のプロパティに格納する
        /// </summary>
        private void buttonEntry_Click(object sender, EventArgs e)
        {
            if(int.TryParse(labelTicketId.Text, out int ret))
                ticketData.id = ret;
            else
                ticketData.id = null;
            ticketData.person = textBoxPerson.Text;
            ticketData.description = textBoxDescription.Text;
            // エラー判定
            if (string.IsNullOrEmpty(ticketData.person) | string.IsNullOrEmpty(ticketData.description))
            {
                MessageBox.Show("データを入力してください。");
                return;
            }

            ConvertSelectedDatesToMonthFormat();
            if (dateS == dateE)
                ticketData.date = dateE;
            else
            {
                ticketData.startDate = dateS;
                ticketData.endDate = dateE;
                ticketData.date = dateS + "～"+ dateE;
            }

            if(!ticketData.id.HasValue)
                ticketData.AddRecord();  // 入力漏れがなければ DB に登録
            else
                ticketData.OverWriteRecord();  // DB に上書き登録

                MessageBox.Show("予定を追加しました。\r\n[" + ticketData.description + "]");
            monthCalendar1.SetDate(DateTime.Now);
            textBoxPerson.Clear();
            textBoxDescription.Clear();
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// チケットデータをフォームにセットするメソッド
        /// </summary>
        internal void SetTicketData(TicketData data)
        {
            labelTicketId.Text = data.id.ToString();
            if (!data.date.Contains("～"))
            {
                monthCalendar1.SelectionStart = Convert.ToDateTime(data.date);
                monthCalendar1.SelectionEnd = Convert.ToDateTime(data.date);
            }
            else
            {
                string[] dates = data.date.Split('～');
                monthCalendar1.SelectionStart = Convert.ToDateTime(dates[0]);
                monthCalendar1.SelectionEnd = Convert.ToDateTime(dates[1]);
            }
            textBoxPerson.Text = data.person;
            textBoxDescription.Text = data.description;
        }

        /// <summary>
        /// カレンダーで選択された日付を月形式の文字列に変換する
        /// </summary>
        internal void ConvertSelectedDatesToMonthFormat()
        {
            dateS = monthCalendar1.SelectionStart.ToString("M");
            dateE = monthCalendar1.SelectionEnd.ToString("M");
        }

        /// <summary>
        /// 入力文字数をカウント
        /// </summary>
        private void textBoxDetail_TextChanged(object sender, EventArgs e)
        {
            const int COUNTMAX = 48;
            int count = 0;
            foreach(char c in textBoxDescription.Text)
            {
                // 文字のUnicodeコードポイントを取得
                int codePoint = Char.ConvertToUtf32(c.ToString(), 0);
                // Unicodeコードポイントが半角文字の範囲であるか判定
                if (codePoint >= 0x0020 && codePoint <= 0x7E)
                    count += 1; // 半角文字
                else
                    count += 2; // 全角文字
            }

            count = COUNTMAX - count;
            labelStrCount.Text = $"残り：{count} 文字";
        }
    }
}
