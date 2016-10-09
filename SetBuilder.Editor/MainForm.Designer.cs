using System.Drawing;

namespace SetBuilder.Editor
{
    sealed partial class MainForm
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bClose = new System.Windows.Forms.ToolStripMenuItem();
            this.bClosePanel = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.imagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAdd = new System.Windows.Forms.Button();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.sSave = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(530, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            this.msMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.msMain_MouseDown);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sSave,
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
            this.bOpen.Size = new System.Drawing.Size(152, 22);
            this.bOpen.Text = "Open";
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // bClose
            // 
            this.bClose.Name = "bClose";
            this.bClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.bClose.Size = new System.Drawing.Size(152, 22);
            this.bClose.Text = "Close";
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bClosePanel
            // 
            this.bClosePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClosePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bClosePanel.FlatAppearance.BorderSize = 0;
            this.bClosePanel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bClosePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClosePanel.ForeColor = System.Drawing.Color.White;
            this.bClosePanel.Location = new System.Drawing.Point(506, 0);
            this.bClosePanel.Name = "bClosePanel";
            this.bClosePanel.Size = new System.Drawing.Size(24, 24);
            this.bClosePanel.TabIndex = 1;
            this.bClosePanel.Text = "X";
            this.bClosePanel.UseVisualStyleBackColor = false;
            this.bClosePanel.Click += new System.EventHandler(this.bClosePanel_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoGenerateColumns = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imagePathDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn});
            this.dgvItems.DataSource = this.itemBindingSource;
            this.dgvItems.Location = new System.Drawing.Point(12, 37);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowTemplate.Height = 64;
            this.dgvItems.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.Size = new System.Drawing.Size(500, 257);
            this.dgvItems.TabIndex = 2;
            // 
            // imagePathDataGridViewTextBoxColumn
            // 
            this.imagePathDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.imagePathDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imagePathDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imagePathDataGridViewTextBoxColumn.Name = "imagePathDataGridViewTextBoxColumn";
            this.imagePathDataGridViewTextBoxColumn.ReadOnly = true;
            this.imagePathDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imagePathDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.imagePathDataGridViewTextBoxColumn.Width = 64;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "Level";
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(SetBuilder.Library.Item);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.bAdd.Location = new System.Drawing.Point(70, 300);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(127, 38);
            this.bAdd.TabIndex = 3;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.itemBindingSource;
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.bEdit.Location = new System.Drawing.Point(203, 300);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(127, 38);
            this.bEdit.TabIndex = 4;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.bDelete.Location = new System.Drawing.Point(336, 300);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(127, 38);
            this.bDelete.TabIndex = 5;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // sSave
            // 
            this.sSave.Name = "sSave";
            this.sSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sSave.Size = new System.Drawing.Size(152, 22);
            this.sSave.Text = "Save";
            this.sSave.Click += new System.EventHandler(this.sSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(530, 345);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.bClosePanel);
            this.Controls.Add(this.msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.msMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem bClose;
        private System.Windows.Forms.Button bClosePanel;
        private System.Windows.Forms.ToolStripMenuItem bOpen;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn imagePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.ToolStripMenuItem sSave;
    }
}

