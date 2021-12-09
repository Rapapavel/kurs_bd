namespace PolyclinicrRegistry
{
    partial class frmSheduleRecept
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
            this.новыйТалонНаПриемКВрачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.печатьТалонаНаПриемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDo = new System.Windows.Forms.Button();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(16, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1187, 364);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView.Location = new System.Drawing.Point(8, 11);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(1171, 346);
            this.dataGridView.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйТалонНаПриемКВрачуToolStripMenuItem,
            this.toolStripMenuItem1,
            this.печатьТалонаНаПриемToolStripMenuItem,
            this.toolStripMenuItem2,
            this.редактированиеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(297, 88);
           // this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // новыйТалонНаПриемКВрачуToolStripMenuItem
            // 
            this.новыйТалонНаПриемКВрачуToolStripMenuItem.Name = "новыйТалонНаПриемКВрачуToolStripMenuItem";
            this.новыйТалонНаПриемКВрачуToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.новыйТалонНаПриемКВрачуToolStripMenuItem.Text = "Новый талон на прием к врачу";
            this.новыйТалонНаПриемКВрачуToolStripMenuItem.Click += new System.EventHandler(this.новыйТалонНаПриемКВрачуToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(293, 6);
            // 
            // печатьТалонаНаПриемToolStripMenuItem
            // 
            this.печатьТалонаНаПриемToolStripMenuItem.Name = "печатьТалонаНаПриемToolStripMenuItem";
            this.печатьТалонаНаПриемToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.печатьТалонаНаПриемToolStripMenuItem.Text = "Печать талона на прием";
            this.печатьТалонаНаПриемToolStripMenuItem.Click += new System.EventHandler(this.печатьТалонаНаПриемToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(293, 6);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.редактированиеToolStripMenuItem.Text = "Редактирование талона";
            this.редактированиеToolStripMenuItem.Click += new System.EventHandler(this.редактированиеToolStripMenuItem_Click);
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(917, 415);
            this.btnDo.Margin = new System.Windows.Forms.Padding(4);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(277, 28);
            this.btnDo.TabIndex = 5;
            this.btnDo.Text = "Принять пациента";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(31, 422);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(138, 21);
            this.rb1.TabIndex = 6;
            this.rb1.TabStop = true;
            this.rb1.Text = "Незавершенные";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(187, 422);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(122, 21);
            this.rb2.TabIndex = 7;
            this.rb2.Text = "Завершенные";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(324, 422);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(358, 21);
            this.rb3.TabIndex = 8;
            this.rb3.Text = "Полный список (завершенные и незавершенные)";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
            // 
            // frmSheduleRecept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 474);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSheduleRecept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "м";
            this.Load += new System.EventHandler(this.frmSheduleRecept_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новыйТалонНаПриемКВрачуToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem печатьТалонаНаПриемToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
    }
}