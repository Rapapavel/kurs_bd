namespace PolyclinicrRegistry
{
    partial class frmStaff
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
            this.создатьЗаписьОСотрудникеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЗаписьОСотрудникеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаписьОСотрудникеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.сменитьПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblID = new System.Windows.Forms.Label();
            this.txtFam = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtOtc = new System.Windows.Forms.TextBox();
            this.cmbSpec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblID2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPsw = new System.Windows.Forms.Button();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 369);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView.Location = new System.Drawing.Point(8, 23);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(1019, 335);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick_1);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьЗаписьОСотрудникеToolStripMenuItem,
            this.изменитьЗаписьОСотрудникеToolStripMenuItem,
            this.удалитьЗаписьОСотрудникеToolStripMenuItem,
            this.toolStripMenuItem1,
            this.сменитьПарольToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(320, 134);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // создатьЗаписьОСотрудникеToolStripMenuItem
            // 
            this.создатьЗаписьОСотрудникеToolStripMenuItem.Name = "создатьЗаписьОСотрудникеToolStripMenuItem";
            this.создатьЗаписьОСотрудникеToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.создатьЗаписьОСотрудникеToolStripMenuItem.Size = new System.Drawing.Size(319, 24);
            this.создатьЗаписьОСотрудникеToolStripMenuItem.Text = "Создать запись о сотруднике";
            this.создатьЗаписьОСотрудникеToolStripMenuItem.Click += new System.EventHandler(this.создатьЗаписьОСотрудникеToolStripMenuItem_Click);
            // 
            // изменитьЗаписьОСотрудникеToolStripMenuItem
            // 
            this.изменитьЗаписьОСотрудникеToolStripMenuItem.Name = "изменитьЗаписьОСотрудникеToolStripMenuItem";
            this.изменитьЗаписьОСотрудникеToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.изменитьЗаписьОСотрудникеToolStripMenuItem.Size = new System.Drawing.Size(319, 24);
            this.изменитьЗаписьОСотрудникеToolStripMenuItem.Text = "Изменить запись о сотруднике";
            this.изменитьЗаписьОСотрудникеToolStripMenuItem.Click += new System.EventHandler(this.изменитьЗаписьОСотрудникеToolStripMenuItem_Click);
            // 
            // удалитьЗаписьОСотрудникеToolStripMenuItem
            // 
            this.удалитьЗаписьОСотрудникеToolStripMenuItem.Name = "удалитьЗаписьОСотрудникеToolStripMenuItem";
            this.удалитьЗаписьОСотрудникеToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.удалитьЗаписьОСотрудникеToolStripMenuItem.Size = new System.Drawing.Size(319, 24);
            this.удалитьЗаписьОСотрудникеToolStripMenuItem.Text = "Удалить запись о сотруднике";
            this.удалитьЗаписьОСотрудникеToolStripMenuItem.Click += new System.EventHandler(this.удалитьЗаписьОСотрудникеToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(316, 6);
            // 
            // сменитьПарольToolStripMenuItem
            // 
            this.сменитьПарольToolStripMenuItem.Name = "сменитьПарольToolStripMenuItem";
            this.сменитьПарольToolStripMenuItem.Size = new System.Drawing.Size(319, 24);
            this.сменитьПарольToolStripMenuItem.Text = "Сменить пароль";
            this.сменитьПарольToolStripMenuItem.Click += new System.EventHandler(this.сменитьПарольToolStripMenuItem_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblID.Location = new System.Drawing.Point(416, 398);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 19);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID";
            // 
            // txtFam
            // 
            this.txtFam.Enabled = false;
            this.txtFam.Location = new System.Drawing.Point(163, 394);
            this.txtFam.Margin = new System.Windows.Forms.Padding(4);
            this.txtFam.Name = "txtFam";
            this.txtFam.Size = new System.Drawing.Size(244, 22);
            this.txtFam.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(803, 526);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Выход";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(583, 526);
            this.btnDo.Margin = new System.Windows.Forms.Padding(4);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(212, 28);
            this.btnDo.TabIndex = 5;
            this.btnDo.Text = "Сохранить изменение";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // txtNam
            // 
            this.txtNam.Enabled = false;
            this.txtNam.Location = new System.Drawing.Point(163, 426);
            this.txtNam.Margin = new System.Windows.Forms.Padding(4);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(244, 22);
            this.txtNam.TabIndex = 9;
            // 
            // txtOtc
            // 
            this.txtOtc.Enabled = false;
            this.txtOtc.Location = new System.Drawing.Point(163, 458);
            this.txtOtc.Margin = new System.Windows.Forms.Padding(4);
            this.txtOtc.Name = "txtOtc";
            this.txtOtc.Size = new System.Drawing.Size(244, 22);
            this.txtOtc.TabIndex = 10;
            // 
            // cmbSpec
            // 
            this.cmbSpec.Enabled = false;
            this.cmbSpec.FormattingEnabled = true;
            this.cmbSpec.Location = new System.Drawing.Point(583, 394);
            this.cmbSpec.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSpec.Name = "cmbSpec";
            this.cmbSpec.Size = new System.Drawing.Size(351, 24);
            this.cmbSpec.TabIndex = 11;
            this.cmbSpec.SelectedIndexChanged += new System.EventHandler(this.cmbSpec_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 398);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 432);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 462);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 398);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Спец.";
            // 
            // lblID2
            // 
            this.lblID2.AutoSize = true;
            this.lblID2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblID2.Location = new System.Drawing.Point(943, 398);
            this.lblID2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID2.Name = "lblID2";
            this.lblID2.Size = new System.Drawing.Size(23, 19);
            this.lblID2.TabIndex = 16;
            this.lblID2.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 430);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "LOGIN";
            // 
            // txtLogin
            // 
            this.txtLogin.Enabled = false;
            this.txtLogin.Location = new System.Drawing.Point(583, 427);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(351, 22);
            this.txtLogin.TabIndex = 17;
            this.txtLogin.GotFocus += new System.EventHandler(this.txtLogin_GotFocus);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Пароль";
            // 
            // txtPsw
            // 
            this.txtPsw.Enabled = false;
            this.txtPsw.Location = new System.Drawing.Point(69, 25);
            this.txtPsw.Margin = new System.Windows.Forms.Padding(4);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.PasswordChar = '*';
            this.txtPsw.Size = new System.Drawing.Size(136, 22);
            this.txtPsw.TabIndex = 19;
            this.txtPsw.UseSystemPasswordChar = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPsw);
            this.groupBox2.Controls.Add(this.txtPsw);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(583, 457);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(357, 62);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // btnPsw
            // 
            this.btnPsw.Location = new System.Drawing.Point(220, 23);
            this.btnPsw.Margin = new System.Windows.Forms.Padding(4);
            this.btnPsw.Name = "btnPsw";
            this.btnPsw.Size = new System.Drawing.Size(132, 28);
            this.btnPsw.TabIndex = 21;
            this.btnPsw.Text = "Сменить пароль";
            this.btnPsw.UseVisualStyleBackColor = true;
            // 
            // cmbRole
            // 
            this.cmbRole.AutoCompleteCustomSource.AddRange(new string[] {
            "Специалист",
            "Регистратура",
            "Администратор"});
            this.cmbRole.Enabled = false;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Специалист",
            "Регистратура",
            "Администратор"});
            this.cmbRole.Location = new System.Drawing.Point(163, 524);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(244, 24);
            this.cmbRole.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 528);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Роль";
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 565);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblID2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSpec);
            this.Controls.Add(this.txtOtc);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtFam);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Специалисты поликлиники";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtFam;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtOtc;
        private System.Windows.Forms.ComboBox cmbSpec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьЗаписьОСотрудникеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЗаписьОСотрудникеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписьОСотрудникеToolStripMenuItem;
        private System.Windows.Forms.Label lblID2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPsw;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сменитьПарольToolStripMenuItem;
    }
}