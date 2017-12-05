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
            this.profileBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.profileBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingNavigator)).BeginInit();
            this.profileBindingNavigator.SuspendLayout();
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
            // profileBindingNavigator
            // 
            this.profileBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.profileBindingNavigator.BindingSource = this.profileBindingSource;
            this.profileBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.profileBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.profileBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.profileBindingNavigatorSaveItem});
            this.profileBindingNavigator.Location = new System.Drawing.Point(0, 27);
            this.profileBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.profileBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.profileBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.profileBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.profileBindingNavigator.Name = "profileBindingNavigator";
            this.profileBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.profileBindingNavigator.Size = new System.Drawing.Size(744, 25);
            this.profileBindingNavigator.TabIndex = 0;
            this.profileBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // profileBindingNavigatorSaveItem
            // 
            this.profileBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.profileBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("profileBindingNavigatorSaveItem.Image")));
            this.profileBindingNavigatorSaveItem.Name = "profileBindingNavigatorSaveItem";
            this.profileBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.profileBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.profileBindingNavigatorSaveItem.Click += new System.EventHandler(this.profileBindingNavigatorSaveItem_Click);
            // 
            // profileDataGridView
            // 
            this.profileDataGridView.AutoGenerateColumns = false;
            this.profileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profileDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.profileDataGridView.DataSource = this.profileBindingSource;
            this.profileDataGridView.Location = new System.Drawing.Point(12, 55);
            this.profileDataGridView.MaximumSize = new System.Drawing.Size(720, 320);
            this.profileDataGridView.MinimumSize = new System.Drawing.Size(720, 320);
            this.profileDataGridView.Name = "profileDataGridView";
            this.profileDataGridView.Size = new System.Drawing.Size(720, 320);
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
            this.useFilter_button.ForeColor = System.Drawing.Color.Crimson;
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
            this.insertDB_button.Location = new System.Drawing.Point(632, 623);
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
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
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
            this.textBoxCompany.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxCompany.Location = new System.Drawing.Point(420, 406);
            this.textBoxCompany.MaximumSize = new System.Drawing.Size(312, 26);
            this.textBoxCompany.MinimumSize = new System.Drawing.Size(312, 26);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(312, 26);
            this.textBoxCompany.TabIndex = 9;
            this.textBoxCompany.Text = "Компания...";
            this.textBoxCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxProfession
            // 
            this.textBoxProfession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProfession.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxProfession.Location = new System.Drawing.Point(420, 438);
            this.textBoxProfession.MaximumSize = new System.Drawing.Size(312, 26);
            this.textBoxProfession.MinimumSize = new System.Drawing.Size(312, 26);
            this.textBoxProfession.Name = "textBoxProfession";
            this.textBoxProfession.Size = new System.Drawing.Size(312, 26);
            this.textBoxProfession.TabIndex = 10;
            this.textBoxProfession.Text = "Должность...";
            this.textBoxProfession.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSalary.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxSalary.Location = new System.Drawing.Point(420, 470);
            this.textBoxSalary.MaximumSize = new System.Drawing.Size(312, 26);
            this.textBoxSalary.MinimumSize = new System.Drawing.Size(312, 26);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(312, 26);
            this.textBoxSalary.TabIndex = 11;
            this.textBoxSalary.Text = "Зарплата...";
            this.textBoxSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDescription.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxDescription.Location = new System.Drawing.Point(420, 502);
            this.textBoxDescription.MaximumSize = new System.Drawing.Size(312, 26);
            this.textBoxDescription.MinimumSize = new System.Drawing.Size(312, 26);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(312, 26);
            this.textBoxDescription.TabIndex = 12;
            this.textBoxDescription.Text = "Описание...";
            this.textBoxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDemand
            // 
            this.textBoxDemand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDemand.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxDemand.Location = new System.Drawing.Point(420, 534);
            this.textBoxDemand.MaximumSize = new System.Drawing.Size(312, 26);
            this.textBoxDemand.MinimumSize = new System.Drawing.Size(312, 26);
            this.textBoxDemand.Name = "textBoxDemand";
            this.textBoxDemand.Size = new System.Drawing.Size(312, 26);
            this.textBoxDemand.TabIndex = 13;
            this.textBoxDemand.Text = "Требования...";
            this.textBoxDemand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 721);
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
            this.Controls.Add(this.profileBindingNavigator);
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
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingNavigator)).EndInit();
            this.profileBindingNavigator.ResumeLayout(false);
            this.profileBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.BindingNavigator profileBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton profileBindingNavigatorSaveItem;
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
    }
}

