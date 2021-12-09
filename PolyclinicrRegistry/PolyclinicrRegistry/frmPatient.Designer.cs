namespace PolyclinicrRegistry
{
    partial class frmPatient
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.новыйПациентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьСведенияПоПациентуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.выбратьПациентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.g2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPolice = new System.Windows.Forms.TextBox();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOtc = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtFam = new System.Windows.Forms.TextBox();
            this.g3 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.dtpFind = new System.Windows.Forms.DateTimePicker();
            this.r5 = new System.Windows.Forms.RadioButton();
            this.r4 = new System.Windows.Forms.RadioButton();
            this.r3 = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.g2.SuspendLayout();
            this.g3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1059, 341);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView.Location = new System.Drawing.Point(8, 23);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(1043, 300);
            this.dataGridView.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйПациентToolStripMenuItem,
            this.изменитьСведенияПоПациентуToolStripMenuItem,
            this.toolStripMenuItem1,
            this.поискToolStripMenuItem,
            this.toolStripMenuItem2,
            this.выбратьПациентаToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(308, 140);
            // 
            // новыйПациентToolStripMenuItem
            // 
            this.новыйПациентToolStripMenuItem.Name = "новыйПациентToolStripMenuItem";
            this.новыйПациентToolStripMenuItem.Size = new System.Drawing.Size(307, 24);
            this.новыйПациентToolStripMenuItem.Text = "Новый пациент";
            this.новыйПациентToolStripMenuItem.Click += new System.EventHandler(this.новыйПациентToolStripMenuItem_Click);
            // 
            // изменитьСведенияПоПациентуToolStripMenuItem
            // 
            this.изменитьСведенияПоПациентуToolStripMenuItem.Name = "изменитьСведенияПоПациентуToolStripMenuItem";
            this.изменитьСведенияПоПациентуToolStripMenuItem.Size = new System.Drawing.Size(307, 24);
            this.изменитьСведенияПоПациентуToolStripMenuItem.Text = "Изменить сведения по пациенту";
            this.изменитьСведенияПоПациентуToolStripMenuItem.Click += new System.EventHandler(this.изменитьСведенияПоПациентуToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(304, 6);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(307, 24);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(304, 6);
            // 
            // выбратьПациентаToolStripMenuItem
            // 
            this.выбратьПациентаToolStripMenuItem.Name = "выбратьПациентаToolStripMenuItem";
            this.выбратьПациентаToolStripMenuItem.Size = new System.Drawing.Size(307, 24);
            this.выбратьПациентаToolStripMenuItem.Text = "Выбрать пациента";
            this.выбратьПациентаToolStripMenuItem.Click += new System.EventHandler(this.выбратьПациентаToolStripMenuItem_Click);
            // 
            // g2
            // 
            this.g2.Controls.Add(this.label7);
            this.g2.Controls.Add(this.label6);
            this.g2.Controls.Add(this.label5);
            this.g2.Controls.Add(this.txtPhone);
            this.g2.Controls.Add(this.label4);
            this.g2.Controls.Add(this.txtPolice);
            this.g2.Controls.Add(this.r2);
            this.g2.Controls.Add(this.r1);
            this.g2.Controls.Add(this.dtpBirth);
            this.g2.Controls.Add(this.label3);
            this.g2.Controls.Add(this.label2);
            this.g2.Controls.Add(this.label1);
            this.g2.Controls.Add(this.txtOtc);
            this.g2.Controls.Add(this.txtNam);
            this.g2.Controls.Add(this.lblID);
            this.g2.Controls.Add(this.txtFam);
            this.g2.Enabled = false;
            this.g2.Location = new System.Drawing.Point(16, 363);
            this.g2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.g2.Name = "g2";
            this.g2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.g2.Size = new System.Drawing.Size(456, 265);
            this.g2.TabIndex = 3;
            this.g2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Пол";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Дата рожд.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Телефон";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(136, 233);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(244, 22);
            this.txtPhone.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Полис";
            // 
            // txtPolice
            // 
            this.txtPolice.Location = new System.Drawing.Point(136, 201);
            this.txtPolice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPolice.Name = "txtPolice";
            this.txtPolice.Size = new System.Drawing.Size(244, 22);
            this.txtPolice.TabIndex = 25;
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Location = new System.Drawing.Point(268, 172);
            this.r2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(84, 21);
            this.r2.TabIndex = 24;
            this.r2.Text = "женский";
            this.r2.UseVisualStyleBackColor = true;
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Checked = true;
            this.r1.Location = new System.Drawing.Point(136, 172);
            this.r1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(84, 21);
            this.r1.TabIndex = 23;
            this.r1.TabStop = true;
            this.r1.Text = "мужской";
            this.r1.UseVisualStyleBackColor = true;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(136, 122);
            this.dtpBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(125, 22);
            this.dtpBirth.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Фамилия";
            // 
            // txtOtc
            // 
            this.txtOtc.Location = new System.Drawing.Point(136, 90);
            this.txtOtc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOtc.Name = "txtOtc";
            this.txtOtc.Size = new System.Drawing.Size(244, 22);
            this.txtOtc.TabIndex = 18;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(136, 58);
            this.txtNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(244, 22);
            this.txtNam.TabIndex = 17;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblID.Location = new System.Drawing.Point(389, 30);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 19);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "ID";
            // 
            // txtFam
            // 
            this.txtFam.Location = new System.Drawing.Point(136, 26);
            this.txtFam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFam.Name = "txtFam";
            this.txtFam.Size = new System.Drawing.Size(244, 22);
            this.txtFam.TabIndex = 15;
            // 
            // g3
            // 
            this.g3.Controls.Add(this.btnFind);
            this.g3.Controls.Add(this.txtFind);
            this.g3.Controls.Add(this.dtpFind);
            this.g3.Controls.Add(this.r5);
            this.g3.Controls.Add(this.r4);
            this.g3.Controls.Add(this.r3);
            this.g3.Enabled = false;
            this.g3.Location = new System.Drawing.Point(496, 363);
            this.g3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.g3.Name = "g3";
            this.g3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.g3.Size = new System.Drawing.Size(579, 146);
            this.g3.TabIndex = 5;
            this.g3.TabStop = false;
            this.g3.Text = "Поиск пациента по критериям";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(344, 92);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(87, 28);
            this.btnFind.TabIndex = 35;
            this.btnFind.Text = "Поиск";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(53, 94);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(244, 22);
            this.txtFind.TabIndex = 34;
            // 
            // dtpFind
            // 
            this.dtpFind.Enabled = false;
            this.dtpFind.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFind.Location = new System.Drawing.Point(53, 32);
            this.dtpFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFind.Name = "dtpFind";
            this.dtpFind.Size = new System.Drawing.Size(125, 22);
            this.dtpFind.TabIndex = 31;
           // this.dtpFind.ValueChanged += new System.EventHandler(this.dtpFind_ValueChanged);
            // 
            // r5
            // 
            this.r5.AutoSize = true;
            this.r5.Location = new System.Drawing.Point(344, 64);
            this.r5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.r5.Name = "r5";
            this.r5.Size = new System.Drawing.Size(75, 21);
            this.r5.TabIndex = 33;
            this.r5.Text = "полису";
            this.r5.UseVisualStyleBackColor = true;
            this.r5.CheckedChanged += new System.EventHandler(this.r5_CheckedChanged);
            // 
            // r4
            // 
            this.r4.AutoSize = true;
            this.r4.Location = new System.Drawing.Point(185, 64);
            this.r4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(129, 21);
            this.r4.TabIndex = 32;
            this.r4.Text = "дате рождения";
            this.r4.UseVisualStyleBackColor = true;
            this.r4.CheckedChanged += new System.EventHandler(this.r4_CheckedChanged);
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.Checked = true;
            this.r3.Location = new System.Drawing.Point(53, 64);
            this.r3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(89, 21);
            this.r3.TabIndex = 31;
            this.r3.TabStop = true;
            this.r3.Text = "фамилии";
            this.r3.UseVisualStyleBackColor = true;
            this.r3.CheckedChanged += new System.EventHandler(this.r3_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(935, 592);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 28);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Выход";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(715, 592);
            this.btnDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(212, 28);
            this.btnDo.TabIndex = 7;
            this.btnDo.Text = "Сохранить изменение";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 638);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.g3);
            this.Controls.Add(this.g2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пациенты поликлиники";
            this.Load += new System.EventHandler(this.frmPatient_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.g2.ResumeLayout(false);
            this.g2.PerformLayout();
            this.g3.ResumeLayout(false);
            this.g3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox g2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPolice;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOtc;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtFam;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новыйПациентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьСведенияПоПациентуToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.GroupBox g3;
        private System.Windows.Forms.RadioButton r4;
        private System.Windows.Forms.RadioButton r3;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.DateTimePicker dtpFind;
        private System.Windows.Forms.RadioButton r5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem выбратьПациентаToolStripMenuItem;
    }
}