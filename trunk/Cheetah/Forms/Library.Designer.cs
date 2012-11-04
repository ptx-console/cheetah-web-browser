namespace Cheetah.Forms
{
    partial class Library
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.QTabControl1 = new Qios.DevSuite.Components.QTabControl();
            this.qTabPage2 = new Qios.DevSuite.Components.QTabPage();
            this.historydatagridview = new System.Windows.Forms.DataGridView();
            this.faviconDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hisItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFindHis = new System.Windows.Forms.TextBox();
            this.txtUrlHis = new System.Windows.Forms.TextBox();
            this.btnNavHis = new Cheetah.MetroToolkit.MetroButton();
            this.txtNameHis = new System.Windows.Forms.TextBox();
            this.metroButton3 = new Cheetah.MetroToolkit.MetroButton();
            this.metroButton4 = new Cheetah.MetroToolkit.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.qTabPage1 = new Qios.DevSuite.Components.QTabPage();
            this.bookmarksdatagridview = new System.Windows.Forms.DataGridView();
            this.faviconDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFindBook = new System.Windows.Forms.TextBox();
            this.txtUrlBook = new System.Windows.Forms.TextBox();
            this.btnNavBook = new Cheetah.MetroToolkit.MetroButton();
            this.txtNameBook = new System.Windows.Forms.TextBox();
            this.metroButton2 = new Cheetah.MetroToolkit.MetroButton();
            this.metroButton1 = new Cheetah.MetroToolkit.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QShape1 = new Qios.DevSuite.Components.QShape();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCheetah = new System.Windows.Forms.Label();
            this.CloseTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.QTabControl1)).BeginInit();
            this.QTabControl1.SuspendLayout();
            this.qTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historydatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisItemBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.qTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookmarksdatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favItemBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 517);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 5);
            this.panel1.TabIndex = 138;
            // 
            // QTabControl1
            // 
            this.QTabControl1.ActiveTabPage = this.qTabPage2;
            this.QTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QTabControl1.ColorScheme.InheritCurrentThemeFromGlobal = false;
            this.QTabControl1.ColorScheme.TabControlBorder.SetColor("Default", System.Drawing.Color.White, false);
            this.QTabControl1.Controls.Add(this.qTabPage2);
            this.QTabControl1.Controls.Add(this.qTabPage1);
            this.QTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.QTabControl1.FocusTabButtons = false;
            this.QTabControl1.Location = new System.Drawing.Point(10, 45);
            this.QTabControl1.Name = "QTabControl1";
            this.QTabControl1.PersistGuid = new System.Guid("bed8bfe9-bbf5-4ac4-8714-768daff6ef89");
            this.QTabControl1.Size = new System.Drawing.Size(476, 474);
            this.QTabControl1.TabIndex = 144;
            this.QTabControl1.TabStripLeftConfiguration.AllowDrag = false;
            this.QTabControl1.TabStripLeftConfiguration.AllowDrop = false;
            this.QTabControl1.TabStripLeftConfiguration.Appearance.BorderWidth = 0;
            this.QTabControl1.TabStripLeftConfiguration.NavigationAreaAppearance.BorderWidth = 0;
            this.QTabControl1.TabStripTopConfiguration.Appearance.BorderWidth = 0;
            this.QTabControl1.TabStripTopConfiguration.ButtonConfiguration.Appearance.Shape = this.QShape1;
            this.QTabControl1.TabStripTopConfiguration.ButtonConfiguration.IconSpacing = new Qios.DevSuite.Components.QSpacing(0, 0);
            this.QTabControl1.TabStripTopConfiguration.ButtonConfiguration.MaximumSize = new System.Drawing.Size(145, 24);
            this.QTabControl1.TabStripTopConfiguration.ButtonConfiguration.MinimumSize = new System.Drawing.Size(145, 24);
            this.QTabControl1.TabStripTopConfiguration.ButtonConfiguration.Padding = new Qios.DevSuite.Components.QPadding(3, 2, 1, 17);
            this.QTabControl1.TabStripTopConfiguration.ButtonSpacing = 0;
            this.QTabControl1.TabStripTopConfiguration.SizeBehavior = Qios.DevSuite.Components.QTabStripSizeBehaviors.None;
            this.QTabControl1.TabStripTopConfiguration.StackBehavior = Qios.DevSuite.Components.QTabStripStackBehaviors.None;
            this.QTabControl1.Text = "QTabControl1";
            this.QTabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QTabControl1_MouseDown);
            // 
            // qTabPage2
            // 
            this.qTabPage2.ButtonOrder = 1;
            this.qTabPage2.Controls.Add(this.historydatagridview);
            this.qTabPage2.Controls.Add(this.panel3);
            this.qTabPage2.Location = new System.Drawing.Point(0, 30);
            this.qTabPage2.Name = "qTabPage2";
            this.qTabPage2.PersistGuid = new System.Guid("8a11e7e4-d8fe-497d-8960-6232278ce9ab");
            this.qTabPage2.Size = new System.Drawing.Size(474, 442);
            this.qTabPage2.Text = "History";
            // 
            // historydatagridview
            // 
            this.historydatagridview.AllowUserToAddRows = false;
            this.historydatagridview.AutoGenerateColumns = false;
            this.historydatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historydatagridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.historydatagridview.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.historydatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historydatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historydatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faviconDataGridViewImageColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.urlDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn});
            this.historydatagridview.DataSource = this.hisItemBindingSource;
            this.historydatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historydatagridview.Location = new System.Drawing.Point(0, 0);
            this.historydatagridview.Name = "historydatagridview";
            this.historydatagridview.ReadOnly = true;
            this.historydatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historydatagridview.Size = new System.Drawing.Size(474, 310);
            this.historydatagridview.TabIndex = 2;
            this.historydatagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historydatagridview_CellClick);
            this.historydatagridview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historydatagridview_CellDoubleClick);
            // 
            // faviconDataGridViewImageColumn1
            // 
            this.faviconDataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.faviconDataGridViewImageColumn1.DataPropertyName = "Favicon";
            this.faviconDataGridViewImageColumn1.FillWeight = 60.9137F;
            this.faviconDataGridViewImageColumn1.HeaderText = "";
            this.faviconDataGridViewImageColumn1.Name = "faviconDataGridViewImageColumn1";
            this.faviconDataGridViewImageColumn1.ReadOnly = true;
            this.faviconDataGridViewImageColumn1.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.FillWeight = 113.0288F;
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // urlDataGridViewTextBoxColumn1
            // 
            this.urlDataGridViewTextBoxColumn1.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn1.FillWeight = 113.0288F;
            this.urlDataGridViewTextBoxColumn1.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn1.Name = "urlDataGridViewTextBoxColumn1";
            this.urlDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.FillWeight = 92.02876F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hisItemBindingSource
            // 
            this.hisItemBindingSource.DataSource = typeof(HisItem);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtFindHis);
            this.panel3.Controls.Add(this.txtUrlHis);
            this.panel3.Controls.Add(this.btnNavHis);
            this.panel3.Controls.Add(this.txtNameHis);
            this.panel3.Controls.Add(this.metroButton3);
            this.panel3.Controls.Add(this.metroButton4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 310);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 132);
            this.panel3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(262, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 150;
            this.label5.Text = "Find :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFindHis
            // 
            this.txtFindHis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFindHis.Location = new System.Drawing.Point(309, 10);
            this.txtFindHis.Name = "txtFindHis";
            this.txtFindHis.Size = new System.Drawing.Size(152, 23);
            this.txtFindHis.TabIndex = 149;
            this.txtFindHis.TextChanged += new System.EventHandler(this.txtFindHis_TextChanged);
            // 
            // txtUrlHis
            // 
            this.txtUrlHis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrlHis.Location = new System.Drawing.Point(61, 68);
            this.txtUrlHis.Name = "txtUrlHis";
            this.txtUrlHis.ReadOnly = true;
            this.txtUrlHis.Size = new System.Drawing.Size(400, 23);
            this.txtUrlHis.TabIndex = 148;
            // 
            // btnNavHis
            // 
            this.btnNavHis.BackColor = System.Drawing.Color.Gold;
            this.btnNavHis.ButtonText = "NAVIGATE";
            this.btnNavHis.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnNavHis.ForceUppercase = true;
            this.btnNavHis.ForeColor = System.Drawing.Color.Black;
            this.btnNavHis.Location = new System.Drawing.Point(191, 97);
            this.btnNavHis.Name = "btnNavHis";
            this.btnNavHis.Size = new System.Drawing.Size(86, 26);
            this.btnNavHis.TabIndex = 6;
            this.btnNavHis.Click += new System.EventHandler(this.btnNavHis_Click);
            // 
            // txtNameHis
            // 
            this.txtNameHis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameHis.Location = new System.Drawing.Point(61, 39);
            this.txtNameHis.Name = "txtNameHis";
            this.txtNameHis.ReadOnly = true;
            this.txtNameHis.Size = new System.Drawing.Size(400, 23);
            this.txtNameHis.TabIndex = 147;
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.Gold;
            this.metroButton3.ButtonText = "CLEAR";
            this.metroButton3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.metroButton3.ForceUppercase = true;
            this.metroButton3.ForeColor = System.Drawing.Color.Black;
            this.metroButton3.Location = new System.Drawing.Point(375, 97);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(86, 26);
            this.metroButton3.TabIndex = 5;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.Color.Gold;
            this.metroButton4.ButtonText = "REMOVE";
            this.metroButton4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.metroButton4.ForceUppercase = true;
            this.metroButton4.ForeColor = System.Drawing.Color.Black;
            this.metroButton4.Location = new System.Drawing.Point(283, 97);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(86, 26);
            this.metroButton4.TabIndex = 4;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 146;
            this.label3.Text = "URL :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 145;
            this.label4.Text = "Name :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qTabPage1
            // 
            this.qTabPage1.ButtonOrder = 0;
            this.qTabPage1.Controls.Add(this.bookmarksdatagridview);
            this.qTabPage1.Controls.Add(this.panel2);
            this.qTabPage1.Location = new System.Drawing.Point(0, 30);
            this.qTabPage1.Name = "qTabPage1";
            this.qTabPage1.PersistGuid = new System.Guid("8235e55f-d561-4d1f-b9a2-258a60ea31d1");
            this.qTabPage1.Size = new System.Drawing.Size(476, 444);
            this.qTabPage1.Text = "Bookmarks";
            // 
            // bookmarksdatagridview
            // 
            this.bookmarksdatagridview.AllowUserToAddRows = false;
            this.bookmarksdatagridview.AutoGenerateColumns = false;
            this.bookmarksdatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookmarksdatagridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bookmarksdatagridview.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.bookmarksdatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookmarksdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookmarksdatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faviconDataGridViewImageColumn,
            this.nameDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn});
            this.bookmarksdatagridview.DataSource = this.favItemBindingSource;
            this.bookmarksdatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookmarksdatagridview.Location = new System.Drawing.Point(0, 0);
            this.bookmarksdatagridview.Name = "bookmarksdatagridview";
            this.bookmarksdatagridview.ReadOnly = true;
            this.bookmarksdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookmarksdatagridview.Size = new System.Drawing.Size(476, 312);
            this.bookmarksdatagridview.TabIndex = 1;
            this.bookmarksdatagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookmarksdatagridview_CellClick);
            this.bookmarksdatagridview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookmarksdatagridview_CellDoubleClick);
            // 
            // faviconDataGridViewImageColumn
            // 
            this.faviconDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.faviconDataGridViewImageColumn.DataPropertyName = "Favicon";
            this.faviconDataGridViewImageColumn.FillWeight = 42.6396F;
            this.faviconDataGridViewImageColumn.HeaderText = " ";
            this.faviconDataGridViewImageColumn.Name = "faviconDataGridViewImageColumn";
            this.faviconDataGridViewImageColumn.ReadOnly = true;
            this.faviconDataGridViewImageColumn.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 84.9296F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.FillWeight = 192.4308F;
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // favItemBindingSource
            // 
            this.favItemBindingSource.DataSource = typeof(FavItem);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtFindBook);
            this.panel2.Controls.Add(this.txtUrlBook);
            this.panel2.Controls.Add(this.btnNavBook);
            this.panel2.Controls.Add(this.txtNameBook);
            this.panel2.Controls.Add(this.metroButton2);
            this.panel2.Controls.Add(this.metroButton1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 132);
            this.panel2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(262, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 150;
            this.label6.Text = "Find :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFindBook
            // 
            this.txtFindBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFindBook.Location = new System.Drawing.Point(309, 10);
            this.txtFindBook.Name = "txtFindBook";
            this.txtFindBook.Size = new System.Drawing.Size(152, 23);
            this.txtFindBook.TabIndex = 149;
            this.txtFindBook.TextChanged += new System.EventHandler(this.txtFindBook_TextChanged);
            // 
            // txtUrlBook
            // 
            this.txtUrlBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrlBook.Location = new System.Drawing.Point(61, 68);
            this.txtUrlBook.Name = "txtUrlBook";
            this.txtUrlBook.ReadOnly = true;
            this.txtUrlBook.Size = new System.Drawing.Size(400, 23);
            this.txtUrlBook.TabIndex = 148;
            // 
            // btnNavBook
            // 
            this.btnNavBook.BackColor = System.Drawing.Color.Gold;
            this.btnNavBook.ButtonText = "NAVIGATE";
            this.btnNavBook.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnNavBook.ForceUppercase = true;
            this.btnNavBook.ForeColor = System.Drawing.Color.Black;
            this.btnNavBook.Location = new System.Drawing.Point(191, 97);
            this.btnNavBook.Name = "btnNavBook";
            this.btnNavBook.Size = new System.Drawing.Size(86, 26);
            this.btnNavBook.TabIndex = 7;
            this.btnNavBook.Click += new System.EventHandler(this.btnNavBook_Click);
            // 
            // txtNameBook
            // 
            this.txtNameBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameBook.Location = new System.Drawing.Point(61, 39);
            this.txtNameBook.Name = "txtNameBook";
            this.txtNameBook.ReadOnly = true;
            this.txtNameBook.Size = new System.Drawing.Size(400, 23);
            this.txtNameBook.TabIndex = 147;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Gold;
            this.metroButton2.ButtonText = "CLEAR";
            this.metroButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.metroButton2.ForceUppercase = true;
            this.metroButton2.ForeColor = System.Drawing.Color.Black;
            this.metroButton2.Location = new System.Drawing.Point(375, 97);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(86, 26);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Load += new System.EventHandler(this.metroButton2_Load);
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Gold;
            this.metroButton1.ButtonText = "REMOVE";
            this.metroButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.metroButton1.ForceUppercase = true;
            this.metroButton1.ForeColor = System.Drawing.Color.Black;
            this.metroButton1.Location = new System.Drawing.Point(283, 97);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(86, 26);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Load += new System.EventHandler(this.metroButton1_Load);
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 146;
            this.label2.Text = "URL :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 145;
            this.label1.Text = "Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QShape1
            // 
            this.QShape1.ClonedBaseShapeType = Qios.DevSuite.Components.QBaseShapeType.SquareTab;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Cheetah.Properties.Resources.Closes;
            this.pictureBox1.Location = new System.Drawing.Point(466, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 143;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblCheetah
            // 
            this.lblCheetah.AutoSize = true;
            this.lblCheetah.BackColor = System.Drawing.Color.White;
            this.lblCheetah.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheetah.ForeColor = System.Drawing.Color.Black;
            this.lblCheetah.Location = new System.Drawing.Point(5, 7);
            this.lblCheetah.Name = "lblCheetah";
            this.lblCheetah.Size = new System.Drawing.Size(63, 25);
            this.lblCheetah.TabIndex = 142;
            this.lblCheetah.Text = "Library";
            this.lblCheetah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCheetah.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCheetah_MouseDown);
            // 
            // CloseTimer
            // 
            this.CloseTimer.Interval = 1;
            this.CloseTimer.Tick += new System.EventHandler(this.CloseTimer_Tick);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(498, 522);
            this.Controls.Add(this.QTabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCheetah);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Library";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Library_FormClosed);
            this.Load += new System.EventHandler(this.Library_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Library_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.QTabControl1)).EndInit();
            this.QTabControl1.ResumeLayout(false);
            this.qTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historydatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisItemBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.qTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookmarksdatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favItemBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal Qios.DevSuite.Components.QTabControl QTabControl1;
        private Qios.DevSuite.Components.QTabPage qTabPage1;
        private Qios.DevSuite.Components.QTabPage qTabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label lblCheetah;
        private System.Windows.Forms.DataGridView bookmarksdatagridview;
        private System.Windows.Forms.BindingSource favItemBindingSource;
        private System.Windows.Forms.DataGridView historydatagridview;
        private System.Windows.Forms.BindingSource hisItemBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn faviconDataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private MetroToolkit.MetroButton metroButton2;
        private MetroToolkit.MetroButton metroButton1;
        private MetroToolkit.MetroButton metroButton3;
        private MetroToolkit.MetroButton metroButton4;
        private System.Windows.Forms.DataGridViewImageColumn faviconDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        internal Qios.DevSuite.Components.QShape QShape1;
        internal System.Windows.Forms.Timer CloseTimer;
        private MetroToolkit.MetroButton btnNavHis;
        private MetroToolkit.MetroButton btnNavBook;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtUrlHis;
        private System.Windows.Forms.TextBox txtNameHis;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUrlBook;
        private System.Windows.Forms.TextBox txtNameBook;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFindHis;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFindBook;
    }
}