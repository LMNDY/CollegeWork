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
    public partial class FmMenu : Form
    {
        public FmMenu()
        {
            InitializeComponent();
        }

        private void FmMenu_load(object sender, EventArgs e)
        {
            if (File.Exists("SJBankCS.accdb") == false)//if the database doesn't exist
            {
                ADOX.Catalog cat = new ADOX.Catalog();
                cat.Create(Program.ConnString);  //Create database using connection string in Program.cs
                OleDbConnection Conn = new OleDbConnection(Program.ConnString);  // set up connection to database
                OleDbCommand Cmd = new OleDbCommand();  //Create a database command object
                Conn.Open();  //Open connection to database
                Cmd.Connection = Conn;  //

                //Create Classes Table
                Cmd.CommandText = "CREATE TABLE Classes(Class CHAR(3), Teacher VARCHAR(20), "
                               + "PRIMARY KEY (Class))";
                Cmd.ExecuteNonQuery();
                //Add some classes to the Classes table
                Cmd.CommandText = "INSERT INTO Classes VALUES('5AC','Ms A. Clarke')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Classes VALUES('5DW','Mr D. Wallis')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Classes VALUES('6KH','Mr K. Hashmi')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Classes VALUES('6TG','Ms T. Green')";
                Cmd.ExecuteNonQuery();
                //Create the Accounts table
                Cmd.CommandText = "CREATE TABLE Accounts(StudentId CHAR(6), Forename VARCHAR(15), Surname VARCHAR(20), Class CHAR(3), Balance MONEY, FOREIGN KEY(Class) REFERENCES Classes(Class), PRIMARY KEY (StudentId))";
                Cmd.ExecuteNonQuery();

                Cmd.CommandText = "CREATE TABLE Transactions(StudentId CHAR(6), TransDate DATE, Amount MONEY, TransType CHAR(1), FOREIGN KEY(StudentId) REFERENCES Accounts(StudentId), PRIMARY KEY(StudentId,TransDate))";
                Cmd.ExecuteNonQuery();

                Conn.Close();
            }
        }

        private void btAccounts_Click(object sender, EventArgs e)
        {
            FmAccounts fmAccounts = new FmAccounts();//Instantiate fmAccounts object
            fmAccounts.ShowDialog();// Display fmAccouts
        }

        private void btTransactions_Click(object sender, EventArgs e)
        {
            FmTransactions fmTrans = new FmTransactions();
            fmTrans.ShowDialog();
        }

        private void btStatistics_Click(object sender, EventArgs e)
        {
            FmStatistics fmStats = new FmStatistics();
            fmStats.ShowDialog();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
