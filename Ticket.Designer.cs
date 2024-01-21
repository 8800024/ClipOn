namespace WinFormsApp1
{
    partial class Ticket
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            buttonDelete = new Button();
            labelTicketDate = new Label();
            labelTicketPerson = new Label();
            labelTicketDescription = new Label();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(317, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(34, 29);
            buttonDelete.TabIndex = 0;
            buttonDelete.Text = "Del";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelTicketDate
            // 
            labelTicketDate.AutoSize = true;
            labelTicketDate.Font = new Font("Yu Gothic UI", 10F);
            labelTicketDate.Location = new Point(14, 3);
            labelTicketDate.Name = "labelTicketDate";
            labelTicketDate.Size = new Size(45, 19);
            labelTicketDate.TabIndex = 1;
            labelTicketDate.Text = "label1";
            // 
            // labelTicketPerson
            // 
            labelTicketPerson.AutoSize = true;
            labelTicketPerson.Font = new Font("Yu Gothic UI", 10F);
            labelTicketPerson.Location = new Point(14, 27);
            labelTicketPerson.Name = "labelTicketPerson";
            labelTicketPerson.Size = new Size(45, 19);
            labelTicketPerson.TabIndex = 2;
            labelTicketPerson.Text = "label2";
            // 
            // labelTicketDescription
            // 
            labelTicketDescription.AutoSize = true;
            labelTicketDescription.Font = new Font("Yu Gothic UI", 10F);
            labelTicketDescription.Location = new Point(14, 54);
            labelTicketDescription.Name = "labelTicketDescription";
            labelTicketDescription.Size = new Size(45, 19);
            labelTicketDescription.TabIndex = 3;
            labelTicketDescription.Text = "label3";
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(labelTicketDescription);
            Controls.Add(labelTicketPerson);
            Controls.Add(labelTicketDate);
            Controls.Add(buttonDelete);
            Name = "Ticket";
            Size = new Size(354, 77);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDelete;
        public Label labelTicketDate;
        public Label labelTicketPerson;
        public Label labelTicketDescription;
    }
}
