using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;


namespace SchoolBank
{
    public partial class FmAccounts : Form
    {
        public FmAccounts()
        {
            InitializeComponent();
        }

        private void FmAccounts_Load(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "SELECT Class FROM Classes";
            OleDbDataAdapter da = new OleDbDataAdapter(Cmd);//open connection and run query
            DataSet dset = new DataSet();
            da.Fill(dset); //Fill dataset with results from query
            Conn.Close();
            //Load data into combobox
            cbClass.DataSource = dset.Tables[0];
            cbClass.DisplayMember = "Class";
            //Set date to date label
            lbDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (txStudentID.Text.Length == 6)
            {
                OleDbConnection Conn = new OleDbConnection(Program.ConnString);
                Conn.Open();
                OleDbCommand Cmd = new OleDbCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = "SELECT * FROM Accounts WHERE StudentId ='" + txStudentID.Text + "'";
                OleDbDataReader reader = Cmd.ExecuteReader();//This runs the query and allows results to be read.
                if (!reader.HasRows)
                {
                    reader.Close();
                    if (txForename.Text != "" && txSurname.Text != "")
                    {
                        if (Program.ValidAmount(txBalance.Text, 1.00, 50.00))
                        {
                            //Save Account
                            Cmd.CommandText = "INSERT INTO Accounts VALUES('" + txStudentID.Text + "',"
                                + "'" + txForename.Text + "', '" + txSurname.Text + "', '"
                                + cbClass.Text + "', " + txBalance.Text + ")";
                            Cmd.ExecuteNonQuery();
                            //Save Transaction - Deposit 
                            Cmd.CommandText = "INSERT INTO Transactions  VALUES('" + txStudentID.Text + "', "
                                + "#" + lbDate.Text + "#, " + txBalance.Text + ", 'D')";
                            Cmd.ExecuteNonQuery();

                            MessageBox.Show("Account saved");
                            ClearBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Please enter a balance bewteen 1.00 and 50.00");
                        }
                    }
                    else
                        MessageBox.Show("Please enter a forename and surname.");
                }
                else
                    MessageBox.Show("This student ID already has an account.");
                Conn.Close();
            }
            else
                MessageBox.Show("Student id must have 6 characters");
        }
        private void ClearBoxes() {
            txBalance.Clear();
            txForename.Clear();
            txSurname.Clear();
            txStudentID.Clear();
        }

    }
}