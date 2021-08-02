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

namespace SchoolBank
{
    public partial class FmTransactions : Form
    {
        public FmTransactions()
        {
            InitializeComponent();
        }

        private void FmTransactions_Load(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            gbTrans.Hide();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "SELECT * FROM Accounts WHERE StudentId ='" + txID.Text + "'";
            OleDbDataReader reader = Cmd.ExecuteReader();//Runs the query & allows results to be read. 
            if (reader.HasRows) //if a record is found display details 
            {
                reader.Read();//Read the first record found 
                lbName.Text = reader["Forename"] + " " + reader["Surname"];
                lbBalance.Text = String.Format("{0:N2}", reader["Balance"]);
                gbTrans.Show();
            }
            else
            {
                MessageBox.Show("Student ID not found - please check");
            }
            reader.Close();//Close the reader 
            Conn.Close();  //Close the connection 

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Single Balance = Convert.ToSingle(lbBalance.Text);
            string TransType = "";
            if (rbWithdrawal.Checked)
            {
                Balance -= Convert.ToSingle(txAmount.Text);
                TransType = "W";
            }
            else
            {
                Balance += Convert.ToSingle(txAmount.Text);
                TransType = "D";
            }
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "UPDATE Accounts SET Balance = " + Convert.ToString(Balance) + " WHERE StudentID ='" + txID.Text + "'";
            Cmd.ExecuteNonQuery();
            Cmd.CommandText = "INSERT INTO Transactions " + " VALUES('" + txID.Text + "', #" + DateTime.Now + "#, " + txAmount.Text + ", '" + TransType + "')";
            Cmd.ExecuteNonQuery();
            Conn.Close();
            MessageBox.Show("Transaction recorded.");
            ClearBoxes();
        }

        private void ClearBoxes()
        {
            txAmount.Clear();
            txID.Clear();
            gbTrans.Hide();
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}