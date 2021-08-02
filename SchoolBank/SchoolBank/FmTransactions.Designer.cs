
namespace SchoolBank
{
    partial class FmTransactions
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
            this.txID = new System.Windows.Forms.TextBox();
            this.txAmount = new System.Windows.Forms.TextBox();
            this.rbDeposit = new System.Windows.Forms.RadioButton();
            this.rbWithdrawal = new System.Windows.Forms.RadioButton();
            this.btFind = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.gbID = new System.Windows.Forms.GroupBox();
            this.gbTrans = new System.Windows.Forms.GroupBox();
            this.gbTrans.SuspendLayout();
            this.SuspendLayout();
            // 
            // txID
            // 
            this.txID.Location = new System.Drawing.Point(46, 134);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(100, 22);
            this.txID.TabIndex = 0;
            // 
            // txAmount
            // 
            this.txAmount.Location = new System.Drawing.Point(435, 147);
            this.txAmount.Name = "txAmount";
            this.txAmount.Size = new System.Drawing.Size(100, 22);
            this.txAmount.TabIndex = 1;
            // 
            // rbDeposit
            // 
            this.rbDeposit.AutoSize = true;
            this.rbDeposit.Location = new System.Drawing.Point(35, 138);
            this.rbDeposit.Name = "rbDeposit";
            this.rbDeposit.Size = new System.Drawing.Size(77, 21);
            this.rbDeposit.TabIndex = 2;
            this.rbDeposit.TabStop = true;
            this.rbDeposit.Text = "Deposit";
            this.rbDeposit.UseVisualStyleBackColor = true;
            // 
            // rbWithdrawal
            // 
            this.rbWithdrawal.AutoSize = true;
            this.rbWithdrawal.Location = new System.Drawing.Point(176, 138);
            this.rbWithdrawal.Name = "rbWithdrawal";
            this.rbWithdrawal.Size = new System.Drawing.Size(98, 21);
            this.rbWithdrawal.TabIndex = 3;
            this.rbWithdrawal.TabStop = true;
            this.rbWithdrawal.Text = "Withdrawal";
            this.rbWithdrawal.UseVisualStyleBackColor = true;
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(228, 133);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(75, 23);
            this.btFind.TabIndex = 4;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(555, 149);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btReturn
            // 
            this.btReturn.Location = new System.Drawing.Point(713, 384);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(75, 54);
            this.btReturn.TabIndex = 6;
            this.btReturn.Text = "Return to Menu";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "Transactions";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(32, 18);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(56, 17);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "lbName";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Location = new System.Drawing.Point(432, 20);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(70, 17);
            this.lbBalance.TabIndex = 9;
            this.lbBalance.Text = "lbBalance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Select transaction type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enter amount:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(666, 80);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(61, 21);
            this.lbDate.TabIndex = 12;
            this.lbDate.Text = "lbDate";
            // 
            // gbID
            // 
            this.gbID.Location = new System.Drawing.Point(22, 80);
            this.gbID.Name = "gbID";
            this.gbID.Size = new System.Drawing.Size(310, 94);
            this.gbID.TabIndex = 13;
            this.gbID.TabStop = false;
            this.gbID.Text = "Enter student ID:";
            // 
            // gbTrans
            // 
            this.gbTrans.Controls.Add(this.rbDeposit);
            this.gbTrans.Controls.Add(this.label4);
            this.gbTrans.Controls.Add(this.label5);
            this.gbTrans.Controls.Add(this.btSave);
            this.gbTrans.Controls.Add(this.lbName);
            this.gbTrans.Controls.Add(this.lbBalance);
            this.gbTrans.Controls.Add(this.txAmount);
            this.gbTrans.Controls.Add(this.rbWithdrawal);
            this.gbTrans.Location = new System.Drawing.Point(22, 213);
            this.gbTrans.Name = "gbTrans";
            this.gbTrans.Size = new System.Drawing.Size(652, 225);
            this.gbTrans.TabIndex = 0;
            this.gbTrans.TabStop = false;
            // 
            // FmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.gbID);
            this.Controls.Add(this.gbTrans);
            this.Name = "FmTransactions";
            this.Text = "fmTransactions";
            this.Load += new System.EventHandler(this.FmTransactions_Load);
            this.gbTrans.ResumeLayout(false);
            this.gbTrans.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.TextBox txAmount;
        private System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.RadioButton rbWithdrawal;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.GroupBox gbID;
        private System.Windows.Forms.GroupBox gbTrans;
    }
}