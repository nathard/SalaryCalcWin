namespace WindowsFormsApplication1
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
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblStreetNo = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtStreetNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PayRate = new System.Windows.Forms.Label();
            this.TaxRate = new System.Windows.Forms.Label();
            this.GrossPay = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.NetPay = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstPerson = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(44, 35);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(60, 13);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name :";
            // 
            // lblStreetNo
            // 
            this.lblStreetNo.AutoSize = true;
            this.lblStreetNo.Location = new System.Drawing.Point(23, 65);
            this.lblStreetNo.Name = "lblStreetNo";
            this.lblStreetNo.Size = new System.Drawing.Size(81, 13);
            this.lblStreetNo.TabIndex = 1;
            this.lblStreetNo.Text = "Street Number :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(53, 97);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address :";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(66, 130);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(38, 13);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "State :";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(42, 162);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(62, 13);
            this.lblPostCode.TabIndex = 4;
            this.lblPostCode.Text = "Post Code :";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(20, 196);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(84, 13);
            this.lblPhoneNo.TabIndex = 5;
            this.lblPhoneNo.Text = "Phone Number :";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(53, 227);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(51, 13);
            this.lblSalary.TabIndex = 6;
            this.lblSalary.Text = "Salary $ :";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(6, 273);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(102, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(195, 273);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(123, 32);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(175, 20);
            this.txtFullName.TabIndex = 10;
            // 
            // txtStreetNo
            // 
            this.txtStreetNo.Location = new System.Drawing.Point(123, 62);
            this.txtStreetNo.Name = "txtStreetNo";
            this.txtStreetNo.Size = new System.Drawing.Size(100, 20);
            this.txtStreetNo.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(123, 94);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(233, 20);
            this.txtAddress.TabIndex = 12;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(123, 127);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 13;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(123, 159);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostCode.TabIndex = 14;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(123, 193);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(175, 20);
            this.txtPhoneNo.TabIndex = 15;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(123, 224);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(175, 20);
            this.txtSalary.TabIndex = 16;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(28, 35);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(82, 13);
            this.lblHours.TabIndex = 17;
            this.lblHours.Text = "Hours Worked :";
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Location = new System.Drawing.Point(28, 65);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(57, 13);
            this.lblPayRate.TabIndex = 18;
            this.lblPayRate.Text = "Pay Rate :";
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Location = new System.Drawing.Point(28, 98);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(57, 13);
            this.lblTaxRate.TabIndex = 19;
            this.lblTaxRate.Text = "Tax Rate :";
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Location = new System.Drawing.Point(24, 127);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(61, 13);
            this.lblGrossPay.TabIndex = 20;
            this.lblGrossPay.Text = "Gross Pay :";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(54, 162);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(31, 13);
            this.lblTax.TabIndex = 21;
            this.lblTax.Text = "Tax :";
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Location = new System.Drawing.Point(34, 196);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(51, 13);
            this.lblNetPay.TabIndex = 22;
            this.lblNetPay.Text = "Net Pay :";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(116, 32);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(48, 20);
            this.txtHours.TabIndex = 23;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(190, 29);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 24;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(401, 265);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 25;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(490, 265);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 26;
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(291, 273);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblState);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblStreetNo);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblPostCode);
            this.groupBox1.Controls.Add(this.lblPhoneNo);
            this.groupBox1.Controls.Add(this.lblSalary);
            this.groupBox1.Controls.Add(this.txtStreetNo);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtState);
            this.groupBox1.Controls.Add(this.txtPostCode);
            this.groupBox1.Controls.Add(this.txtPhoneNo);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.lblFullName);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 313);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PayRate);
            this.groupBox2.Controls.Add(this.TaxRate);
            this.groupBox2.Controls.Add(this.GrossPay);
            this.groupBox2.Controls.Add(this.Tax);
            this.groupBox2.Controls.Add(this.NetPay);
            this.groupBox2.Controls.Add(this.lblHours);
            this.groupBox2.Controls.Add(this.lblPayRate);
            this.groupBox2.Controls.Add(this.lblTaxRate);
            this.groupBox2.Controls.Add(this.lblGrossPay);
            this.groupBox2.Controls.Add(this.btnCalc);
            this.groupBox2.Controls.Add(this.lblTax);
            this.groupBox2.Controls.Add(this.txtHours);
            this.groupBox2.Controls.Add(this.lblNetPay);
            this.groupBox2.Location = new System.Drawing.Point(401, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 231);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pay";
            // 
            // PayRate
            // 
            this.PayRate.AutoSize = true;
            this.PayRate.Location = new System.Drawing.Point(126, 69);
            this.PayRate.Name = "PayRate";
            this.PayRate.Size = new System.Drawing.Size(0, 13);
            this.PayRate.TabIndex = 25;
            // 
            // TaxRate
            // 
            this.TaxRate.AutoSize = true;
            this.TaxRate.Location = new System.Drawing.Point(126, 98);
            this.TaxRate.Name = "TaxRate";
            this.TaxRate.Size = new System.Drawing.Size(0, 13);
            this.TaxRate.TabIndex = 26;
            // 
            // GrossPay
            // 
            this.GrossPay.AutoSize = true;
            this.GrossPay.Location = new System.Drawing.Point(126, 130);
            this.GrossPay.Name = "GrossPay";
            this.GrossPay.Size = new System.Drawing.Size(0, 13);
            this.GrossPay.TabIndex = 27;
            // 
            // Tax
            // 
            this.Tax.AutoSize = true;
            this.Tax.Location = new System.Drawing.Point(126, 162);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(0, 13);
            this.Tax.TabIndex = 28;
            // 
            // NetPay
            // 
            this.NetPay.AutoSize = true;
            this.NetPay.Location = new System.Drawing.Point(126, 196);
            this.NetPay.Name = "NetPay";
            this.NetPay.Size = new System.Drawing.Size(0, 13);
            this.NetPay.TabIndex = 29;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(626, 290);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstPerson
            // 
            this.lstPerson.FormattingEnabled = true;
            this.lstPerson.Location = new System.Drawing.Point(12, 325);
            this.lstPerson.Name = "lstPerson";
            this.lstPerson.Size = new System.Drawing.Size(691, 69);
            this.lstPerson.TabIndex = 31;
            this.lstPerson.SelectedIndexChanged += new System.EventHandler(this.lstPerson_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 404);
            this.Controls.Add(this.lstPerson);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "Form1";
            this.Text = "Assignment 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblStreetNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtStreetNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.Label lblTaxRate;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstPerson;
        private System.Windows.Forms.Label PayRate;
        private System.Windows.Forms.Label TaxRate;
        private System.Windows.Forms.Label GrossPay;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label NetPay;
    }
}

