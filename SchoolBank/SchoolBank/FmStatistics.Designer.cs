
namespace SchoolBank
{
    partial class FmStatistics
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
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.rbListAll = new System.Windows.Forms.RadioButton();
            this.rbParticular = new System.Windows.Forms.RadioButton();
            this.rbTotals = new System.Windows.Forms.RadioButton();
            this.rbCurrentWeek = new System.Windows.Forms.RadioButton();
            this.btShow = new System.Windows.Forms.Button();
            this.btReturn = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.rbListAll);
            this.gbSelect.Controls.Add(this.rbParticular);
            this.gbSelect.Controls.Add(this.rbTotals);
            this.gbSelect.Controls.Add(this.rbCurrentWeek);
            this.gbSelect.Location = new System.Drawing.Point(12, 69);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(323, 147);
            this.gbSelect.TabIndex = 0;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "Select list:";
            // 
            // rbListAll
            // 
            this.rbListAll.AutoSize = true;
            this.rbListAll.Location = new System.Drawing.Point(25, 31);
            this.rbListAll.Name = "rbListAll";
            this.rbListAll.Size = new System.Drawing.Size(130, 21);
            this.rbListAll.TabIndex = 4;
            this.rbListAll.TabStop = true;
            this.rbListAll.Text = "List all accounts";
            this.rbListAll.UseVisualStyleBackColor = true;
            // 
            // rbParticular
            // 
            this.rbParticular.AutoSize = true;
            this.rbParticular.Location = new System.Drawing.Point(25, 112);
            this.rbParticular.Name = "rbParticular";
            this.rbParticular.Size = new System.Drawing.Size(262, 21);
            this.rbParticular.TabIndex = 7;
            this.rbParticular.TabStop = true;
            this.rbParticular.Text = "List trasactions for particular account";
            this.rbParticular.UseVisualStyleBackColor = true;
            // 
            // rbTotals
            // 
            this.rbTotals.AutoSize = true;
            this.rbTotals.Location = new System.Drawing.Point(25, 85);
            this.rbTotals.Name = "rbTotals";
            this.rbTotals.Size = new System.Drawing.Size(173, 21);
            this.rbTotals.TabIndex = 6;
            this.rbTotals.TabStop = true;
            this.rbTotals.Text = "Show this week\'s totals";
            this.rbTotals.UseVisualStyleBackColor = true;
            // 
            // rbCurrentWeek
            // 
            this.rbCurrentWeek.AutoSize = true;
            this.rbCurrentWeek.Location = new System.Drawing.Point(25, 58);
            this.rbCurrentWeek.Name = "rbCurrentWeek";
            this.rbCurrentWeek.Size = new System.Drawing.Size(238, 21);
            this.rbCurrentWeek.TabIndex = 5;
            this.rbCurrentWeek.TabStop = true;
            this.rbCurrentWeek.Text = "List transactions for current week";
            this.rbCurrentWeek.UseVisualStyleBackColor = true;
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(356, 181);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(75, 23);
            this.btShow.TabIndex = 2;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // btReturn
            // 
            this.btReturn.Location = new System.Drawing.Point(484, 368);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(75, 55);
            this.btReturn.TabIndex = 3;
            this.btReturn.Text = "Return to Menu";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 222);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(441, 201);
            this.grid.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Statistics";
            // 
            // FmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.gbSelect);
            this.Name = "FmStatistics";
            this.Text = "fmStatistics";
            this.Load += new System.EventHandler(this.FmStatistics_Load);
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.RadioButton rbParticular;
        private System.Windows.Forms.RadioButton rbTotals;
        private System.Windows.Forms.RadioButton rbCurrentWeek;
        private System.Windows.Forms.RadioButton rbListAll;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Label label1;
    }
}