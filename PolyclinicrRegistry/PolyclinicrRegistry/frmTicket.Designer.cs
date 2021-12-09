namespace PolyclinicrRegistry
{
    partial class frmTicket
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl = new System.Windows.Forms.Label();
            this.rt = new System.Windows.Forms.RichTextBox();
            this.cmbResult = new System.Windows.Forms.ComboBox();
            this.chkClosed = new System.Windows.Forms.CheckBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblEven = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.lblFio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cmbStuff = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSpec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.rt);
            this.groupBox1.Controls.Add(this.cmbResult);
            this.groupBox1.Controls.Add(this.chkClosed);
            this.groupBox1.Controls.Add(this.lblStaff);
            this.groupBox1.Controls.Add(this.lblEven);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btn);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnPatient);
            this.groupBox1.Controls.Add(this.lblFio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtp);
            this.groupBox1.Controls.Add(this.cmbStuff);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbSpec);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(763, 463);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(20, 315);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(191, 17);
            this.lbl.TabIndex = 21;
            this.lbl.Text = "Комментарий специалиста:";
            // 
            // rt
            // 
            this.rt.Location = new System.Drawing.Point(23, 335);
            this.rt.Name = "rt";
            this.rt.Size = new System.Drawing.Size(657, 83);
            this.rt.TabIndex = 20;
            this.rt.Text = "";
            // 
            // cmbResult
            // 
            this.cmbResult.FormattingEnabled = true;
            this.cmbResult.Location = new System.Drawing.Point(23, 284);
            this.cmbResult.Margin = new System.Windows.Forms.Padding(4);
            this.cmbResult.Name = "cmbResult";
            this.cmbResult.Size = new System.Drawing.Size(657, 24);
            this.cmbResult.TabIndex = 19;
            // 
            // chkClosed
            // 
            this.chkClosed.AutoSize = true;
            this.chkClosed.Location = new System.Drawing.Point(23, 256);
            this.chkClosed.Margin = new System.Windows.Forms.Padding(4);
            this.chkClosed.Name = "chkClosed";
            this.chkClosed.Size = new System.Drawing.Size(142, 21);
            this.chkClosed.TabIndex = 18;
            this.chkClosed.Text = "Прием завершен";
            this.chkClosed.UseVisualStyleBackColor = true;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(689, 135);
            this.lblStaff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(20, 17);
            this.lblStaff.TabIndex = 17;
            this.lblStaff.Text = "...";
            // 
            // lblEven
            // 
            this.lblEven.AutoSize = true;
            this.lblEven.Location = new System.Drawing.Point(447, 186);
            this.lblEven.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEven.Name = "lblEven";
            this.lblEven.Size = new System.Drawing.Size(20, 17);
            this.lblEven.TabIndex = 15;
            this.lblEven.Text = "...";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(562, 425);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(119, 30);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Печать талона";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(442, 425);
            this.btn.Margin = new System.Windows.Forms.Padding(4);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(112, 30);
            this.btn.TabIndex = 13;
            this.btn.Text = "Выход";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(306, 425);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 30);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.Location = new System.Drawing.Point(261, 44);
            this.btnPatient.Margin = new System.Windows.Forms.Padding(4);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(37, 30);
            this.btnPatient.TabIndex = 10;
            this.btnPatient.Text = "...";
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // lblFio
            // 
            this.lblFio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFio.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblFio.Location = new System.Drawing.Point(307, 43);
            this.lblFio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFio.Name = "lblFio";
            this.lblFio.Size = new System.Drawing.Size(374, 35);
            this.lblFio.TabIndex = 9;
            this.lblFio.Text = "...";
            this.lblFio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Пациент:";
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(307, 224);
            this.cmbTime.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(95, 24);
            this.cmbTime.TabIndex = 7;
            this.cmbTime.SelectedIndexChanged += new System.EventHandler(this.cmbTime_SelectedIndexChanged);
            this.cmbTime.Leave += new System.EventHandler(this.cmbTime_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Время приема:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата приема:";
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(307, 181);
            this.dtp.Margin = new System.Windows.Forms.Padding(4);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(95, 22);
            this.dtp.TabIndex = 4;
            this.dtp.Value = new System.DateTime(2021, 11, 22, 0, 0, 0, 0);
            this.dtp.Leave += new System.EventHandler(this.dtp_Leave);
            // 
            // cmbStuff
            // 
            this.cmbStuff.FormattingEnabled = true;
            this.cmbStuff.Location = new System.Drawing.Point(307, 132);
            this.cmbStuff.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStuff.Name = "cmbStuff";
            this.cmbStuff.Size = new System.Drawing.Size(373, 24);
            this.cmbStuff.TabIndex = 3;
            this.cmbStuff.SelectedIndexChanged += new System.EventHandler(this.cmbStuff_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Специалист (врач):";
            // 
            // cmbSpec
            // 
            this.cmbSpec.FormattingEnabled = true;
            this.cmbSpec.Location = new System.Drawing.Point(307, 89);
            this.cmbSpec.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSpec.Name = "cmbSpec";
            this.cmbSpec.Size = new System.Drawing.Size(373, 24);
            this.cmbSpec.TabIndex = 1;
            this.cmbSpec.SelectedIndexChanged += new System.EventHandler(this.cmbSpec_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Специализация / направление лечения:";
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 491);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Оформление талона на прием к врачу";
            this.Load += new System.EventHandler(this.frmTicket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEven;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Label lblFio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ComboBox cmbStuff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSpec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.CheckBox chkClosed;
        private System.Windows.Forms.ComboBox cmbResult;
        private System.Windows.Forms.RichTextBox rt;
        private System.Windows.Forms.Label lbl;
    }
}