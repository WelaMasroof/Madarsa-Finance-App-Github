﻿namespace madarsa_aaplication
{
    partial class show_expense
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.showdata = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.datashowbutton = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.salescombobox = new System.Windows.Forms.ComboBox();
            this.salesrecord = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesrecord)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.Black;
            this.searchbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.searchbutton.ForeColor = System.Drawing.Color.White;
            this.searchbutton.Location = new System.Drawing.Point(7, 20);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(159, 27);
            this.searchbutton.TabIndex = 5;
            this.searchbutton.Text = "تلاش کریں";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1290, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "مدّ";
            // 
            // showdata
            // 
            this.showdata.BackColor = System.Drawing.Color.Black;
            this.showdata.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showdata.ForeColor = System.Drawing.Color.White;
            this.showdata.Location = new System.Drawing.Point(195, 615);
            this.showdata.Name = "showdata";
            this.showdata.Size = new System.Drawing.Size(180, 35);
            this.showdata.TabIndex = 44;
            this.showdata.Text = "تفصیل";
            this.showdata.UseVisualStyleBackColor = false;
            this.showdata.Click += new System.EventHandler(this.showdata_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(581, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "اخراجات کی تفصیل";
            // 
            // datashowbutton
            // 
            this.datashowbutton.AutoSize = true;
            this.datashowbutton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datashowbutton.Location = new System.Drawing.Point(1194, 176);
            this.datashowbutton.Name = "datashowbutton";
            this.datashowbutton.Size = new System.Drawing.Size(161, 31);
            this.datashowbutton.TabIndex = 46;
            this.datashowbutton.Text = "معلومات دکھائیں";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 31);
            this.label4.TabIndex = 45;
            // 
            // salescombobox
            // 
            this.salescombobox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.salescombobox.FormattingEnabled = true;
            this.salescombobox.Location = new System.Drawing.Point(985, 17);
            this.salescombobox.Name = "salescombobox";
            this.salescombobox.Size = new System.Drawing.Size(283, 27);
            this.salescombobox.TabIndex = 20;
            // 
            // salesrecord
            // 
            this.salesrecord.AllowUserToAddRows = false;
            this.salesrecord.AllowUserToDeleteRows = false;
            this.salesrecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesrecord.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.salesrecord.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.salesrecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesrecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.salesrecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesrecord.DefaultCellStyle = dataGridViewCellStyle2;
            this.salesrecord.Location = new System.Drawing.Point(9, 219);
            this.salesrecord.Name = "salesrecord";
            this.salesrecord.ReadOnly = true;
            this.salesrecord.Size = new System.Drawing.Size(1345, 381);
            this.salesrecord.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 61);
            this.panel1.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.searchbutton);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.salescombobox);
            this.panel2.Controls.Add(this.todate);
            this.panel2.Controls.Add(this.fromdate);
            this.panel2.Location = new System.Drawing.Point(9, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1345, 71);
            this.panel2.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(494, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "تاریخ اختتام";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(876, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "تاریخ آغاز";
            // 
            // todate
            // 
            this.todate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.todate.Location = new System.Drawing.Point(230, 18);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(249, 26);
            this.todate.TabIndex = 25;
            // 
            // fromdate
            // 
            this.fromdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.fromdate.Location = new System.Drawing.Point(615, 18);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(243, 26);
            this.fromdate.TabIndex = 25;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Black;
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.deleteButton.Location = new System.Drawing.Point(9, 615);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(180, 35);
            this.deleteButton.TabIndex = 50;
            this.deleteButton.Text = "حذف کریں";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // show_expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1365, 686);
            this.Controls.Add(this.showdata);
            this.Controls.Add(this.datashowbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salesrecord);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.deleteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "show_expense";
            this.Text = "show_expense";
            this.Load += new System.EventHandler(this.show_expense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesrecord)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showdata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label datashowbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox salescombobox;
        private System.Windows.Forms.DataGridView salesrecord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.DateTimePicker fromdate;
        private System.Windows.Forms.Button deleteButton;
    }
}