namespace UI_project
{
    partial class ManagerActions_Pack
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
            this.label1 = new System.Windows.Forms.Label();
            this.PackStore = new System.Windows.Forms.DataGridView();
            this.AccButton = new System.Windows.Forms.Button();
            this.Bbutton = new System.Windows.Forms.Button();
            this.ConfButton = new System.Windows.Forms.Button();
            this.Rbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PackName = new System.Windows.Forms.TextBox();
            this.AmountOfPacks = new System.Windows.Forms.TextBox();
            this.BoxPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RestrictionBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PackStore)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adding Pack (New / edit)";
            // 
            // PackStore
            // 
            this.PackStore.AllowUserToAddRows = false;
            this.PackStore.AllowUserToDeleteRows = false;
            this.PackStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PackStore.Location = new System.Drawing.Point(472, 101);
            this.PackStore.Name = "PackStore";
            this.PackStore.RowTemplate.Height = 24;
            this.PackStore.Size = new System.Drawing.Size(490, 284);
            this.PackStore.TabIndex = 1;
            // 
            // AccButton
            // 
            this.AccButton.Location = new System.Drawing.Point(631, 391);
            this.AccButton.Name = "AccButton";
            this.AccButton.Size = new System.Drawing.Size(168, 23);
            this.AccButton.TabIndex = 2;
            this.AccButton.Text = "Accept changes";
            this.AccButton.UseVisualStyleBackColor = true;
            this.AccButton.Click += new System.EventHandler(this.AccButton_Click);
            // 
            // Bbutton
            // 
            this.Bbutton.Location = new System.Drawing.Point(846, 442);
            this.Bbutton.Name = "Bbutton";
            this.Bbutton.Size = new System.Drawing.Size(75, 23);
            this.Bbutton.TabIndex = 3;
            this.Bbutton.Text = "Back";
            this.Bbutton.UseVisualStyleBackColor = true;
            this.Bbutton.Click += new System.EventHandler(this.Bbutton_Click);
            // 
            // ConfButton
            // 
            this.ConfButton.Location = new System.Drawing.Point(128, 291);
            this.ConfButton.Name = "ConfButton";
            this.ConfButton.Size = new System.Drawing.Size(75, 23);
            this.ConfButton.TabIndex = 4;
            this.ConfButton.Text = "Add pack";
            this.ConfButton.UseVisualStyleBackColor = true;
            this.ConfButton.Click += new System.EventHandler(this.ConfButton_Click);
            // 
            // Rbutton
            // 
            this.Rbutton.Location = new System.Drawing.Point(280, 291);
            this.Rbutton.Name = "Rbutton";
            this.Rbutton.Size = new System.Drawing.Size(75, 23);
            this.Rbutton.TabIndex = 5;
            this.Rbutton.Text = "Rest";
            this.Rbutton.UseVisualStyleBackColor = true;
            this.Rbutton.Click += new System.EventHandler(this.Rbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(652, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Edit store packs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(153, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Add new Pack";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pack name and information(can include numbers):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Number of packs in store:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Pack Price:";
            // 
            // PackName
            // 
            this.PackName.Location = new System.Drawing.Point(361, 125);
            this.PackName.Name = "PackName";
            this.PackName.Size = new System.Drawing.Size(100, 22);
            this.PackName.TabIndex = 12;
            // 
            // AmountOfPacks
            // 
            this.AmountOfPacks.Location = new System.Drawing.Point(361, 186);
            this.AmountOfPacks.Name = "AmountOfPacks";
            this.AmountOfPacks.Size = new System.Drawing.Size(100, 22);
            this.AmountOfPacks.TabIndex = 14;
            // 
            // BoxPrice
            // 
            this.BoxPrice.Location = new System.Drawing.Point(361, 216);
            this.BoxPrice.Name = "BoxPrice";
            this.BoxPrice.Size = new System.Drawing.Size(100, 22);
            this.BoxPrice.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Restriction:";
            // 
            // RestrictionBox
            // 
            this.RestrictionBox.Location = new System.Drawing.Point(361, 158);
            this.RestrictionBox.Name = "RestrictionBox";
            this.RestrictionBox.Size = new System.Drawing.Size(100, 22);
            this.RestrictionBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(682, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "edit the pack\'s properties in the table below and to abort pack change its packag" +
    "e number in the store to 0.";
            // 
            // ManagerActions_Pack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 491);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RestrictionBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BoxPrice);
            this.Controls.Add(this.AmountOfPacks);
            this.Controls.Add(this.PackName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Rbutton);
            this.Controls.Add(this.ConfButton);
            this.Controls.Add(this.Bbutton);
            this.Controls.Add(this.AccButton);
            this.Controls.Add(this.PackStore);
            this.Controls.Add(this.label1);
            this.Name = "ManagerActions_Pack";
            this.Text = "ManagerActions_Pack";
            ((System.ComponentModel.ISupportInitialize)(this.PackStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PackStore;
        private System.Windows.Forms.Button AccButton;
        private System.Windows.Forms.Button Bbutton;
        private System.Windows.Forms.Button ConfButton;
        private System.Windows.Forms.Button Rbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PackName;
        private System.Windows.Forms.TextBox AmountOfPacks;
        private System.Windows.Forms.TextBox BoxPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RestrictionBox;
        private System.Windows.Forms.Label label6;
    }
}