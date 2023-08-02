namespace ClientManagementApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFullName = new TextBox();
            lblFullName = new Label();
            btnAddClient = new Button();
            lstClients = new ListBox();
            lblSelectedAttachment = new Label();
            btnAttachFile = new Button();
            txtSubject = new TextBox();
            txtBody = new TextBox();
            txtRecipientEmail = new TextBox();
            btnSend = new Button();
            txtPhoneNumber = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(146, 86);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(200, 27);
            txtFullName.TabIndex = 0;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(104, 89);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(36, 20);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "ПІБ:";
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(185, 185);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(122, 30);
            btnAddClient.TabIndex = 2;
            btnAddClient.Text = "Додати клієнта";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // lstClients
            // 
            lstClients.FormattingEnabled = true;
            lstClients.ItemHeight = 20;
            lstClients.Location = new Point(12, 292);
            lstClients.Name = "lstClients";
            lstClients.Size = new Size(779, 344);
            lstClients.TabIndex = 3;
            // 
            // lblSelectedAttachment
            // 
            lblSelectedAttachment.AutoSize = true;
            lblSelectedAttachment.Location = new Point(597, 25);
            lblSelectedAttachment.Name = "lblSelectedAttachment";
            lblSelectedAttachment.Size = new Size(143, 20);
            lblSelectedAttachment.TabIndex = 4;
            lblSelectedAttachment.Text = "Вибрані вкладення";
            // 
            // btnAttachFile
            // 
            btnAttachFile.Location = new Point(491, 20);
            btnAttachFile.Name = "btnAttachFile";
            btnAttachFile.Size = new Size(100, 30);
            btnAttachFile.TabIndex = 5;
            btnAttachFile.Text = "Прикріпити файл";
            btnAttachFile.UseVisualStyleBackColor = true;
            btnAttachFile.Click += btnAttachFile_Click;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(491, 56);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(300, 27);
            txtSubject.TabIndex = 6;
            // 
            // txtBody
            // 
            txtBody.Location = new Point(491, 86);
            txtBody.Multiline = true;
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(300, 100);
            txtBody.TabIndex = 7;
            // 
            // txtRecipientEmail
            // 
            txtRecipientEmail.Location = new Point(491, 192);
            txtRecipientEmail.Name = "txtRecipientEmail";
            txtRecipientEmail.Size = new Size(200, 27);
            txtRecipientEmail.TabIndex = 8;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(491, 226);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(100, 30);
            btnSend.TabIndex = 9;
            btnSend.Text = "Надіслати";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(146, 119);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 27);
            txtPhoneNumber.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 122);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 11;
            label1.Text = "Номер Телефону:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(146, 152);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 155);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 13;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 59);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 14;
            label3.Text = "Заголовок:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(437, 124);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 15;
            label4.Text = "Текст:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 195);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 16;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(501, 269);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 17;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 269);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 18;
            label7.Text = "ПІБ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(258, 269);
            label8.Name = "label8";
            label8.Size = new Size(131, 20);
            label8.TabIndex = 19;
            label8.Text = "Номер Телефону:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 654);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label1);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(btnAddClient);
            Controls.Add(lstClients);
            Controls.Add(lblSelectedAttachment);
            Controls.Add(btnAttachFile);
            Controls.Add(txtSubject);
            Controls.Add(txtBody);
            Controls.Add(txtRecipientEmail);
            Controls.Add(btnSend);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private Label lblFullName;
        private Button btnAddClient;
        private ListBox lstClients;
        private Label lblSelectedAttachment;
        private Button btnAttachFile;
        private TextBox txtSubject;
        private TextBox txtBody;
        private TextBox txtRecipientEmail;
        private Button btnSend;
        private TextBox txtPhoneNumber;
        private Label label1;
        private TextBox txtEmail;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}