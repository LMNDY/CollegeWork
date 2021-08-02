using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.VisualBasic;
using System.Drawing.Printing;

namespace SchoolBank
{
    public partial class FmStatistics : Form
    {
        public FmStatistics()
        {
            InitializeComponent();
        }


        private void FmStatistics_Load(object sender, EventArgs e)
        {
            grid.Hide();
        }
        
        private void btReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            DateTime StartDate = DateTime.Today.AddDays(-7);
            string strStart = StartDate.ToString("MM/dd/yyyy");
            DateTime EndDate = DateTime.Today;
            string strEnd = EndDate.ToString("MM/dd/yyyy");
            String SQL = "";
            if (rbListAll.Checked)
            {
                SQL = "SELECT * FROM Accounts";
            }
            else if (rbCurrentWeek.Checked)
            {
                SQL = "SELECT Accounts.StudentID, Forename, Surname, TransDate, TransType, Amount "
                    + "FROM Accounts, Transactions "
                    + "WHERE TransDate>=#" + strStart + "# AND TransDate<=#" + strEnd + "# "
                    + "AND Accounts.StudentID=Transactions.StudentID "
                    + "ORDER BY TransDate, TransType";
            }
            else if (rbTotals.Checked)
            {
                SQL = "SELECT TransType, SUM(Amount) AS Total FROM Transactions "
                                + "WHERE TransDate BETWEEN #" + strStart + "# AND #" + strEnd + "# "
                                + "GROUP BY TransType";
            }
            else if (rbParticular.Checked)
            {
                string ID = Interaction.InputBox("Enter student ID:", "");
                SQL = "SELECT TransDate, TransType, Amount FROM Transactions "
                    + "WHERE StudentID='" + ID + "' ORDER BY TransDate";
            }
            Cmd.CommandText = SQL;
            OleDbDataAdapter da = new OleDbDataAdapter(Cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            grid.DataSource = table;
            if (table.Rows.Count > 0)
            {
                grid.AutoResizeColumns();
                grid.ReadOnly = true;
                grid.Show();
            }
            else
            {
                MessageBox.Show("Nothing found.");
                grid.Hide();
            }
            Conn.Close();
        }

     
     

    }
}
