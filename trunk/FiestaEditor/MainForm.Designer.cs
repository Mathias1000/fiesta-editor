namespace FiestaEditor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.spltContainer = new System.Windows.Forms.SplitContainer();
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbEncoding = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRowIndex = new System.Windows.Forms.Label();
            this.lblColumnType = new System.Windows.Forms.Label();
            this.lblColumnSize = new System.Windows.Forms.Label();
            this.lblColumnName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAutoFilter = new System.Windows.Forms.CheckBox();
            this.lblFilterHelp = new System.Windows.Forms.LinkLabel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.BottomStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.spltContainer)).BeginInit();
            this.spltContainer.Panel1.SuspendLayout();
            this.spltContainer.Panel2.SuspendLayout();
            this.spltContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.BottomStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spltContainer
            // 
            this.spltContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spltContainer.Location = new System.Drawing.Point(0, 24);
            this.spltContainer.Name = "spltContainer";
            // 
            // spltContainer.Panel1
            // 
            this.spltContainer.Panel1.Controls.Add(this.tabContainer);
            // 
            // spltContainer.Panel2
            // 
            this.spltContainer.Panel2.Controls.Add(this.lblCopyRight);
            this.spltContainer.Panel2.Controls.Add(this.pictureBox1);
            this.spltContainer.Panel2.Controls.Add(this.groupBox3);
            this.spltContainer.Panel2.Controls.Add(this.groupBox2);
            this.spltContainer.Panel2.Controls.Add(this.groupBox1);
            this.spltContainer.Panel2.Enabled = false;
            this.spltContainer.Panel2.SizeChanged += new System.EventHandler(this.spltContainer_Panel2_SizeChanged);
            this.spltContainer.Size = new System.Drawing.Size(691, 416);
            this.spltContainer.SplitterDistance = 501;
            this.spltContainer.TabIndex = 0;
            // 
            // tabContainer
            // 
            this.tabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContainer.Location = new System.Drawing.Point(0, 0);
            this.tabContainer.Multiline = true;
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(501, 416);
            this.tabContainer.TabIndex = 0;
            this.tabContainer.SelectedIndexChanged += new System.EventHandler(this.tabContainer_SelectedIndexChanged);
            this.tabContainer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tabContainer_MouseUp);
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Location = new System.Drawing.Point(2, 400);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(103, 13);
            this.lblCopyRight.TabIndex = 6;
            this.lblCopyRight.Text = "Created by Csharp™";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FiestaEditor.Properties.Resources.Letter_F;
            this.pictureBox1.Location = new System.Drawing.Point(149, 380);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 46);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbEncoding);
            this.groupBox3.Location = new System.Drawing.Point(7, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 59);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Encoding";
            // 
            // cmbEncoding
            // 
            this.cmbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncoding.FormattingEnabled = true;
            this.cmbEncoding.Location = new System.Drawing.Point(9, 20);
            this.cmbEncoding.Name = "cmbEncoding";
            this.cmbEncoding.Size = new System.Drawing.Size(141, 21);
            this.cmbEncoding.TabIndex = 0;
            this.cmbEncoding.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cmbEncoding_MouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblRowIndex);
            this.groupBox2.Controls.Add(this.lblColumnType);
            this.groupBox2.Controls.Add(this.lblColumnSize);
            this.groupBox2.Controls.Add(this.lblColumnName);
            this.groupBox2.Location = new System.Drawing.Point(11, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 103);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cell Info:";
            // 
            // lblRowIndex
            // 
            this.lblRowIndex.AutoSize = true;
            this.lblRowIndex.Location = new System.Drawing.Point(9, 78);
            this.lblRowIndex.Name = "lblRowIndex";
            this.lblRowIndex.Size = new System.Drawing.Size(32, 13);
            this.lblRowIndex.TabIndex = 3;
            this.lblRowIndex.Text = "Row:";
            // 
            // lblColumnType
            // 
            this.lblColumnType.AutoSize = true;
            this.lblColumnType.Location = new System.Drawing.Point(9, 41);
            this.lblColumnType.Name = "lblColumnType";
            this.lblColumnType.Size = new System.Drawing.Size(34, 13);
            this.lblColumnType.TabIndex = 2;
            this.lblColumnType.Text = "Type:";
            // 
            // lblColumnSize
            // 
            this.lblColumnSize.AutoSize = true;
            this.lblColumnSize.Location = new System.Drawing.Point(9, 59);
            this.lblColumnSize.Name = "lblColumnSize";
            this.lblColumnSize.Size = new System.Drawing.Size(30, 13);
            this.lblColumnSize.TabIndex = 1;
            this.lblColumnSize.Text = "Size:";
            // 
            // lblColumnName
            // 
            this.lblColumnName.AutoSize = true;
            this.lblColumnName.Location = new System.Drawing.Point(9, 24);
            this.lblColumnName.Name = "lblColumnName";
            this.lblColumnName.Size = new System.Drawing.Size(38, 13);
            this.lblColumnName.TabIndex = 0;
            this.lblColumnName.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAutoFilter);
            this.groupBox1.Controls.Add(this.lblFilterHelp);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Location = new System.Drawing.Point(7, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Row Filter:";
            // 
            // chkAutoFilter
            // 
            this.chkAutoFilter.AutoSize = true;
            this.chkAutoFilter.Checked = true;
            this.chkAutoFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoFilter.Location = new System.Drawing.Point(79, 81);
            this.chkAutoFilter.Name = "chkAutoFilter";
            this.chkAutoFilter.Size = new System.Drawing.Size(88, 17);
            this.chkAutoFilter.TabIndex = 5;
            this.chkAutoFilter.Text = "While Typing";
            this.chkAutoFilter.UseVisualStyleBackColor = true;
            this.chkAutoFilter.CheckedChanged += new System.EventHandler(this.chkAutoFilter_CheckedChanged);
            // 
            // lblFilterHelp
            // 
            this.lblFilterHelp.AutoSize = true;
            this.lblFilterHelp.Location = new System.Drawing.Point(9, 82);
            this.lblFilterHelp.Name = "lblFilterHelp";
            this.lblFilterHelp.Size = new System.Drawing.Size(29, 13);
            this.lblFilterHelp.TabIndex = 4;
            this.lblFilterHelp.TabStop = true;
            this.lblFilterHelp.Text = "Help";
            this.lblFilterHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblFilterHelp_LinkClicked);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(44, 76);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(29, 25);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Go";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Visible = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click_1);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(6, 18);
            this.txtFilter.Multiline = true;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(159, 54);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // BottomStrip
            // 
            this.BottomStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.BottomStrip.Location = new System.Drawing.Point(0, 440);
            this.BottomStrip.Name = "BottomStrip";
            this.BottomStrip.Size = new System.Drawing.Size(691, 22);
            this.BottomStrip.TabIndex = 1;
            this.BottomStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 17);
            this.lblStatus.Text = "Ready.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replaceToolStripMenuItem,
            this.copyRowToolStripMenuItem,
            this.pasteRowToolStripMenuItem,
            this.exportSelectedToolStripMenuItem,
            this.importRowsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.replaceToolStripMenuItem.Text = "Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // copyRowToolStripMenuItem
            // 
            this.copyRowToolStripMenuItem.Name = "copyRowToolStripMenuItem";
            this.copyRowToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.copyRowToolStripMenuItem.Text = "Copy Selected";
            this.copyRowToolStripMenuItem.Click += new System.EventHandler(this.copyRowToolStripMenuItem_Click);
            // 
            // pasteRowToolStripMenuItem
            // 
            this.pasteRowToolStripMenuItem.Name = "pasteRowToolStripMenuItem";
            this.pasteRowToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.pasteRowToolStripMenuItem.Text = "Paste from Clipboard";
            this.pasteRowToolStripMenuItem.Click += new System.EventHandler(this.pasteRowToolStripMenuItem_Click);
            // 
            // exportSelectedToolStripMenuItem
            // 
            this.exportSelectedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem});
            this.exportSelectedToolStripMenuItem.Name = "exportSelectedToolStripMenuItem";
            this.exportSelectedToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exportSelectedToolStripMenuItem.Text = "Export Selected";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // importRowsToolStripMenuItem
            // 
            this.importRowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem1});
            this.importRowsToolStripMenuItem.Name = "importRowsToolStripMenuItem";
            this.importRowsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.importRowsToolStripMenuItem.Text = "Import Rows";
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.xMLToolStripMenuItem1.Text = "XML";
            this.xMLToolStripMenuItem1.Click += new System.EventHandler(this.xMLToolStripMenuItem1_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.translatorToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.Visible = false;
            // 
            // translatorToolStripMenuItem
            // 
            this.translatorToolStripMenuItem.Name = "translatorToolStripMenuItem";
            this.translatorToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.translatorToolStripMenuItem.Text = "Translator";
            this.translatorToolStripMenuItem.Click += new System.EventHandler(this.translatorToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 462);
            this.Controls.Add(this.spltContainer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BottomStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Fiesta Editor 2011 - RC2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.spltContainer.Panel1.ResumeLayout(false);
            this.spltContainer.Panel2.ResumeLayout(false);
            this.spltContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltContainer)).EndInit();
            this.spltContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.BottomStrip.ResumeLayout(false);
            this.BottomStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer spltContainer;
        public System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.StatusStrip BottomStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.LinkLabel lblFilterHelp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblColumnType;
        private System.Windows.Forms.Label lblColumnSize;
        private System.Windows.Forms.Label lblColumnName;
        private System.Windows.Forms.Label lblRowIndex;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translatorToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbEncoding;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importRowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkAutoFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCopyRight;

    }
}

