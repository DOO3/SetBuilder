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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.bSave = new System.Windows.Forms.Button();
            this.dgvStats = new System.Windows.Forms.DataGridView();
            this.bClosePanel = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLevel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lInformationSpecialization = new System.Windows.Forms.Label();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.bPictureBrowse = new System.Windows.Forms.Button();
            this.cbClass = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbStat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tbStatValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
            this.gbInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(502, 24);
            this.msMain.TabIndex = 4;
            this.msMain.Text = "menuStrip1";
            this.msMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.msMain_MouseDown);
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSave.ForeColor = System.Drawing.SystemColors.Control;
            this.bSave.Location = new System.Drawing.Point(99, 381);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(127, 38);
            this.bSave.TabIndex = 7;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // dgvStats
            // 
            this.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbStat,
            this.tbStatValue});
            this.dgvStats.Location = new System.Drawing.Point(255, 48);
            this.dgvStats.Name = "dgvStats";
            this.dgvStats.RowHeadersWidth = 25;
            this.dgvStats.Size = new System.Drawing.Size(228, 315);
            this.dgvStats.TabIndex = 6;
            // 
            // bClosePanel
            // 
            this.bClosePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClosePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bClosePanel.FlatAppearance.BorderSize = 0;
            this.bClosePanel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bClosePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClosePanel.ForeColor = System.Drawing.Color.White;
            this.bClosePanel.Location = new System.Drawing.Point(723, -52);
            this.bClosePanel.Name = "bClosePanel";
            this.bClosePanel.Size = new System.Drawing.Size(24, 24);
            this.bClosePanel.TabIndex = 5;
            this.bClosePanel.Text = "X";
            this.bClosePanel.UseVisualStyleBackColor = false;
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bClose.FlatAppearance.BorderSize = 0;
            this.bClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.ForeColor = System.Drawing.Color.White;
            this.bClose.Location = new System.Drawing.Point(478, 0);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(24, 24);
            this.bClose.TabIndex = 8;
            this.bClose.Text = "X";
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.bCancel.Location = new System.Drawing.Point(255, 381);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(127, 38);
            this.bCancel.TabIndex = 9;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // gbInformation
            // 
            this.gbInformation.Controls.Add(this.tbName);
            this.gbInformation.Controls.Add(this.label2);
            this.gbInformation.Controls.Add(this.tbLevel);
            this.gbInformation.Controls.Add(this.label1);
            this.gbInformation.Controls.Add(this.dgvClass);
            this.gbInformation.Controls.Add(this.cbCategory);
            this.gbInformation.Controls.Add(this.lInformationSpecialization);
            this.gbInformation.Controls.Add(this.pbPicture);
            this.gbInformation.Controls.Add(this.bPictureBrowse);
            this.gbInformation.Location = new System.Drawing.Point(12, 39);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(222, 324);
            this.gbInformation.TabIndex = 10;
            this.gbInformation.TabStop = false;
            this.gbInformation.Text = "Information:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(9, 143);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(207, 69);
            this.tbName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name:";
            // 
            // tbLevel
            // 
            this.tbLevel.Location = new System.Drawing.Point(9, 94);
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.Size = new System.Drawing.Size(122, 20);
            this.tbLevel.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Level:";
            // 
            // dgvClass
            // 
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbClass});
            this.dgvClass.Location = new System.Drawing.Point(9, 229);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.RowHeadersWidth = 25;
            this.dgvClass.Size = new System.Drawing.Size(207, 86);
            this.dgvClass.TabIndex = 16;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Шлем",
            "Доспех",
            "Руки",
            "Правая рука",
            "Левая рука",
            "Ноги",
            "Шея",
            "Кольцо",
            "Пояс",
            "Рубаха",
            "Штаны",
            "Артефакт",
            "Скакун"});
            this.cbCategory.Location = new System.Drawing.Point(9, 35);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(122, 21);
            this.cbCategory.TabIndex = 13;
            // 
            // lInformationSpecialization
            // 
            this.lInformationSpecialization.AutoSize = true;
            this.lInformationSpecialization.Location = new System.Drawing.Point(6, 19);
            this.lInformationSpecialization.Name = "lInformationSpecialization";
            this.lInformationSpecialization.Size = new System.Drawing.Size(52, 13);
            this.lInformationSpecialization.TabIndex = 12;
            this.lInformationSpecialization.Text = "Category:";
            // 
            // pbPicture
            // 
            this.pbPicture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbPicture.Location = new System.Drawing.Point(150, 19);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(66, 66);
            this.pbPicture.TabIndex = 0;
            this.pbPicture.TabStop = false;
            // 
            // bPictureBrowse
            // 
            this.bPictureBrowse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bPictureBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bPictureBrowse.ForeColor = System.Drawing.SystemColors.Control;
            this.bPictureBrowse.Location = new System.Drawing.Point(150, 91);
            this.bPictureBrowse.Name = "bPictureBrowse";
            this.bPictureBrowse.Size = new System.Drawing.Size(66, 24);
            this.bPictureBrowse.TabIndex = 11;
            this.bPictureBrowse.Text = "Browse";
            this.bPictureBrowse.UseVisualStyleBackColor = false;
            this.bPictureBrowse.Click += new System.EventHandler(this.bPictureBrowse_Click);
            // 
            // cbClass
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.cbClass.DefaultCellStyle = dataGridViewCellStyle1;
            this.cbClass.HeaderText = "Class";
            this.cbClass.Items.AddRange(new object[] {
            "Все",
            "Волшебник повелитель",
            "Истовый клирик",
            "Бесстрашный воин",
            "Воин страж",
            "Праведный паладин",
            "Охотник следопыт",
            "Чернокнижник мучитель",
            "Плут ловкач"});
            this.cbClass.Name = "cbClass";
            this.cbClass.Width = 160;
            // 
            // cbStat
            // 
            this.cbStat.HeaderText = "Stat";
            this.cbStat.Items.AddRange(new object[] {
            "Могущество",
            "Вероятность критического удара",
            "Проникающий урон",
            "Восстановление сил",
            "Получаемые очки действий",
            "Боевое преимущество",
            "Бонус контролю",
            "Оборона",
            "Парирование",
            "Восстановление",
            "Вампиризм",
            "Эффективность вампиризма",
            "Нейстрашимость(PvP)",
            "Получаемая бодрость",
            "Принимаемое лечение",
            "Сопротивляемость урону по области",
            "Сопротивляемость контролю",
            "Скорость",
            "Влияние спутника",
            "Получаемое золото",
            "Хиты"});
            this.cbStat.Name = "cbStat";
            // 
            // tbStatValue
            // 
            this.tbStatValue.HeaderText = "Value";
            this.tbStatValue.Name = "tbStatValue";
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(502, 443);
            this.Controls.Add(this.gbInformation);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.dgvStats);
            this.Controls.Add(this.bClosePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEditForm";
            this.Text = "AddEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
            this.gbInformation.ResumeLayout(false);
            this.gbInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.DataGridView dgvStats;
        private System.Windows.Forms.Button bClosePanel;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lInformationSpecialization;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button bPictureBrowse;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbStatValue;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbClass;
    }
}