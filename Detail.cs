using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
        }



        public string date { get; private set; } = "";
        public string person { get; private set; } = "";
        public string description { get; private set; } = "";

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            date = monthCalendar1.SelectionEnd.ToShortDateString();
            person = textBoxPerson.Text;
            description = textBoxDetail.Text;
            if (string.IsNullOrEmpty(person) | string.IsNullOrEmpty(description))
            {
                MessageBox.Show("None.");
                return;
            }

            MessageBox.Show("予定を追加しました。\r\n" + description);
            textBoxPerson.Clear();
            textBoxDetail.Clear();
            this.Close();
        }

        private void textBoxDetail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
