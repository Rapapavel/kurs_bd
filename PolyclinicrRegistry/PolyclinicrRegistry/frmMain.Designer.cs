namespace PolyclinicrRegistry
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.специальностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пациентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.офисыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.штатноеРасписаниеСоставToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеСпециалистовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приемСпециалистаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.работаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1232, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.специальностиToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.пациентыToolStripMenuItem,
            this.офисыToolStripMenuItem,
            this.toolStripMenuItem1,
            this.штатноеРасписаниеСоставToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.справочникиToolStripMenuItem.Text = "Справочники";
           // this.справочникиToolStripMenuItem.Click += new System.EventHandler(this.справочникиToolStripMenuItem_Click);
            // 
            // специальностиToolStripMenuItem
            // 
            this.специальностиToolStripMenuItem.Name = "специальностиToolStripMenuItem";
            this.специальностиToolStripMenuItem.Size = new System.Drawing.Size(388, 26);
            this.специальностиToolStripMenuItem.Text = "Специальности";
            this.специальностиToolStripMenuItem.Click += new System.EventHandler(this.специальностиToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(388, 26);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // пациентыToolStripMenuItem
            // 
            this.пациентыToolStripMenuItem.Name = "пациентыToolStripMenuItem";
            this.пациентыToolStripMenuItem.Size = new System.Drawing.Size(388, 26);
            this.пациентыToolStripMenuItem.Text = "Пациенты";
            this.пациентыToolStripMenuItem.Click += new System.EventHandler(this.пациентыToolStripMenuItem_Click);
            // 
            // офисыToolStripMenuItem
            // 
            this.офисыToolStripMenuItem.Name = "офисыToolStripMenuItem";
            this.офисыToolStripMenuItem.Size = new System.Drawing.Size(388, 26);
            this.офисыToolStripMenuItem.Text = "Кабинеты";
            this.офисыToolStripMenuItem.Click += new System.EventHandler(this.офисыToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(385, 6);
            // 
            // штатноеРасписаниеСоставToolStripMenuItem
            // 
            this.штатноеРасписаниеСоставToolStripMenuItem.Name = "штатноеРасписаниеСоставToolStripMenuItem";
            this.штатноеРасписаниеСоставToolStripMenuItem.Size = new System.Drawing.Size(388, 26);
            this.штатноеРасписаниеСоставToolStripMenuItem.Text = "Расписание работы специалистов. Режим.";
            this.штатноеРасписаниеСоставToolStripMenuItem.Click += new System.EventHandler(this.штатноеРасписаниеСоставToolStripMenuItem_Click);
            // 
            // работаToolStripMenuItem
            // 
            this.работаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расписаниеСпециалистовToolStripMenuItem,
            this.приемСпециалистаToolStripMenuItem});
            this.работаToolStripMenuItem.Name = "работаToolStripMenuItem";
            this.работаToolStripMenuItem.Size = new System.Drawing.Size(71, 26);
            this.работаToolStripMenuItem.Text = "Работа";
            // 
            // расписаниеСпециалистовToolStripMenuItem
            // 
            this.расписаниеСпециалистовToolStripMenuItem.Name = "расписаниеСпециалистовToolStripMenuItem";
            this.расписаниеСпециалистовToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.расписаниеСпециалистовToolStripMenuItem.Text = "Прием специалиста";
            this.расписаниеСпециалистовToolStripMenuItem.Click += new System.EventHandler(this.расписаниеСпециалистовToolStripMenuItem_Click);
            // 
            // приемСпециалистаToolStripMenuItem
            // 
            this.приемСпециалистаToolStripMenuItem.Name = "приемСпециалистаToolStripMenuItem";
            this.приемСпециалистаToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.приемСпециалистаToolStripMenuItem.Text = "Выдача талонов";
            this.приемСпециалистаToolStripMenuItem.Click += new System.EventHandler(this.приемСпециалистаToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1232, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(18, 20);
            this.toolStripStatusLabel1.Text = "...";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 514);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Основная форма расписания поликлиники";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem специальностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пациентыToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem работаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеСпециалистовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приемСпециалистаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem офисыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem штатноеРасписаниеСоставToolStripMenuItem;
    }
}