
namespace SchoolBank
{
    partial class FmAccounts
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
            this.gbCreate = new System.Windows.Forms.GroupBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.txBalance = new System.Windows.Forms.TextBox();
            this.txSurname = new System.Windows.Forms.TextBox();
            this.txForename = new System.Windows.Forms.TextBox();
            this.txStudentID = new System.Windows.Forms.TextBox();
            this.btReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.gbCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCreate
            // 
            this.gbCreate.Controls.Add(this.cbClass);
            this.gbCreate.Controls.Add(this.label6);
            this.gbCreate.Controls.Add(this.label5);
            this.gbCreate.Controls.Add(this.label4);
            this.gbCreate.Controls.Add(this.label3);
            this.gbCreate.Controls.Add(this.btSave);
            this.gbCreate.Controls.Add(this.txBalance);
            this.gbCreate.Controls.Add(this.txSurname);
            this.gbCreate.Controls.Add(this.txForename);
            this.gbCreate.Location = new System.Drawing.Point(12, 154);
            this.gbCreate.Name = "gbCreate";
            this.gbCreate.Size = new System.Drawing.Size(490, 202);
            this.gbCreate.TabIndex = 0;
            this.gbCreate.TabStop = false;
            this.gbCreate.Text = "Account Details";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(112, 112);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(121, 24);
            this.cbClass.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Surname\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Forename";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(382, 151);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 34);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // txBalance
            // 
            this.txBalance.Location = new System.Drawing.Point(112, 157);
            this.txBalance.Name = "txBalance";
            this.txBalance.Size = new System.Drawing.Size(100, 22);
            this.txBalance.TabIndex = 3;
            // 
            // txSurname
            // 
            this.txSurname.Location = new System.Drawing.Point(357, 73);
            this.txSurname.Name = "txSurname";
            this.txSurname.Size = new System.Drawing.Size(100, 22);
            this.txSurname.TabIndex = 2;
            // 
            // txForename
            // 
            this.txForename.Location = new System.Drawing.Point(112, 73);
            this.txForename.Name = "txForename";
            this.txForename.Size = new System.Drawing.Size(100, 22);
            this.txForename.TabIndex = 1;
            // 
            // txStudentID
            // 
            this.txStudentID.Location = new System.Drawing.Point(154, 114);
            this.txStudentID.Name = "txStudentID";
            this.txStudentID.Size = new System.Drawing.Size(100, 22);
            this.txStudentID.TabIndex = 0;
            // 
            // btReturn
            // 
            this.btReturn.Location = new System.Drawing.Point(529, 306);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(118, 50);
            this.btReturn.TabIndex = 5;
            this.btReturn.Text = "Return to Menu";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "Accounts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Student ID";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(551, 117);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(46, 17);
            this.lbDate.TabIndex = 8;
            this.lbDate.Text = "label7";
            // 
            // FmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 372);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.gbCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.txStudentID);
            this.Name = "FmAccounts";
            this.Text = "FmAccounts";
            this.Load += new System.EventHandler(this.FmAccounts_Load);
            this.gbCreate.ResumeLayout(false);
            this.gbCreate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCreate;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox txBalance;
        private System.Windows.Forms.TextBox txSurname;
        private System.Windows.Forms.TextBox txForename;
        private System.Windows.Forms.TextBox txStudentID;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDate;
    }
}