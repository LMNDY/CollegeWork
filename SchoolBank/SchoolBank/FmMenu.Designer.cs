
namespace SchoolBank
{
    partial class FmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAccounts = new System.Windows.Forms.Button();
            this.btTransactions = new System.Windows.Forms.Button();
            this.btStatistics = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Bank";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btAccounts
            // 
            this.btAccounts.Location = new System.Drawing.Point(349, 103);
            this.btAccounts.Name = "btAccounts";
            this.btAccounts.Size = new System.Drawing.Size(148, 64);
            this.btAccounts.TabIndex = 2;
            this.btAccounts.Text = "Accounts";
            this.btAccounts.UseVisualStyleBackColor = true;
            this.btAccounts.Click += new System.EventHandler(this.btAccounts_Click);
            // 
            // btTransactions
            // 
            this.btTransactions.Location = new System.Drawing.Point(349, 173);
            this.btTransactions.Name = "btTransactions";
            this.btTransactions.Size = new System.Drawing.Size(148, 64);
            this.btTransactions.TabIndex = 3;
            this.btTransactions.Text = "Transactions";
            this.btTransactions.UseVisualStyleBackColor = true;
            this.btTransactions.Click += new System.EventHandler(this.btTransactions_Click);
            // 
            // btStatistics
            // 
            this.btStatistics.Location = new System.Drawing.Point(349, 243);
            this.btStatistics.Name = "btStatistics";
            this.btStatistics.Size = new System.Drawing.Size(148, 64);
            this.btStatistics.TabIndex = 4;
            this.btStatistics.Text = "Statistics";
            this.btStatistics.UseVisualStyleBackColor = true;
            this.btStatistics.Click += new System.EventHandler(this.btStatistics_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(349, 313);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(148, 64);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // FmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btStatistics);
            this.Controls.Add(this.btTransactions);
            this.Controls.Add(this.btAccounts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FmMenu_load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btAccounts;
        private System.Windows.Forms.Button btTransactions;
        private System.Windows.Forms.Button btStatistics;
        private System.Windows.Forms.Button btExit;
    }
}

