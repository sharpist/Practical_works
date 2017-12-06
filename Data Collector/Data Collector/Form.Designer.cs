namespace Data_Collector
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.dBDataSet = new Data_Collector.DBDataSet();
            this.profileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profileTableAdapter = new Data_Collector.DBDataSetTableAdapters.ProfileTableAdapter();
            this.tableAdapterManager = new Data_Collector.DBDataSetTableAdapters.TableAdapterManager();
            this.profileDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox = new System.Windows.Forms.TextBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.info = new System.Windows.Forms.Label();
            this.goWalker_button = new System.Windows.Forms.Button();
            this.useFilter_button = new System.Windows.Forms.Button();
            this.insertDB_button = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.textBoxProfession = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxDemand = new System.Windows.Forms.TextBox();
            this.recordDB_button = new System.Windows.Forms.Button();
            this.delDB_button = new System.Windows.Forms.Button();
            this.finderDB_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profileBindingSource
            // 
            this.profileBindingSource.DataMember = "Profile";
            this.profileBindingSource.DataSource = this.dBDataSet;
            // 
            // profileTableAdapter
            // 
            this.profileTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProfileTableAdapter = this.profileTableAdapter;
            this.tableAdapterManager.UpdateOrder = Data_Collector.DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // profileDataGridView
            // 
            this.profileDataGridView.AutoGenerateColumns = false;
            this.profileDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.profileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profileDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.profileDataGridView.DataSource = this.profileBindingSource;
            this.profileDataGridView.Location = new System.Drawing.Point(12, 30);
            this.profileDataGridView.MaximumSize = new System.Drawing.Size(720, 340);
            this.profileDataGridView.MinimumSize = new System.Drawing.Size(720, 340);
            this.profileDataGridView.Name = "profileDataGridView";
            this.profileDataGridView.Size = new System.Drawing.Size(720, 340);
            this.profileDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn2.HeaderText = "Company";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Profession";
            this.dataGridViewTextBoxColumn3.HeaderText = "Profession";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn4.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn5.HeaderText = "Description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Demand";
            this.dataGridViewTextBoxColumn6.HeaderText = "Demand";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(12, 406);
            this.textBox.MaximumSize = new System.Drawing.Size(400, 300);
            this.textBox.MaxLength = 50000;
            this.textBox.MinimumSize = new System.Drawing.Size(400, 300);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(400, 300);
            this.textBox.TabIndex = 2;
            // 
            // trackBar
            // 
            this.trackBar.LargeChange = 2;
            this.trackBar.Location = new System.Drawing.Point(420, 661);
            this.trackBar.Maximum = 50;
            this.trackBar.Minimum = 2;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(312, 45);
            this.trackBar.SmallChange = 2;
            this.trackBar.TabIndex = 2;
            this.trackBar.TickFrequency = 2;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar.Value = 2;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            this.trackBar.MouseEnter += new System.EventHandler(this.trackBar_MouseEnter);
            this.trackBar.MouseLeave += new System.EventHandler(this.trackBar_MouseLeave);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.ForeColor = System.Drawing.SystemColors.Desktop;
            this.info.Location = new System.Drawing.Point(12, 378);
            this.info.MaximumSize = new System.Drawing.Size(720, 20);
            this.info.MinimumSize = new System.Drawing.Size(720, 20);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(720, 20);
            this.info.TabIndex = 4;
            // 
            // goWalker_button
            // 
            this.goWalker_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goWalker_button.ForeColor = System.Drawing.SystemColors.WindowText;
            this.goWalker_button.Location = new System.Drawing.Point(420, 623);
            this.goWalker_button.Name = "goWalker_button";
            this.goWalker_button.Size = new System.Drawing.Size(100, 32);
            this.goWalker_button.TabIndex = 5;
            this.goWalker_button.Text = "www";
            this.goWalker_button.UseVisualStyleBackColor = true;
            this.goWalker_button.Click += new System.EventHandler(this.goWalker_button_Click);
            this.goWalker_button.MouseEnter += new System.EventHandler(this.goWalker_button_MouseEnter);
            this.goWalker_button.MouseLeave += new System.EventHandler(this.goWalker_button_MouseLeave);
            // 
            // useFilter_button
            // 
            this.useFilter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.useFilter_button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.useFilter_button.Location = new System.Drawing.Point(526, 623);
            this.useFilter_button.Name = "useFilter_button";
            this.useFilter_button.Size = new System.Drawing.Size(100, 32);
            this.useFilter_button.TabIndex = 6;
            this.useFilter_button.Text = "Фильтр";
            this.useFilter_button.UseVisualStyleBackColor = true;
            this.useFilter_button.Click += new System.EventHandler(this.useFilter_button_Click);
            this.useFilter_button.MouseEnter += new System.EventHandler(this.useFilter_button_MouseEnter);
            this.useFilter_button.MouseLeave += new System.EventHandler(this.useFilter_button_MouseLeave);
            // 
            // insertDB_button
            // 
            this.insertDB_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertDB_button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.insertDB_button.Location = new System.Drawing.Point(526, 566);
            this.insertDB_button.Name = "insertDB_button";
            this.insertDB_button.Size = new System.Drawing.Size(100, 32);
            this.insertDB_button.TabIndex = 7;
            this.insertDB_button.Text = "Вставить";
            this.insertDB_button.UseVisualStyleBackColor = true;
            this.insertDB_button.Click += new System.EventHandler(this.insertDB_button_Click);
            this.insertDB_button.MouseEnter += new System.EventHandler(this.insertDB_button_MouseEnter);
            this.insertDB_button.MouseLeave += new System.EventHandler(this.insertDB_button_MouseLeave);
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(744, 27);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCompany.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxCompany.Location = new System.Drawing.Point(526, 406);
            this.textBoxCompany.MaximumSize = new System.Drawing.Size(206, 26);
            this.textBoxCompany.MinimumSize = new System.Drawing.Size(206, 26);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(206, 26);
            this.textBoxCompany.TabIndex = 9;
            this.textBoxCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCompany.MouseEnter += new System.EventHandler(this.textBoxCompany_MouseEnter);
            this.textBoxCompany.MouseLeave += new System.EventHandler(this.textBoxCompany_MouseLeave);
            // 
            // textBoxProfession
            // 
            this.textBoxProfession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProfession.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxProfession.Location = new System.Drawing.Point(526, 438);
            this.textBoxProfession.MaximumSize = new System.Drawing.Size(206, 26);
            this.textBoxProfession.MinimumSize = new System.Drawing.Size(206, 26);
            this.textBoxProfession.Name = "textBoxProfession";
            this.textBoxProfession.Size = new System.Drawing.Size(206, 26);
            this.textBoxProfession.TabIndex = 10;
            this.textBoxProfession.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxProfession.MouseEnter += new System.EventHandler(this.textBoxProfession_MouseEnter);
            this.textBoxProfession.MouseLeave += new System.EventHandler(this.textBoxProfession_MouseLeave);
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSalary.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxSalary.Location = new System.Drawing.Point(526, 470);
            this.textBoxSalary.MaximumSize = new System.Drawing.Size(206, 26);
            this.textBoxSalary.MinimumSize = new System.Drawing.Size(206, 26);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(206, 26);
            this.textBoxSalary.TabIndex = 11;
            this.textBoxSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSalary.MouseEnter += new System.EventHandler(this.textBoxSalary_MouseEnter);
            this.textBoxSalary.MouseLeave += new System.EventHandler(this.textBoxSalary_MouseLeave);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDescription.Location = new System.Drawing.Point(526, 502);
            this.textBoxDescription.MaximumSize = new System.Drawing.Size(206, 26);
            this.textBoxDescription.MinimumSize = new System.Drawing.Size(206, 26);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(206, 26);
            this.textBoxDescription.TabIndex = 12;
            this.textBoxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDescription.MouseEnter += new System.EventHandler(this.textBoxDescription_MouseEnter);
            this.textBoxDescription.MouseLeave += new System.EventHandler(this.textBoxDescription_MouseLeave);
            // 
            // textBoxDemand
            // 
            this.textBoxDemand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDemand.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDemand.Location = new System.Drawing.Point(526, 534);
            this.textBoxDemand.MaximumSize = new System.Drawing.Size(206, 26);
            this.textBoxDemand.MinimumSize = new System.Drawing.Size(206, 26);
            this.textBoxDemand.Name = "textBoxDemand";
            this.textBoxDemand.Size = new System.Drawing.Size(206, 26);
            this.textBoxDemand.TabIndex = 13;
            this.textBoxDemand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDemand.MouseEnter += new System.EventHandler(this.textBoxDemand_MouseEnter);
            this.textBoxDemand.MouseLeave += new System.EventHandler(this.textBoxDemand_MouseLeave);
            // 
            // recordDB_button
            // 
            this.recordDB_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recordDB_button.ForeColor = System.Drawing.Color.Crimson;
            this.recordDB_button.Location = new System.Drawing.Point(632, 623);
            this.recordDB_button.Name = "recordDB_button";
            this.recordDB_button.Size = new System.Drawing.Size(100, 32);
            this.recordDB_button.TabIndex = 14;
            this.recordDB_button.Text = "Запись";
            this.recordDB_button.UseVisualStyleBackColor = true;
            this.recordDB_button.Click += new System.EventHandler(this.recordDB_button_Click);
            this.recordDB_button.MouseEnter += new System.EventHandler(this.recordDB_button_MouseEnter);
            this.recordDB_button.MouseLeave += new System.EventHandler(this.recordDB_button_MouseLeave);
            // 
            // delDB_button
            // 
            this.delDB_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delDB_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delDB_button.Location = new System.Drawing.Point(632, 566);
            this.delDB_button.Name = "delDB_button";
            this.delDB_button.Size = new System.Drawing.Size(100, 32);
            this.delDB_button.TabIndex = 15;
            this.delDB_button.Text = "Удалить";
            this.delDB_button.UseVisualStyleBackColor = true;
            this.delDB_button.Click += new System.EventHandler(this.delDB_button_Click);
            this.delDB_button.MouseEnter += new System.EventHandler(this.delDB_button_MouseEnter);
            this.delDB_button.MouseLeave += new System.EventHandler(this.delDB_button_MouseLeave);
            // 
            // finderDB_button
            // 
            this.finderDB_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finderDB_button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.finderDB_button.Location = new System.Drawing.Point(488, 467);
            this.finderDB_button.Name = "finderDB_button";
            this.finderDB_button.Size = new System.Drawing.Size(32, 32);
            this.finderDB_button.TabIndex = 16;
            this.finderDB_button.Text = "?";
            this.finderDB_button.UseVisualStyleBackColor = true;
            this.finderDB_button.Click += new System.EventHandler(this.finderDB_button_Click);
            this.finderDB_button.MouseEnter += new System.EventHandler(this.finderDB_button_MouseEnter);
            this.finderDB_button.MouseLeave += new System.EventHandler(this.finderDB_button_MouseLeave);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 721);
            this.Controls.Add(this.finderDB_button);
            this.Controls.Add(this.delDB_button);
            this.Controls.Add(this.recordDB_button);
            this.Controls.Add(this.textBoxDemand);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxProfession);
            this.Controls.Add(this.textBoxCompany);
            this.Controls.Add(this.insertDB_button);
            this.Controls.Add(this.useFilter_button);
            this.Controls.Add(this.goWalker_button);
            this.Controls.Add(this.info);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.profileDataGridView);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(760, 760);
            this.MinimumSize = new System.Drawing.Size(760, 760);
            this.Name = "Form";
            this.Text = "Data Collector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource profileBindingSource;
        private DBDataSetTableAdapters.ProfileTableAdapter profileTableAdapter;
        private DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView profileDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button goWalker_button;
        private System.Windows.Forms.Button useFilter_button;
        private System.Windows.Forms.Button insertDB_button;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.TextBox textBoxProfession;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxDemand;
        private System.Windows.Forms.Button recordDB_button;
        private System.Windows.Forms.Button delDB_button;
        private System.Windows.Forms.Button finderDB_button;
    }
}

