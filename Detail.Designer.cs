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
            textBoxDescription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            monthCalendar1 = new MonthCalendar();
            labelStrCount = new Label();
            labelTicketId = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(267, 399);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(81, 44);
            buttonSubmit.TabIndex = 20;
            buttonSubmit.Text = "登録";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonEntry_Click;
            // 
            // textBoxPerson
            // 
            textBoxPerson.Font = new Font("Yu Gothic UI", 12F);
            textBoxPerson.Location = new Point(12, 260);
            textBoxPerson.Name = "textBoxPerson";
            textBoxPerson.Size = new Size(200, 29);
            textBoxPerson.TabIndex = 10;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Yu Gothic UI", 12F);
            textBoxDescription.Location = new Point(12, 324);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(336, 29);
            textBoxDescription.TabIndex = 12;
            textBoxDescription.TextChanged += textBoxDetail_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 44;
            label1.Text = "日付";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9F);
            label2.Location = new Point(12, 242);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 55;
            label2.Text = "誰？";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 9F);
            label3.Location = new Point(12, 306);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 66;
            label3.Text = "どんな用事？";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 32);
            monthCalendar1.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            // 
            // labelStrCount
            // 
            labelStrCount.AutoSize = true;
            labelStrCount.Font = new Font("Yu Gothic UI", 9F);
            labelStrCount.Location = new Point(267, 356);
            labelStrCount.Name = "labelStrCount";
            labelStrCount.Size = new Size(81, 15);
            labelStrCount.TabIndex = 88;
            labelStrCount.Text = "残り ：48 文字";
            // 
            // labelTicketId
            // 
            labelTicketId.AutoSize = true;
            labelTicketId.Font = new Font("Yu Gothic UI", 9F);
            labelTicketId.Location = new Point(84, 213);
            labelTicketId.Name = "labelTicketId";
            labelTicketId.Size = new Size(0, 15);
            labelTicketId.TabIndex = 89;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 9F);
            label4.Location = new Point(11, 213);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 90;
            label4.Text = "TicketId :";
            // 
            // Detail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 455);
            Controls.Add(label4);
            Controls.Add(labelTicketId);
            Controls.Add(labelStrCount);
            Controls.Add(monthCalendar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxPerson);
            Controls.Add(buttonSubmit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Detail";
            Text = "予定登録 / 編集画面";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSubmit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelStrCount;
        internal TextBox textBoxPerson;
        internal TextBox textBoxDescription;
        internal MonthCalendar monthCalendar1;
        private Label labelTicketId;
        private Label label4;
    }
}