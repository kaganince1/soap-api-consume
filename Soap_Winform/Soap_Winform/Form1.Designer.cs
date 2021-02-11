namespace Soap_Winform
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
            this.btnGet = new System.Windows.Forms.Button();
            this.dgvSonuc = new System.Windows.Forms.DataGridView();
            this.txtboxConnStr = new System.Windows.Forms.TextBox();
            this.lblConn = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtboxSurname = new System.Windows.Forms.TextBox();
            this.txtboxAge = new System.Windows.Forms.TextBox();
            this.txtboxLocation = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtboxLocation2 = new System.Windows.Forms.TextBox();
            this.txtboxAge2 = new System.Windows.Forms.TextBox();
            this.txtboxSurname2 = new System.Windows.Forms.TextBox();
            this.txtboxName2 = new System.Windows.Forms.TextBox();
            this.lblLocation2 = new System.Windows.Forms.Label();
            this.lblAge2 = new System.Windows.Forms.Label();
            this.lblSurname2 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.txtboxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtboxId2 = new System.Windows.Forms.TextBox();
            this.lblId2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGet2 = new System.Windows.Forms.Button();
            this.txtboxId3 = new System.Windows.Forms.TextBox();
            this.lblId3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(583, 194);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(87, 23);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "Get All";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // dgvSonuc
            // 
            this.dgvSonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSonuc.Location = new System.Drawing.Point(34, 194);
            this.dgvSonuc.Name = "dgvSonuc";
            this.dgvSonuc.Size = new System.Drawing.Size(543, 244);
            this.dgvSonuc.TabIndex = 1;
            // 
            // txtboxConnStr
            // 
            this.txtboxConnStr.Location = new System.Drawing.Point(89, 13);
            this.txtboxConnStr.Name = "txtboxConnStr";
            this.txtboxConnStr.Size = new System.Drawing.Size(699, 20);
            this.txtboxConnStr.TabIndex = 2;
            this.txtboxConnStr.Text = "Data Source = .; Initial Catalog = AdventureWorks2017; Integrated Security = True" +
    "";
            // 
            // lblConn
            // 
            this.lblConn.AutoSize = true;
            this.lblConn.Location = new System.Drawing.Point(9, 16);
            this.lblConn.Name = "lblConn";
            this.lblConn.Size = new System.Drawing.Size(80, 13);
            this.lblConn.TabIndex = 3;
            this.lblConn.Text = "Connection Str:";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblExp.Location = new System.Drawing.Point(86, 36);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(527, 13);
            this.lblExp.TabIndex = 4;
            this.lblExp.Text = "Example of connection str: Data Source = .; Initial Catalog = AdventureWorks2017;" +
    " Integrated Security = True ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(31, 114);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(54, 140);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Age:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(32, 166);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(51, 13);
            this.lblLocation.TabIndex = 8;
            this.lblLocation.Text = "Location:";
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(89, 85);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(100, 20);
            this.txtboxName.TabIndex = 9;
            // 
            // txtboxSurname
            // 
            this.txtboxSurname.Location = new System.Drawing.Point(89, 111);
            this.txtboxSurname.Name = "txtboxSurname";
            this.txtboxSurname.Size = new System.Drawing.Size(100, 20);
            this.txtboxSurname.TabIndex = 10;
            // 
            // txtboxAge
            // 
            this.txtboxAge.Location = new System.Drawing.Point(89, 137);
            this.txtboxAge.Name = "txtboxAge";
            this.txtboxAge.Size = new System.Drawing.Size(100, 20);
            this.txtboxAge.TabIndex = 11;
            // 
            // txtboxLocation
            // 
            this.txtboxLocation.Location = new System.Drawing.Point(89, 163);
            this.txtboxLocation.Name = "txtboxLocation";
            this.txtboxLocation.Size = new System.Drawing.Size(100, 20);
            this.txtboxLocation.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(195, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(451, 165);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtboxLocation2
            // 
            this.txtboxLocation2.Location = new System.Drawing.Point(345, 167);
            this.txtboxLocation2.Name = "txtboxLocation2";
            this.txtboxLocation2.Size = new System.Drawing.Size(100, 20);
            this.txtboxLocation2.TabIndex = 21;
            // 
            // txtboxAge2
            // 
            this.txtboxAge2.Location = new System.Drawing.Point(345, 141);
            this.txtboxAge2.Name = "txtboxAge2";
            this.txtboxAge2.Size = new System.Drawing.Size(100, 20);
            this.txtboxAge2.TabIndex = 20;
            // 
            // txtboxSurname2
            // 
            this.txtboxSurname2.Location = new System.Drawing.Point(345, 115);
            this.txtboxSurname2.Name = "txtboxSurname2";
            this.txtboxSurname2.Size = new System.Drawing.Size(100, 20);
            this.txtboxSurname2.TabIndex = 19;
            // 
            // txtboxName2
            // 
            this.txtboxName2.Location = new System.Drawing.Point(345, 89);
            this.txtboxName2.Name = "txtboxName2";
            this.txtboxName2.Size = new System.Drawing.Size(100, 20);
            this.txtboxName2.TabIndex = 18;
            // 
            // lblLocation2
            // 
            this.lblLocation2.AutoSize = true;
            this.lblLocation2.Location = new System.Drawing.Point(288, 170);
            this.lblLocation2.Name = "lblLocation2";
            this.lblLocation2.Size = new System.Drawing.Size(51, 13);
            this.lblLocation2.TabIndex = 17;
            this.lblLocation2.Text = "Location:";
            // 
            // lblAge2
            // 
            this.lblAge2.AutoSize = true;
            this.lblAge2.Location = new System.Drawing.Point(310, 144);
            this.lblAge2.Name = "lblAge2";
            this.lblAge2.Size = new System.Drawing.Size(29, 13);
            this.lblAge2.TabIndex = 16;
            this.lblAge2.Text = "Age:";
            // 
            // lblSurname2
            // 
            this.lblSurname2.AutoSize = true;
            this.lblSurname2.Location = new System.Drawing.Point(287, 118);
            this.lblSurname2.Name = "lblSurname2";
            this.lblSurname2.Size = new System.Drawing.Size(52, 13);
            this.lblSurname2.TabIndex = 15;
            this.lblSurname2.Text = "Surname:";
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(301, 92);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(38, 13);
            this.lblName2.TabIndex = 14;
            this.lblName2.Text = "Name:";
            // 
            // txtboxId
            // 
            this.txtboxId.Location = new System.Drawing.Point(345, 63);
            this.txtboxId.Name = "txtboxId";
            this.txtboxId.Size = new System.Drawing.Size(100, 20);
            this.txtboxId.TabIndex = 24;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(320, 66);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 23;
            this.lblId.Text = "Id:";
            // 
            // txtboxId2
            // 
            this.txtboxId2.Location = new System.Drawing.Point(570, 63);
            this.txtboxId2.Name = "txtboxId2";
            this.txtboxId2.Size = new System.Drawing.Size(100, 20);
            this.txtboxId2.TabIndex = 26;
            // 
            // lblId2
            // 
            this.lblId2.AutoSize = true;
            this.lblId2.Location = new System.Drawing.Point(545, 66);
            this.lblId2.Name = "lblId2";
            this.lblId2.Size = new System.Drawing.Size(19, 13);
            this.lblId2.TabIndex = 25;
            this.lblId2.Text = "Id:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(676, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGet2
            // 
            this.btnGet2.Location = new System.Drawing.Point(676, 89);
            this.btnGet2.Name = "btnGet2";
            this.btnGet2.Size = new System.Drawing.Size(75, 23);
            this.btnGet2.TabIndex = 30;
            this.btnGet2.Text = "Get";
            this.btnGet2.UseVisualStyleBackColor = true;
            this.btnGet2.Click += new System.EventHandler(this.btnGet2_Click);
            // 
            // txtboxId3
            // 
            this.txtboxId3.Location = new System.Drawing.Point(570, 92);
            this.txtboxId3.Name = "txtboxId3";
            this.txtboxId3.Size = new System.Drawing.Size(100, 20);
            this.txtboxId3.TabIndex = 29;
            // 
            // lblId3
            // 
            this.lblId3.AutoSize = true;
            this.lblId3.Location = new System.Drawing.Point(545, 95);
            this.lblId3.Name = "lblId3";
            this.lblId3.Size = new System.Drawing.Size(19, 13);
            this.lblId3.TabIndex = 28;
            this.lblId3.Text = "Id:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGet2);
            this.Controls.Add(this.txtboxId3);
            this.Controls.Add(this.lblId3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtboxId2);
            this.Controls.Add(this.lblId2);
            this.Controls.Add(this.txtboxId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtboxLocation2);
            this.Controls.Add(this.txtboxAge2);
            this.Controls.Add(this.txtboxSurname2);
            this.Controls.Add(this.txtboxName2);
            this.Controls.Add(this.lblLocation2);
            this.Controls.Add(this.lblAge2);
            this.Controls.Add(this.lblSurname2);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtboxLocation);
            this.Controls.Add(this.txtboxAge);
            this.Controls.Add(this.txtboxSurname);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblConn);
            this.Controls.Add(this.txtboxConnStr);
            this.Controls.Add(this.dgvSonuc);
            this.Controls.Add(this.btnGet);
            this.Name = "Form1";
            this.Text = "SoapConsume";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.DataGridView dgvSonuc;
        private System.Windows.Forms.TextBox txtboxConnStr;
        private System.Windows.Forms.Label lblConn;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox txtboxSurname;
        private System.Windows.Forms.TextBox txtboxAge;
        private System.Windows.Forms.TextBox txtboxLocation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtboxLocation2;
        private System.Windows.Forms.TextBox txtboxAge2;
        private System.Windows.Forms.TextBox txtboxSurname2;
        private System.Windows.Forms.TextBox txtboxName2;
        private System.Windows.Forms.Label lblLocation2;
        private System.Windows.Forms.Label lblAge2;
        private System.Windows.Forms.Label lblSurname2;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.TextBox txtboxId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtboxId2;
        private System.Windows.Forms.Label lblId2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGet2;
        private System.Windows.Forms.TextBox txtboxId3;
        private System.Windows.Forms.Label lblId3;
    }
}

