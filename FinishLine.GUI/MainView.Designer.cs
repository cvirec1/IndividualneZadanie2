namespace FinishLine
{
    partial class MainView
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
            this.tpgAge = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.cbxCountry = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.chbID = new System.Windows.Forms.CheckBox();
            this.nupdAge = new System.Windows.Forms.NumericUpDown();
            this.lbID = new System.Windows.Forms.Label();
            this.nupdID = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tpgAge.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpgAge);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Location = new System.Drawing.Point(12, 33);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(414, 241);
            this.tabMain.TabIndex = 0;
            // 
            // tpgAge
            // 
            this.tpgAge.Controls.Add(this.btnCreate);
            this.tpgAge.Controls.Add(this.nupdID);
            this.tpgAge.Controls.Add(this.lbID);
            this.tpgAge.Controls.Add(this.nupdAge);
            this.tpgAge.Controls.Add(this.chbID);
            this.tpgAge.Controls.Add(this.tbxSurname);
            this.tpgAge.Controls.Add(this.tbxName);
            this.tpgAge.Controls.Add(this.panel1);
            this.tpgAge.Controls.Add(this.cbxCountry);
            this.tpgAge.Controls.Add(this.lbGender);
            this.tpgAge.Controls.Add(this.lbCountry);
            this.tpgAge.Controls.Add(this.lbAge);
            this.tpgAge.Controls.Add(this.lbSurname);
            this.tpgAge.Controls.Add(this.lbName);
            this.tpgAge.Location = new System.Drawing.Point(4, 22);
            this.tpgAge.Name = "tpgAge";
            this.tpgAge.Padding = new System.Windows.Forms.Padding(3);
            this.tpgAge.Size = new System.Drawing.Size(406, 215);
            this.tpgAge.TabIndex = 0;
            this.tpgAge.Text = "Create Runner";
            this.tpgAge.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEdit);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(406, 215);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Runner";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(20, 80);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(55, 13);
            this.lbSurname.TabIndex = 1;
            this.lbSurname.Text = "Surname :";
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
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(255, 89);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(87, 13);
            this.lbCountry.TabIndex = 3;
            this.lbCountry.Text = "Choose country :";
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
            // cbxCountry
            // 
            this.cbxCountry.FormattingEnabled = true;
            this.cbxCountry.Location = new System.Drawing.Point(258, 124);
            this.cbxCountry.Name = "cbxCountry";
            this.cbxCountry.Size = new System.Drawing.Size(121, 21);
            this.cbxCountry.TabIndex = 5;
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
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(89, 22);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 7;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(89, 77);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(100, 20);
            this.tbxSurname.TabIndex = 8;
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
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(92, 159);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 26;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Choose ID :";
            this.label1.Visible = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(92, 114);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown2.TabIndex = 24;
            this.numericUpDown2.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(261, 162);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Choose ID ?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Location = new System.Drawing.Point(261, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 44);
            this.panel2.TabIndex = 20;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Female";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Male";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(261, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Choose gender :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Choose country :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Age :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Surname :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Name :";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(307, 185);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(303, 186);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 287);
            this.Controls.Add(this.tabMain);
            this.Name = "MainView";
            this.Text = "Form1";
            this.tabMain.ResumeLayout(false);
            this.tpgAge.ResumeLayout(false);
            this.tpgAge.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpgAge;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

