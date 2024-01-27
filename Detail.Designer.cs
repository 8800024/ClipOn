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
            textBoxPerson.Font = new Font("Yu Gothic UI", 10F);
            textBoxPerson.Location = new Point(12, 223);
            textBoxPerson.Name = "textBoxPerson";
            textBoxPerson.Size = new Size(200, 25);
            textBoxPerson.TabIndex = 10;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Yu Gothic UI", 10F);
            textBoxDescription.Location = new Point(12, 282);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(336, 71);
            textBoxDescription.TabIndex = 12;
            textBoxDescription.TextChanged += textBoxDetail_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9F);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 44;
            label1.Text = "日付";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9F);
            label2.Location = new Point(12, 205);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 55;
            label2.Text = "対象者";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 9F);
            label3.Location = new Point(12, 264);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 66;
            label3.Text = "予定の説明";
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
            labelStrCount.Text = "残り ：72 文字";
            // 
            // Detail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 455);
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
            Text = "Detail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSubmit;
        private TextBox textBoxPerson;
        private TextBox textBoxDescription;
        private Label label1;
        private Label label2;
        private Label label3;
        private MonthCalendar monthCalendar1;
        private Label labelStrCount;
    }
}