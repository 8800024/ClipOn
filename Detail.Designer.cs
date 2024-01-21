namespace WinFormsApp1
{
    partial class Detail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSubmit = new Button();
            textBoxPerson = new TextBox();
            textBoxDetail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            monthCalendar1 = new MonthCalendar();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(267, 399);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(81, 44);
            buttonSubmit.TabIndex = 0;
            buttonSubmit.Text = "登録";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonEntry_Click;
            // 
            // textBoxPerson
            // 
            textBoxPerson.Font = new Font("Yu Gothic UI", 10F);
            textBoxPerson.Location = new Point(12, 223);
            textBoxPerson.Name = "textBoxPerson";
            textBoxPerson.Size = new Size(200, 25);
            textBoxPerson.TabIndex = 1;
            // 
            // textBoxDetail
            // 
            textBoxDetail.Font = new Font("Yu Gothic UI", 10F);
            textBoxDetail.Location = new Point(12, 282);
            textBoxDetail.Multiline = true;
            textBoxDetail.Name = "textBoxDetail";
            textBoxDetail.Size = new Size(336, 71);
            textBoxDetail.TabIndex = 2;
            textBoxDetail.TextChanged += textBoxDetail_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9F);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "日付";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9F);
            label2.Location = new Point(12, 205);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "対象者";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 9F);
            label3.Location = new Point(12, 264);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 6;
            label3.Text = "予定の説明";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 32);
            monthCalendar1.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 9F);
            label4.Location = new Point(267, 356);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 8;
            label4.Text = "残り ：72 文字";
            // 
            // Detail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 455);
            Controls.Add(label4);
            Controls.Add(monthCalendar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDetail);
            Controls.Add(textBoxPerson);
            Controls.Add(buttonSubmit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Detail";
            Text = "Detail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSubmit;
        private TextBox textBoxPerson;
        private TextBox textBoxDetail;
        private Label label1;
        private Label label2;
        private Label label3;
        private MonthCalendar monthCalendar1;
        private Label label4;
    }
}