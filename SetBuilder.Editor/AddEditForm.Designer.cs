namespace SetBuilder.Editor
{
    partial class AddEditForm
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bClose = new System.Windows.Forms.ToolStripMenuItem();
            this.bAdd = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.bClosePanel = new System.Windows.Forms.Button();
            this.cbStat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbStatValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(854, 24);
            this.msMain.TabIndex = 4;
            this.msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bOpen,
            this.toolStripSeparator1,
            this.bClose});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // bOpen
            // 
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(145, 22);
            this.bOpen.Text = "Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // bClose
            // 
            this.bClose.Name = "bClose";
            this.bClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.bClose.Size = new System.Drawing.Size(145, 22);
            this.bClose.Text = "Close";
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.bAdd.Location = new System.Drawing.Point(248, 444);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(127, 38);
            this.bAdd.TabIndex = 7;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = false;
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbStat,
            this.cbStatValue});
            this.dgvItems.Location = new System.Drawing.Point(406, 38);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowHeadersWidth = 40;
            this.dgvItems.Size = new System.Drawing.Size(203, 257);
            this.dgvItems.TabIndex = 6;
            // 
            // bClosePanel
            // 
            this.bClosePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClosePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bClosePanel.FlatAppearance.BorderSize = 0;
            this.bClosePanel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bClosePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClosePanel.ForeColor = System.Drawing.Color.White;
            this.bClosePanel.Location = new System.Drawing.Point(1075, -52);
            this.bClosePanel.Name = "bClosePanel";
            this.bClosePanel.Size = new System.Drawing.Size(24, 24);
            this.bClosePanel.TabIndex = 5;
            this.bClosePanel.Text = "X";
            this.bClosePanel.UseVisualStyleBackColor = false;
            // 
            // cbStat
            // 
            this.cbStat.HeaderText = "Stat";
            this.cbStat.Items.AddRange(new object[] {
            "HP",
            "MP"});
            this.cbStat.Name = "cbStat";
            // 
            // cbStatValue
            // 
            this.cbStatValue.HeaderText = "Value";
            this.cbStatValue.Name = "cbStatValue";
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 592);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.bClosePanel);
            this.Name = "AddEditForm";
            this.Text = "AddEditForm";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem bClose;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button bClosePanel;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbStatValue;
    }
}