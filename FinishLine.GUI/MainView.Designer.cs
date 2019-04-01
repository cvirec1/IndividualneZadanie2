namespace FinishLine
{
    partial class Form1
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabCreate = new System.Windows.Forms.TabPage();
            this.btnCreate = new System.Windows.Forms.Button();
            this.nupdID = new System.Windows.Forms.NumericUpDown();
            this.lbID = new System.Windows.Forms.Label();
            this.nupdAge = new System.Windows.Forms.NumericUpDown();
            this.chbID = new System.Windows.Forms.CheckBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.cbxCountry = new System.Windows.Forms.ComboBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.txbEditID = new System.Windows.Forms.TextBox();
            this.lbEditRunner = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.nupAgeEdit = new System.Windows.Forms.NumericUpDown();
            this.txbSurnameEdit = new System.Windows.Forms.TextBox();
            this.txbNameEdit = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbFemaleEdit = new System.Windows.Forms.RadioButton();
            this.rbMaleEdit = new System.Windows.Forms.RadioButton();
            this.cbxCountryEdit = new System.Windows.Forms.ComboBox();
            this.lbGenderEdit = new System.Windows.Forms.Label();
            this.lbCountryEdit = new System.Windows.Forms.Label();
            this.lbAgeEdit = new System.Windows.Forms.Label();
            this.lbSurnameEdit = new System.Windows.Forms.Label();
            this.lbNameEdit = new System.Windows.Forms.Label();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbDelete = new System.Windows.Forms.TextBox();
            this.lbDelete = new System.Windows.Forms.Label();
            this.btnDeleteCheck = new System.Windows.Forms.Button();
            this.dgwRunner = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripNewRace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSaveRace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLoadRace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSetRace = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbLaps = new System.Windows.Forms.Label();
            this.lbLapsLenght = new System.Windows.Forms.Label();
            this.lbWinners = new System.Windows.Forms.Label();
            this.nupdLaps = new System.Windows.Forms.NumericUpDown();
            this.nupdLapsLenght = new System.Windows.Forms.NumericUpDown();
            this.nupdWinner = new System.Windows.Forms.NumericUpDown();
            this.btnSaveSetting = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdAge)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAgeEdit)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRunner)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdLaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdLapsLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdWinner)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabCreate);
            this.tabMain.Controls.Add(this.tabEdit);
            this.tabMain.Controls.Add(this.tabDelete);
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.tabMain.Location = new System.Drawing.Point(12, 27);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(414, 262);
            this.tabMain.TabIndex = 0;
            // 
            // tabCreate
            // 
            this.tabCreate.Controls.Add(this.btnCreate);
            this.tabCreate.Controls.Add(this.nupdID);
            this.tabCreate.Controls.Add(this.lbID);
            this.tabCreate.Controls.Add(this.nupdAge);
            this.tabCreate.Controls.Add(this.chbID);
            this.tabCreate.Controls.Add(this.tbxSurname);
            this.tabCreate.Controls.Add(this.tbxName);
            this.tabCreate.Controls.Add(this.panel1);
            this.tabCreate.Controls.Add(this.cbxCountry);
            this.tabCreate.Controls.Add(this.lbGender);
            this.tabCreate.Controls.Add(this.lbCountry);
            this.tabCreate.Controls.Add(this.lbAge);
            this.tabCreate.Controls.Add(this.lbSurname);
            this.tabCreate.Controls.Add(this.lbName);
            this.tabCreate.Location = new System.Drawing.Point(4, 22);
            this.tabCreate.Name = "tabCreate";
            this.tabCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreate.Size = new System.Drawing.Size(406, 236);
            this.tabCreate.TabIndex = 0;
            this.tabCreate.Text = "Create Runner";
            this.tabCreate.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(303, 186);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // nupdID
            // 
            this.nupdID.Location = new System.Drawing.Point(89, 167);
            this.nupdID.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nupdID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdID.Name = "nupdID";
            this.nupdID.Size = new System.Drawing.Size(100, 20);
            this.nupdID.TabIndex = 13;
            this.nupdID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdID.Visible = false;
            this.nupdID.ValueChanged += new System.EventHandler(this.nupdID_ValueChanged);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(20, 170);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(63, 13);
            this.lbID.TabIndex = 12;
            this.lbID.Text = "Choose ID :";
            this.lbID.Visible = false;
            // 
            // nupdAge
            // 
            this.nupdAge.Location = new System.Drawing.Point(89, 122);
            this.nupdAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nupdAge.Name = "nupdAge";
            this.nupdAge.Size = new System.Drawing.Size(100, 20);
            this.nupdAge.TabIndex = 11;
            this.nupdAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // chbID
            // 
            this.chbID.AutoSize = true;
            this.chbID.Location = new System.Drawing.Point(258, 170);
            this.chbID.Name = "chbID";
            this.chbID.Size = new System.Drawing.Size(85, 17);
            this.chbID.TabIndex = 10;
            this.chbID.Text = "Choose ID ?";
            this.chbID.UseVisualStyleBackColor = true;
            this.chbID.CheckedChanged += new System.EventHandler(this.chbID_CheckedChanged);
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(89, 77);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(100, 20);
            this.tbxSurname.TabIndex = 8;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(89, 22);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Location = new System.Drawing.Point(258, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 44);
            this.panel1.TabIndex = 6;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(4, 24);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(4, 4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // cbxCountry
            // 
            this.cbxCountry.FormattingEnabled = true;
            this.cbxCountry.Location = new System.Drawing.Point(258, 124);
            this.cbxCountry.Name = "cbxCountry";
            this.cbxCountry.Size = new System.Drawing.Size(121, 21);
            this.cbxCountry.TabIndex = 5;
            this.cbxCountry.SelectedIndexChanged += new System.EventHandler(this.cbxCountry_SelectedIndexChanged);
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(255, 25);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(85, 13);
            this.lbGender.TabIndex = 4;
            this.lbGender.Text = "Choose gender :";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(255, 89);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(87, 13);
            this.lbCountry.TabIndex = 3;
            this.lbCountry.Text = "Choose country :";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(20, 124);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(32, 13);
            this.lbAge.TabIndex = 2;
            this.lbAge.Text = "Age :";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(20, 80);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(55, 13);
            this.lbSurname.TabIndex = 1;
            this.lbSurname.Text = "Surname :";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(20, 25);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(41, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name :";
            // 
            // tabEdit
            // 
            this.tabEdit.Controls.Add(this.txbEditID);
            this.tabEdit.Controls.Add(this.lbEditRunner);
            this.tabEdit.Controls.Add(this.btnCheck);
            this.tabEdit.Controls.Add(this.btnEdit);
            this.tabEdit.Controls.Add(this.nupAgeEdit);
            this.tabEdit.Controls.Add(this.txbSurnameEdit);
            this.tabEdit.Controls.Add(this.txbNameEdit);
            this.tabEdit.Controls.Add(this.panel2);
            this.tabEdit.Controls.Add(this.cbxCountryEdit);
            this.tabEdit.Controls.Add(this.lbGenderEdit);
            this.tabEdit.Controls.Add(this.lbCountryEdit);
            this.tabEdit.Controls.Add(this.lbAgeEdit);
            this.tabEdit.Controls.Add(this.lbSurnameEdit);
            this.tabEdit.Controls.Add(this.lbNameEdit);
            this.tabEdit.Location = new System.Drawing.Point(4, 22);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(406, 236);
            this.tabEdit.TabIndex = 1;
            this.tabEdit.Text = "Edit Runner";
            this.tabEdit.UseVisualStyleBackColor = true;
            // 
            // txbEditID
            // 
            this.txbEditID.Location = new System.Drawing.Point(146, 9);
            this.txbEditID.Name = "txbEditID";
            this.txbEditID.Size = new System.Drawing.Size(100, 20);
            this.txbEditID.TabIndex = 29;
            // 
            // lbEditRunner
            // 
            this.lbEditRunner.AutoSize = true;
            this.lbEditRunner.Location = new System.Drawing.Point(24, 11);
            this.lbEditRunner.Name = "lbEditRunner";
            this.lbEditRunner.Size = new System.Drawing.Size(98, 13);
            this.lbEditRunner.TabIndex = 28;
            this.lbEditRunner.Text = "Choose ID for edit :";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(308, 6);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 27;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(308, 209);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // nupAgeEdit
            // 
            this.nupAgeEdit.Location = new System.Drawing.Point(93, 138);
            this.nupAgeEdit.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nupAgeEdit.Name = "nupAgeEdit";
            this.nupAgeEdit.Size = new System.Drawing.Size(100, 20);
            this.nupAgeEdit.TabIndex = 24;
            this.nupAgeEdit.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // txbSurnameEdit
            // 
            this.txbSurnameEdit.Location = new System.Drawing.Point(93, 93);
            this.txbSurnameEdit.Name = "txbSurnameEdit";
            this.txbSurnameEdit.Size = new System.Drawing.Size(100, 20);
            this.txbSurnameEdit.TabIndex = 22;
            // 
            // txbNameEdit
            // 
            this.txbNameEdit.Location = new System.Drawing.Point(93, 38);
            this.txbNameEdit.Name = "txbNameEdit";
            this.txbNameEdit.Size = new System.Drawing.Size(100, 20);
            this.txbNameEdit.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbFemaleEdit);
            this.panel2.Controls.Add(this.rbMaleEdit);
            this.panel2.Location = new System.Drawing.Point(262, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 44);
            this.panel2.TabIndex = 20;
            // 
            // rbFemaleEdit
            // 
            this.rbFemaleEdit.AutoSize = true;
            this.rbFemaleEdit.Location = new System.Drawing.Point(4, 24);
            this.rbFemaleEdit.Name = "rbFemaleEdit";
            this.rbFemaleEdit.Size = new System.Drawing.Size(59, 17);
            this.rbFemaleEdit.TabIndex = 1;
            this.rbFemaleEdit.TabStop = true;
            this.rbFemaleEdit.Text = "Female";
            this.rbFemaleEdit.UseVisualStyleBackColor = true;
            this.rbFemaleEdit.CheckedChanged += new System.EventHandler(this.rbFemaleEdit_CheckedChanged);
            // 
            // rbMaleEdit
            // 
            this.rbMaleEdit.AutoSize = true;
            this.rbMaleEdit.Location = new System.Drawing.Point(4, 4);
            this.rbMaleEdit.Name = "rbMaleEdit";
            this.rbMaleEdit.Size = new System.Drawing.Size(48, 17);
            this.rbMaleEdit.TabIndex = 0;
            this.rbMaleEdit.TabStop = true;
            this.rbMaleEdit.Text = "Male";
            this.rbMaleEdit.UseVisualStyleBackColor = true;
            this.rbMaleEdit.CheckedChanged += new System.EventHandler(this.rbMaleEdit_CheckedChanged);
            // 
            // cbxCountryEdit
            // 
            this.cbxCountryEdit.FormattingEnabled = true;
            this.cbxCountryEdit.Location = new System.Drawing.Point(262, 140);
            this.cbxCountryEdit.Name = "cbxCountryEdit";
            this.cbxCountryEdit.Size = new System.Drawing.Size(121, 21);
            this.cbxCountryEdit.TabIndex = 19;
            // 
            // lbGenderEdit
            // 
            this.lbGenderEdit.AutoSize = true;
            this.lbGenderEdit.Location = new System.Drawing.Point(259, 41);
            this.lbGenderEdit.Name = "lbGenderEdit";
            this.lbGenderEdit.Size = new System.Drawing.Size(85, 13);
            this.lbGenderEdit.TabIndex = 18;
            this.lbGenderEdit.Text = "Choose gender :";
            // 
            // lbCountryEdit
            // 
            this.lbCountryEdit.AutoSize = true;
            this.lbCountryEdit.Location = new System.Drawing.Point(259, 105);
            this.lbCountryEdit.Name = "lbCountryEdit";
            this.lbCountryEdit.Size = new System.Drawing.Size(87, 13);
            this.lbCountryEdit.TabIndex = 17;
            this.lbCountryEdit.Text = "Choose country :";
            // 
            // lbAgeEdit
            // 
            this.lbAgeEdit.AutoSize = true;
            this.lbAgeEdit.Location = new System.Drawing.Point(24, 140);
            this.lbAgeEdit.Name = "lbAgeEdit";
            this.lbAgeEdit.Size = new System.Drawing.Size(32, 13);
            this.lbAgeEdit.TabIndex = 16;
            this.lbAgeEdit.Text = "Age :";
            // 
            // lbSurnameEdit
            // 
            this.lbSurnameEdit.AutoSize = true;
            this.lbSurnameEdit.Location = new System.Drawing.Point(24, 96);
            this.lbSurnameEdit.Name = "lbSurnameEdit";
            this.lbSurnameEdit.Size = new System.Drawing.Size(55, 13);
            this.lbSurnameEdit.TabIndex = 15;
            this.lbSurnameEdit.Text = "Surname :";
            // 
            // lbNameEdit
            // 
            this.lbNameEdit.AutoSize = true;
            this.lbNameEdit.Location = new System.Drawing.Point(24, 41);
            this.lbNameEdit.Name = "lbNameEdit";
            this.lbNameEdit.Size = new System.Drawing.Size(41, 13);
            this.lbNameEdit.TabIndex = 14;
            this.lbNameEdit.Text = "Name :";
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.btnDelete);
            this.tabDelete.Controls.Add(this.txbDelete);
            this.tabDelete.Controls.Add(this.lbDelete);
            this.tabDelete.Controls.Add(this.btnDeleteCheck);
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelete.Size = new System.Drawing.Size(406, 236);
            this.tabDelete.TabIndex = 2;
            this.tabDelete.Text = "Delete Runner";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(146, 184);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txbDelete
            // 
            this.txbDelete.Location = new System.Drawing.Point(187, 108);
            this.txbDelete.Name = "txbDelete";
            this.txbDelete.Size = new System.Drawing.Size(100, 20);
            this.txbDelete.TabIndex = 32;
            // 
            // lbDelete
            // 
            this.lbDelete.AutoSize = true;
            this.lbDelete.Location = new System.Drawing.Point(24, 112);
            this.lbDelete.Name = "lbDelete";
            this.lbDelete.Size = new System.Drawing.Size(148, 13);
            this.lbDelete.TabIndex = 31;
            this.lbDelete.Text = "Choose Runner ID for delete :";
            // 
            // btnDeleteCheck
            // 
            this.btnDeleteCheck.Location = new System.Drawing.Point(307, 105);
            this.btnDeleteCheck.Name = "btnDeleteCheck";
            this.btnDeleteCheck.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCheck.TabIndex = 30;
            this.btnDeleteCheck.Text = "Check";
            this.btnDeleteCheck.UseVisualStyleBackColor = true;
            this.btnDeleteCheck.Click += new System.EventHandler(this.btnDeleteCheck_Click);
            // 
            // dgwRunner
            // 
            this.dgwRunner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRunner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colSurname,
            this.colAge,
            this.colGender,
            this.colCountry,
            this.colLap,
            this.colWin});
            this.dgwRunner.Location = new System.Drawing.Point(428, 49);
            this.dgwRunner.Name = "dgwRunner";
            this.dgwRunner.Size = new System.Drawing.Size(639, 236);
            this.dgwRunner.TabIndex = 1;
            this.dgwRunner.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.Frozen = true;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.Frozen = true;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colSurname
            // 
            this.colSurname.DataPropertyName = "Surname";
            this.colSurname.Frozen = true;
            this.colSurname.HeaderText = "Surname";
            this.colSurname.Name = "colSurname";
            // 
            // colAge
            // 
            this.colAge.DataPropertyName = "Age";
            this.colAge.Frozen = true;
            this.colAge.HeaderText = "Age";
            this.colAge.Name = "colAge";
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.Frozen = true;
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            // 
            // colCountry
            // 
            this.colCountry.DataPropertyName = "Country";
            this.colCountry.Frozen = true;
            this.colCountry.HeaderText = "Country";
            this.colCountry.Name = "colCountry";
            // 
            // colLap
            // 
            this.colLap.DataPropertyName = "Lap";
            this.colLap.Frozen = true;
            this.colLap.HeaderText = "Lap";
            this.colLap.Name = "colLap";
            this.colLap.Visible = false;
            // 
            // colWin
            // 
            this.colWin.DataPropertyName = "Win";
            this.colWin.HeaderText = "Win";
            this.colWin.Name = "colWin";
            this.colWin.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNewRace,
            this.toolStripSetRace,
            this.toolStripLoadRace,
            this.toolStripSaveRace});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1093, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripNewRace
            // 
            this.toolStripNewRace.Name = "toolStripNewRace";
            this.toolStripNewRace.Size = new System.Drawing.Size(71, 20);
            this.toolStripNewRace.Text = "Start Race";
            this.toolStripNewRace.Click += new System.EventHandler(this.toolStripNewRace_Click);
            // 
            // toolStripSaveRace
            // 
            this.toolStripSaveRace.Name = "toolStripSaveRace";
            this.toolStripSaveRace.Size = new System.Drawing.Size(71, 20);
            this.toolStripSaveRace.Text = "Save Race";
            this.toolStripSaveRace.Click += new System.EventHandler(this.toolStripSaveRace_Click);
            // 
            // toolStripLoadRace
            // 
            this.toolStripLoadRace.Name = "toolStripLoadRace";
            this.toolStripLoadRace.Size = new System.Drawing.Size(73, 20);
            this.toolStripLoadRace.Text = "Load Race";
            this.toolStripLoadRace.Click += new System.EventHandler(this.toolStripLoadRace_Click);
            // 
            // toolStripSetRace
            // 
            this.toolStripSetRace.Name = "toolStripSetRace";
            this.toolStripSetRace.Size = new System.Drawing.Size(63, 20);
            this.toolStripSetRace.Text = "Set Race";
            this.toolStripSetRace.Click += new System.EventHandler(this.toolStripSetRace_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSaveSetting);
            this.tabPage1.Controls.Add(this.nupdWinner);
            this.tabPage1.Controls.Add(this.nupdLapsLenght);
            this.tabPage1.Controls.Add(this.nupdLaps);
            this.tabPage1.Controls.Add(this.lbWinners);
            this.tabPage1.Controls.Add(this.lbLapsLenght);
            this.tabPage1.Controls.Add(this.lbLaps);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(406, 236);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Set Race";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbLaps
            // 
            this.lbLaps.AutoSize = true;
            this.lbLaps.Location = new System.Drawing.Point(69, 55);
            this.lbLaps.Name = "lbLaps";
            this.lbLaps.Size = new System.Drawing.Size(36, 13);
            this.lbLaps.TabIndex = 0;
            this.lbLaps.Text = "Laps :";
            // 
            // lbLapsLenght
            // 
            this.lbLapsLenght.AutoSize = true;
            this.lbLapsLenght.Location = new System.Drawing.Point(69, 94);
            this.lbLapsLenght.Name = "lbLapsLenght";
            this.lbLapsLenght.Size = new System.Drawing.Size(68, 13);
            this.lbLapsLenght.TabIndex = 1;
            this.lbLapsLenght.Text = "Laps lenght :";
            // 
            // lbWinners
            // 
            this.lbWinners.AutoSize = true;
            this.lbWinners.Location = new System.Drawing.Point(69, 134);
            this.lbWinners.Name = "lbWinners";
            this.lbWinners.Size = new System.Drawing.Size(41, 13);
            this.lbWinners.TabIndex = 2;
            this.lbWinners.Text = "Winner";
            // 
            // nupdLaps
            // 
            this.nupdLaps.Location = new System.Drawing.Point(157, 47);
            this.nupdLaps.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nupdLaps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdLaps.Name = "nupdLaps";
            this.nupdLaps.Size = new System.Drawing.Size(120, 20);
            this.nupdLaps.TabIndex = 3;
            this.nupdLaps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupdLapsLenght
            // 
            this.nupdLapsLenght.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nupdLapsLenght.Location = new System.Drawing.Point(157, 94);
            this.nupdLapsLenght.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupdLapsLenght.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nupdLapsLenght.Name = "nupdLapsLenght";
            this.nupdLapsLenght.Size = new System.Drawing.Size(120, 20);
            this.nupdLapsLenght.TabIndex = 4;
            this.nupdLapsLenght.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nupdWinner
            // 
            this.nupdWinner.Location = new System.Drawing.Point(157, 134);
            this.nupdWinner.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupdWinner.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdWinner.Name = "nupdWinner";
            this.nupdWinner.Size = new System.Drawing.Size(120, 20);
            this.nupdWinner.TabIndex = 5;
            this.nupdWinner.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSaveSetting
            // 
            this.btnSaveSetting.Location = new System.Drawing.Point(157, 191);
            this.btnSaveSetting.Name = "btnSaveSetting";
            this.btnSaveSetting.Size = new System.Drawing.Size(120, 23);
            this.btnSaveSetting.TabIndex = 6;
            this.btnSaveSetting.Text = "Save Setting";
            this.btnSaveSetting.UseVisualStyleBackColor = true;
            this.btnSaveSetting.Click += new System.EventHandler(this.btnSaveSetting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 301);
            this.Controls.Add(this.dgwRunner);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabMain.ResumeLayout(false);
            this.tabCreate.ResumeLayout(false);
            this.tabCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdAge)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAgeEdit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRunner)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdLaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdLapsLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdWinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabCreate;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.ComboBox cbxCountry;
        private System.Windows.Forms.CheckBox chbID;
        private System.Windows.Forms.NumericUpDown nupdAge;
        private System.Windows.Forms.NumericUpDown nupdID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.NumericUpDown nupAgeEdit;
        private System.Windows.Forms.TextBox txbSurnameEdit;
        private System.Windows.Forms.TextBox txbNameEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbFemaleEdit;
        private System.Windows.Forms.RadioButton rbMaleEdit;
        private System.Windows.Forms.ComboBox cbxCountryEdit;
        private System.Windows.Forms.Label lbGenderEdit;
        private System.Windows.Forms.Label lbCountryEdit;
        private System.Windows.Forms.Label lbAgeEdit;
        private System.Windows.Forms.Label lbSurnameEdit;
        private System.Windows.Forms.Label lbNameEdit;
        private System.Windows.Forms.DataGridView dgwRunner;
        private System.Windows.Forms.TextBox txbEditID;
        private System.Windows.Forms.Label lbEditRunner;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripNewRace;
        private System.Windows.Forms.ToolStripMenuItem toolStripSaveRace;
        private System.Windows.Forms.ToolStripMenuItem toolStripLoadRace;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txbDelete;
        private System.Windows.Forms.Label lbDelete;
        private System.Windows.Forms.Button btnDeleteCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWin;
        private System.Windows.Forms.ToolStripMenuItem toolStripSetRace;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSaveSetting;
        private System.Windows.Forms.NumericUpDown nupdWinner;
        private System.Windows.Forms.NumericUpDown nupdLapsLenght;
        private System.Windows.Forms.NumericUpDown nupdLaps;
        private System.Windows.Forms.Label lbWinners;
        private System.Windows.Forms.Label lbLapsLenght;
        private System.Windows.Forms.Label lbLaps;
    }
}

