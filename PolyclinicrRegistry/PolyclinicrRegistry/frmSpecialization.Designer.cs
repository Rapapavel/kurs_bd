namespace PolyclinicrRegistry
{
    partial class frmSpecialization
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
            this.создатьНовуюСпециальностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьСпециальностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСпециальностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView.Location = new System.Drawing.Point(17, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(424, 225);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовуюСпециальностьToolStripMenuItem,
            this.изменитьСпециальностьToolStripMenuItem,
            this.удалитьСпециальностьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(265, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // создатьНовуюСпециальностьToolStripMenuItem
            // 
            this.создатьНовуюСпециальностьToolStripMenuItem.Name = "создатьНовуюСпециальностьToolStripMenuItem";
            this.создатьНовуюСпециальностьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.создатьНовуюСпециальностьToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.создатьНовуюСпециальностьToolStripMenuItem.Text = "Создать новую специальность";
            this.создатьНовуюСпециальностьToolStripMenuItem.Click += new System.EventHandler(this.создатьНовуюСпециальностьToolStripMenuItem_Click);
            // 
            // изменитьСпециальностьToolStripMenuItem
            // 
            this.изменитьСпециальностьToolStripMenuItem.Name = "изменитьСпециальностьToolStripMenuItem";
            this.изменитьСпециальностьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.изменитьСпециальностьToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.изменитьСпециальностьToolStripMenuItem.Text = "Изменить специальность";
            this.изменитьСпециальностьToolStripMenuItem.Click += new System.EventHandler(this.изменитьСпециальностьToolStripMenuItem_Click);
            // 
            // удалитьСпециальностьToolStripMenuItem
            // 
            this.удалитьСпециальностьToolStripMenuItem.Name = "удалитьСпециальностьToolStripMenuItem";
            this.удалитьСпециальностьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.удалитьСпециальностьToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.удалитьСпециальностьToolStripMenuItem.Text = "Удалить специальность";
            this.удалитьСпециальностьToolStripMenuItem.Click += new System.EventHandler(this.удалитьСпециальностьToolStripMenuItem_Click);
            // 
            // btnDo
            // 
            this.btnDo.Enabled = false;
            this.btnDo.Location = new System.Drawing.Point(240, 293);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(147, 23);
            this.btnDo.TabIndex = 1;
            this.btnDo.Text = "Сохранить изменение";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(393, 293);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Выход";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(50, 295);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(26, 298);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID";
            // 
            // frmSpecialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 337);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSpecialization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Специализации ";
            this.Load += new System.EventHandler(this.frmSpecialization_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьНовуюСпециальностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьСпециальностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСпециальностьToolStripMenuItem;
    }
}