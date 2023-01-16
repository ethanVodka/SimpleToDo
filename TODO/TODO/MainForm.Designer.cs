namespace TODO
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tODOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControlWeeks = new System.Windows.Forms.TabControl();
            this.pageMon = new System.Windows.Forms.TabPage();
            this.dataGridViewMon = new System.Windows.Forms.DataGridView();
            this.TODO_Mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageTue = new System.Windows.Forms.TabPage();
            this.dataGridViewTue = new System.Windows.Forms.DataGridView();
            this.TODO_Tue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageWed = new System.Windows.Forms.TabPage();
            this.dataGridViewWed = new System.Windows.Forms.DataGridView();
            this.TODO_Wed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageThu = new System.Windows.Forms.TabPage();
            this.dataGridViewThu = new System.Windows.Forms.DataGridView();
            this.TODO_Thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageFri = new System.Windows.Forms.TabPage();
            this.dataGridViewFri = new System.Windows.Forms.DataGridView();
            this.TODO_Fri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageSat = new System.Windows.Forms.TabPage();
            this.dataGridViewSat = new System.Windows.Forms.DataGridView();
            this.TODO_Sat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageSun = new System.Windows.Forms.TabPage();
            this.dataGridViewSun = new System.Windows.Forms.DataGridView();
            this.TODO_Sun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_content = new System.Windows.Forms.RichTextBox();
            this.comboBox_week = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.refleshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlWeeks.SuspendLayout();
            this.pageMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMon)).BeginInit();
            this.pageTue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTue)).BeginInit();
            this.pageWed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWed)).BeginInit();
            this.pageThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThu)).BeginInit();
            this.pageFri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFri)).BeginInit();
            this.pageSat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSat)).BeginInit();
            this.pageSun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSun)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tODOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(342, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tODOToolStripMenuItem
            // 
            this.tODOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.refleshToolStripMenuItem});
            this.tODOToolStripMenuItem.Name = "tODOToolStripMenuItem";
            this.tODOToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.tODOToolStripMenuItem.Text = "TODO";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControlWeeks);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DeleteButton);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox_content);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox_week);
            this.splitContainer1.Panel2.Controls.Add(this.AddButton);
            this.splitContainer1.Size = new System.Drawing.Size(342, 504);
            this.splitContainer1.SplitterDistance = 384;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControlWeeks
            // 
            this.tabControlWeeks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlWeeks.Controls.Add(this.pageMon);
            this.tabControlWeeks.Controls.Add(this.pageTue);
            this.tabControlWeeks.Controls.Add(this.pageWed);
            this.tabControlWeeks.Controls.Add(this.pageThu);
            this.tabControlWeeks.Controls.Add(this.pageFri);
            this.tabControlWeeks.Controls.Add(this.pageSat);
            this.tabControlWeeks.Controls.Add(this.pageSun);
            this.tabControlWeeks.Location = new System.Drawing.Point(0, 0);
            this.tabControlWeeks.Name = "tabControlWeeks";
            this.tabControlWeeks.SelectedIndex = 0;
            this.tabControlWeeks.Size = new System.Drawing.Size(339, 390);
            this.tabControlWeeks.TabIndex = 0;
            // 
            // pageMon
            // 
            this.pageMon.Controls.Add(this.dataGridViewMon);
            this.pageMon.Location = new System.Drawing.Point(4, 24);
            this.pageMon.Name = "pageMon";
            this.pageMon.Padding = new System.Windows.Forms.Padding(3);
            this.pageMon.Size = new System.Drawing.Size(331, 362);
            this.pageMon.TabIndex = 0;
            this.pageMon.Text = "Mon.";
            this.pageMon.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMon
            // 
            this.dataGridViewMon.AllowUserToAddRows = false;
            this.dataGridViewMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TODO_Mon});
            this.dataGridViewMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMon.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMon.Name = "dataGridViewMon";
            this.dataGridViewMon.RowHeadersVisible = false;
            this.dataGridViewMon.RowHeadersWidth = 356;
            this.dataGridViewMon.RowTemplate.Height = 25;
            this.dataGridViewMon.Size = new System.Drawing.Size(325, 356);
            this.dataGridViewMon.TabIndex = 0;
            // 
            // TODO_Mon
            // 
            this.TODO_Mon.HeaderText = "TODO";
            this.TODO_Mon.Name = "TODO_Mon";
            // 
            // pageTue
            // 
            this.pageTue.Controls.Add(this.dataGridViewTue);
            this.pageTue.Location = new System.Drawing.Point(4, 24);
            this.pageTue.Name = "pageTue";
            this.pageTue.Padding = new System.Windows.Forms.Padding(3);
            this.pageTue.Size = new System.Drawing.Size(331, 362);
            this.pageTue.TabIndex = 1;
            this.pageTue.Text = "Tue.";
            this.pageTue.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTue
            // 
            this.dataGridViewTue.AllowUserToAddRows = false;
            this.dataGridViewTue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TODO_Tue});
            this.dataGridViewTue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTue.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTue.Name = "dataGridViewTue";
            this.dataGridViewTue.RowHeadersVisible = false;
            this.dataGridViewTue.RowHeadersWidth = 356;
            this.dataGridViewTue.RowTemplate.Height = 25;
            this.dataGridViewTue.Size = new System.Drawing.Size(325, 356);
            this.dataGridViewTue.TabIndex = 1;
            // 
            // TODO_Tue
            // 
            this.TODO_Tue.HeaderText = "TODO";
            this.TODO_Tue.Name = "TODO_Tue";
            // 
            // pageWed
            // 
            this.pageWed.Controls.Add(this.dataGridViewWed);
            this.pageWed.Location = new System.Drawing.Point(4, 24);
            this.pageWed.Name = "pageWed";
            this.pageWed.Padding = new System.Windows.Forms.Padding(3);
            this.pageWed.Size = new System.Drawing.Size(331, 362);
            this.pageWed.TabIndex = 2;
            this.pageWed.Text = "Wed.";
            this.pageWed.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWed
            // 
            this.dataGridViewWed.AllowUserToAddRows = false;
            this.dataGridViewWed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TODO_Wed});
            this.dataGridViewWed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWed.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewWed.Name = "dataGridViewWed";
            this.dataGridViewWed.RowHeadersVisible = false;
            this.dataGridViewWed.RowHeadersWidth = 356;
            this.dataGridViewWed.RowTemplate.Height = 25;
            this.dataGridViewWed.Size = new System.Drawing.Size(325, 356);
            this.dataGridViewWed.TabIndex = 1;
            // 
            // TODO_Wed
            // 
            this.TODO_Wed.HeaderText = "TODO";
            this.TODO_Wed.Name = "TODO_Wed";
            // 
            // pageThu
            // 
            this.pageThu.Controls.Add(this.dataGridViewThu);
            this.pageThu.Location = new System.Drawing.Point(4, 24);
            this.pageThu.Name = "pageThu";
            this.pageThu.Padding = new System.Windows.Forms.Padding(3);
            this.pageThu.Size = new System.Drawing.Size(331, 362);
            this.pageThu.TabIndex = 3;
            this.pageThu.Text = "Thu";
            this.pageThu.UseVisualStyleBackColor = true;
            // 
            // dataGridViewThu
            // 
            this.dataGridViewThu.AllowUserToAddRows = false;
            this.dataGridViewThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TODO_Thu});
            this.dataGridViewThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewThu.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewThu.Name = "dataGridViewThu";
            this.dataGridViewThu.RowHeadersVisible = false;
            this.dataGridViewThu.RowHeadersWidth = 356;
            this.dataGridViewThu.RowTemplate.Height = 25;
            this.dataGridViewThu.Size = new System.Drawing.Size(325, 356);
            this.dataGridViewThu.TabIndex = 1;
            // 
            // TODO_Thu
            // 
            this.TODO_Thu.HeaderText = "TODO";
            this.TODO_Thu.Name = "TODO_Thu";
            // 
            // pageFri
            // 
            this.pageFri.Controls.Add(this.dataGridViewFri);
            this.pageFri.Location = new System.Drawing.Point(4, 24);
            this.pageFri.Name = "pageFri";
            this.pageFri.Padding = new System.Windows.Forms.Padding(3);
            this.pageFri.Size = new System.Drawing.Size(331, 362);
            this.pageFri.TabIndex = 4;
            this.pageFri.Text = "Fri.";
            this.pageFri.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFri
            // 
            this.dataGridViewFri.AllowUserToAddRows = false;
            this.dataGridViewFri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TODO_Fri});
            this.dataGridViewFri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFri.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewFri.Name = "dataGridViewFri";
            this.dataGridViewFri.RowHeadersVisible = false;
            this.dataGridViewFri.RowHeadersWidth = 356;
            this.dataGridViewFri.RowTemplate.Height = 25;
            this.dataGridViewFri.Size = new System.Drawing.Size(325, 356);
            this.dataGridViewFri.TabIndex = 1;
            // 
            // TODO_Fri
            // 
            this.TODO_Fri.HeaderText = "TODO";
            this.TODO_Fri.Name = "TODO_Fri";
            // 
            // pageSat
            // 
            this.pageSat.Controls.Add(this.dataGridViewSat);
            this.pageSat.Location = new System.Drawing.Point(4, 24);
            this.pageSat.Name = "pageSat";
            this.pageSat.Padding = new System.Windows.Forms.Padding(3);
            this.pageSat.Size = new System.Drawing.Size(331, 362);
            this.pageSat.TabIndex = 5;
            this.pageSat.Text = "Sat.";
            this.pageSat.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSat
            // 
            this.dataGridViewSat.AllowUserToAddRows = false;
            this.dataGridViewSat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TODO_Sat});
            this.dataGridViewSat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSat.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSat.Name = "dataGridViewSat";
            this.dataGridViewSat.RowHeadersVisible = false;
            this.dataGridViewSat.RowHeadersWidth = 356;
            this.dataGridViewSat.RowTemplate.Height = 25;
            this.dataGridViewSat.Size = new System.Drawing.Size(325, 356);
            this.dataGridViewSat.TabIndex = 1;
            // 
            // TODO_Sat
            // 
            this.TODO_Sat.HeaderText = "TODO";
            this.TODO_Sat.Name = "TODO_Sat";
            // 
            // pageSun
            // 
            this.pageSun.Controls.Add(this.dataGridViewSun);
            this.pageSun.Location = new System.Drawing.Point(4, 24);
            this.pageSun.Name = "pageSun";
            this.pageSun.Padding = new System.Windows.Forms.Padding(3);
            this.pageSun.Size = new System.Drawing.Size(331, 362);
            this.pageSun.TabIndex = 6;
            this.pageSun.Text = "Sun.";
            this.pageSun.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSun
            // 
            this.dataGridViewSun.AllowUserToAddRows = false;
            this.dataGridViewSun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TODO_Sun});
            this.dataGridViewSun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSun.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSun.Name = "dataGridViewSun";
            this.dataGridViewSun.RowHeadersVisible = false;
            this.dataGridViewSun.RowHeadersWidth = 356;
            this.dataGridViewSun.RowTemplate.Height = 25;
            this.dataGridViewSun.Size = new System.Drawing.Size(325, 356);
            this.dataGridViewSun.TabIndex = 1;
            // 
            // TODO_Sun
            // 
            this.TODO_Sun.HeaderText = "TODO";
            this.TODO_Sun.Name = "TODO_Sun";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(281, 11);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(58, 23);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "削除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 94);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(342, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel2.Text = "SimpleToDo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "内容";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "曜日";
            // 
            // richTextBox_content
            // 
            this.richTextBox_content.Location = new System.Drawing.Point(58, 37);
            this.richTextBox_content.Name = "richTextBox_content";
            this.richTextBox_content.Size = new System.Drawing.Size(217, 54);
            this.richTextBox_content.TabIndex = 2;
            this.richTextBox_content.Text = "";
            // 
            // comboBox_week
            // 
            this.comboBox_week.FormattingEnabled = true;
            this.comboBox_week.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBox_week.Location = new System.Drawing.Point(58, 8);
            this.comboBox_week.Name = "comboBox_week";
            this.comboBox_week.Size = new System.Drawing.Size(96, 23);
            this.comboBox_week.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(281, 68);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(58, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "追加";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // refleshToolStripMenuItem
            // 
            this.refleshToolStripMenuItem.Name = "refleshToolStripMenuItem";
            this.refleshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refleshToolStripMenuItem.Text = "Reflesh";
            this.refleshToolStripMenuItem.Click += new System.EventHandler(this.RefleshToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 528);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(358, 567);
            this.MinimumSize = new System.Drawing.Size(358, 567);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControlWeeks.ResumeLayout(false);
            this.pageMon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMon)).EndInit();
            this.pageTue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTue)).EndInit();
            this.pageWed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWed)).EndInit();
            this.pageThu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThu)).EndInit();
            this.pageFri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFri)).EndInit();
            this.pageSat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSat)).EndInit();
            this.pageSun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSun)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tODOToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private SplitContainer splitContainer1;
        private TabControl tabControlWeeks;
        private TabPage pageMon;
        private TabPage pageTue;
        private TabPage pageWed;
        private TabPage pageThu;
        private TabPage pageFri;
        private ToolTip toolTip1;
        private TabPage pageSat;
        private TabPage pageSun;
        private DataGridView dataGridViewMon;
        private ComboBox comboBox_week;
        private Button AddButton;
        private Label label2;
        private Label label1;
        private RichTextBox richTextBox_content;
        private DataGridView dataGridViewTue;
        private DataGridView dataGridViewWed;
        private DataGridView dataGridViewThu;
        private DataGridView dataGridViewFri;
        private DataGridView dataGridViewSat;
        private DataGridView dataGridViewSun;
        private DataGridViewTextBoxColumn TODO_Mon;
        private DataGridViewTextBoxColumn TODO_Tue;
        private DataGridViewTextBoxColumn TODO_Wed;
        private DataGridViewTextBoxColumn TODO_Thu;
        private DataGridViewTextBoxColumn TODO_Fri;
        private DataGridViewTextBoxColumn TODO_Sat;
        private DataGridViewTextBoxColumn TODO_Sun;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Button DeleteButton;
        private ToolStripMenuItem refleshToolStripMenuItem;
    }
}