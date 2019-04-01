namespace FinishLine
{
    partial class RaceView
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
            this.dgwRaceLap = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbWrite = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.btnWriteTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRaceLap)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwRaceLap
            // 
            this.dgwRaceLap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRaceLap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colSurname,
            this.colAge,
            this.colGender,
            this.colCountry});
            this.dgwRaceLap.Location = new System.Drawing.Point(12, 68);
            this.dgwRaceLap.Name = "dgwRaceLap";
            this.dgwRaceLap.Size = new System.Drawing.Size(642, 236);
            this.dgwRaceLap.TabIndex = 2;
            // 
            // colID
            // 
            this.colID.Frozen = true;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            // 
            // colName
            // 
            this.colName.Frozen = true;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colSurname
            // 
            this.colSurname.Frozen = true;
            this.colSurname.HeaderText = "Surname";
            this.colSurname.Name = "colSurname";
            // 
            // colAge
            // 
            this.colAge.Frozen = true;
            this.colAge.HeaderText = "Age";
            this.colAge.Name = "colAge";
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            // 
            // colCountry
            // 
            this.colCountry.HeaderText = "Country";
            this.colCountry.Name = "colCountry";
            // 
            // lbWrite
            // 
            this.lbWrite.AutoSize = true;
            this.lbWrite.Location = new System.Drawing.Point(12, 32);
            this.lbWrite.Name = "lbWrite";
            this.lbWrite.Size = new System.Drawing.Size(90, 13);
            this.lbWrite.TabIndex = 3;
            this.lbWrite.Text = "Write ID Runner :";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(126, 29);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(100, 20);
            this.txbID.TabIndex = 4;
            // 
            // btnWriteTime
            // 
            this.btnWriteTime.Location = new System.Drawing.Point(252, 27);
            this.btnWriteTime.Name = "btnWriteTime";
            this.btnWriteTime.Size = new System.Drawing.Size(75, 23);
            this.btnWriteTime.TabIndex = 5;
            this.btnWriteTime.Text = "Write Time";
            this.btnWriteTime.UseVisualStyleBackColor = true;
            // 
            // RaceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 341);
            this.Controls.Add(this.btnWriteTime);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lbWrite);
            this.Controls.Add(this.dgwRaceLap);
            this.Name = "RaceView";
            this.Text = "RaceView";
            ((System.ComponentModel.ISupportInitialize)(this.dgwRaceLap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwRaceLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry;
        private System.Windows.Forms.Label lbWrite;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Button btnWriteTime;
    }
}