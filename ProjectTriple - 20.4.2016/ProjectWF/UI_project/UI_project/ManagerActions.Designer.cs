namespace UI_project
{
    partial class ManagerActions
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
            this.CompPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.CompDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.TextBox();
            this.Body = new System.Windows.Forms.TextBox();
            this.ConfComp = new System.Windows.Forms.Button();
            this.Back3 = new System.Windows.Forms.Button();
            this.Comptbl = new System.Windows.Forms.DataGridView();
            this.ClientView = new System.Windows.Forms.Panel();
            this.BackButtom2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Clientstbl = new System.Windows.Forms.DataGridView();
            this.AcceptClients = new System.Windows.Forms.Panel();
            this.BackButtom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NotActiveClientstbl = new System.Windows.Forms.DataGridView();
            this.CompPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Comptbl)).BeginInit();
            this.ClientView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clientstbl)).BeginInit();
            this.AcceptClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotActiveClientstbl)).BeginInit();
            this.SuspendLayout();
            // 
            // CompPanel
            // 
            this.CompPanel.Controls.Add(this.label6);
            this.CompPanel.Controls.Add(this.CompDate);
            this.CompPanel.Controls.Add(this.label5);
            this.CompPanel.Controls.Add(this.label3);
            this.CompPanel.Controls.Add(this.label4);
            this.CompPanel.Controls.Add(this.Subject);
            this.CompPanel.Controls.Add(this.Body);
            this.CompPanel.Controls.Add(this.ConfComp);
            this.CompPanel.Controls.Add(this.Back3);
            this.CompPanel.Controls.Add(this.Comptbl);
            this.CompPanel.Location = new System.Drawing.Point(16, 410);
            this.CompPanel.Margin = new System.Windows.Forms.Padding(4);
            this.CompPanel.Name = "CompPanel";
            this.CompPanel.Size = new System.Drawing.Size(1336, 267);
            this.CompPanel.TabIndex = 0;
            this.CompPanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(749, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Complain Date:";
            // 
            // CompDate
            // 
            this.CompDate.Location = new System.Drawing.Point(897, 20);
            this.CompDate.Margin = new System.Windows.Forms.Padding(4);
            this.CompDate.Name = "CompDate";
            this.CompDate.Size = new System.Drawing.Size(265, 22);
            this.CompDate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(749, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Complain Body:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(237, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client\'s complains";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(749, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Subject:";
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(897, 52);
            this.Subject.Margin = new System.Windows.Forms.Padding(4);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(275, 22);
            this.Subject.TabIndex = 5;
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.SystemColors.Window;
            this.Body.Location = new System.Drawing.Point(897, 94);
            this.Body.Margin = new System.Windows.Forms.Padding(4);
            this.Body.Multiline = true;
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(275, 133);
            this.Body.TabIndex = 4;
            // 
            // ConfComp
            // 
            this.ConfComp.Enabled = false;
            this.ConfComp.Location = new System.Drawing.Point(827, 235);
            this.ConfComp.Margin = new System.Windows.Forms.Padding(4);
            this.ConfComp.Name = "ConfComp";
            this.ConfComp.Size = new System.Drawing.Size(196, 28);
            this.ConfComp.TabIndex = 3;
            this.ConfComp.Text = "Remove Current Complain";
            this.ConfComp.UseVisualStyleBackColor = true;
            this.ConfComp.Click += new System.EventHandler(this.ConfComp_Click);
            // 
            // Back3
            // 
            this.Back3.Location = new System.Drawing.Point(1099, 235);
            this.Back3.Margin = new System.Windows.Forms.Padding(4);
            this.Back3.Name = "Back3";
            this.Back3.Size = new System.Drawing.Size(100, 28);
            this.Back3.TabIndex = 1;
            this.Back3.Text = "Back";
            this.Back3.UseVisualStyleBackColor = true;
            this.Back3.Click += new System.EventHandler(this.Back3_Click);
            // 
            // Comptbl
            // 
            this.Comptbl.AllowUserToAddRows = false;
            this.Comptbl.AllowUserToDeleteRows = false;
            this.Comptbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Comptbl.Location = new System.Drawing.Point(25, 38);
            this.Comptbl.Margin = new System.Windows.Forms.Padding(4);
            this.Comptbl.Name = "Comptbl";
            this.Comptbl.Size = new System.Drawing.Size(669, 212);
            this.Comptbl.TabIndex = 0;
            this.Comptbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.Comptbl.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Comptbl_RowHeaderMouseClick);
            // 
            // ClientView
            // 
            this.ClientView.BackColor = System.Drawing.SystemColors.Control;
            this.ClientView.Controls.Add(this.BackButtom2);
            this.ClientView.Controls.Add(this.label2);
            this.ClientView.Controls.Add(this.Clientstbl);
            this.ClientView.Location = new System.Drawing.Point(719, 15);
            this.ClientView.Margin = new System.Windows.Forms.Padding(4);
            this.ClientView.Name = "ClientView";
            this.ClientView.Size = new System.Drawing.Size(637, 410);
            this.ClientView.TabIndex = 0;
            this.ClientView.Visible = false;
            // 
            // BackButtom2
            // 
            this.BackButtom2.Location = new System.Drawing.Point(267, 359);
            this.BackButtom2.Margin = new System.Windows.Forms.Padding(4);
            this.BackButtom2.Name = "BackButtom2";
            this.BackButtom2.Size = new System.Drawing.Size(100, 28);
            this.BackButtom2.TabIndex = 2;
            this.BackButtom2.Text = "Back";
            this.BackButtom2.UseVisualStyleBackColor = true;
            this.BackButtom2.Click += new System.EventHandler(this.BackButtom2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client View";
            // 
            // Clientstbl
            // 
            this.Clientstbl.AllowUserToAddRows = false;
            this.Clientstbl.AllowUserToDeleteRows = false;
            this.Clientstbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Clientstbl.Location = new System.Drawing.Point(25, 49);
            this.Clientstbl.Margin = new System.Windows.Forms.Padding(4);
            this.Clientstbl.Name = "Clientstbl";
            this.Clientstbl.ReadOnly = true;
            this.Clientstbl.Size = new System.Drawing.Size(587, 303);
            this.Clientstbl.TabIndex = 0;
            // 
            // AcceptClients
            // 
            this.AcceptClients.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AcceptClients.Controls.Add(this.BackButtom);
            this.AcceptClients.Controls.Add(this.label1);
            this.AcceptClients.Controls.Add(this.NotActiveClientstbl);
            this.AcceptClients.Location = new System.Drawing.Point(16, 15);
            this.AcceptClients.Margin = new System.Windows.Forms.Padding(4);
            this.AcceptClients.Name = "AcceptClients";
            this.AcceptClients.Size = new System.Drawing.Size(695, 410);
            this.AcceptClients.TabIndex = 2;
            this.AcceptClients.Visible = false;
            this.AcceptClients.Paint += new System.Windows.Forms.PaintEventHandler(this.AcceptClients_Paint);
            // 
            // BackButtom
            // 
            this.BackButtom.Location = new System.Drawing.Point(278, 359);
            this.BackButtom.Margin = new System.Windows.Forms.Padding(4);
            this.BackButtom.Name = "BackButtom";
            this.BackButtom.Size = new System.Drawing.Size(100, 28);
            this.BackButtom.TabIndex = 3;
            this.BackButtom.Text = "Back";
            this.BackButtom.UseVisualStyleBackColor = true;
            this.BackButtom.Click += new System.EventHandler(this.BackButtom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Activate and deactivate clients";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NotActiveClientstbl
            // 
            this.NotActiveClientstbl.AllowUserToAddRows = false;
            this.NotActiveClientstbl.AllowUserToDeleteRows = false;
            this.NotActiveClientstbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotActiveClientstbl.Location = new System.Drawing.Point(39, 49);
            this.NotActiveClientstbl.Margin = new System.Windows.Forms.Padding(4);
            this.NotActiveClientstbl.Name = "NotActiveClientstbl";
            this.NotActiveClientstbl.Size = new System.Drawing.Size(605, 302);
            this.NotActiveClientstbl.TabIndex = 0;
            this.NotActiveClientstbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NotActiveClientstbl_CellContentClick);
            // 
            // ManagerActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 692);
            this.Controls.Add(this.ClientView);
            this.Controls.Add(this.AcceptClients);
            this.Controls.Add(this.CompPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerActions";
            this.Text = "ManagerActions";
            this.Load += new System.EventHandler(this.ManagerActions_Load);
            this.CompPanel.ResumeLayout(false);
            this.CompPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Comptbl)).EndInit();
            this.ClientView.ResumeLayout(false);
            this.ClientView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clientstbl)).EndInit();
            this.AcceptClients.ResumeLayout(false);
            this.AcceptClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotActiveClientstbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CompPanel;
        private System.Windows.Forms.Panel ClientView;
        private System.Windows.Forms.Panel AcceptClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView NotActiveClientstbl;
        private System.Windows.Forms.DataGridView Clientstbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BackButtom;
        private System.Windows.Forms.Button BackButtom2;
        private System.Windows.Forms.DataGridView Comptbl;
        private System.Windows.Forms.Button Back3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.TextBox Body;
        private System.Windows.Forms.Button ConfComp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker CompDate;

    }
}