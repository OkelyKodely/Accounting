using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acct
{
    public partial class IncomeForm : Form
    {
        private int accountid = 0;

        public int incomeId = 0;

        public IncomeForm()
        {
            InitializeComponent();
        }

        public void SetAccountId(int id)
        {
            this.accountid = id;
        }

        public int GetAccountId()
        {
            return this.accountid;
        }

        public void CancelIncome()
        {
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString =
    "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=acct.mdb;";
            con.Open();
            string quryString = "INSERT INTO AcctAR(accountid, company, firstName, lastName, [date], amount, invoiceNo, description) SELECT accountid, company, firstName, lastName, [date], amount, invoiceNo, incomeNote FROM INCOME WHERE id=" + this.incomeId + " and accountid=" + this.accountid;
            System.Data.OleDb.OleDbCommand c = new System.Data.OleDb.OleDbCommand();
            c.CommandText = quryString;
            c.Connection = con;
            c.ExecuteNonQuery();
            quryString = "DELETE FROM Income WHERE id=" + this.incomeId + " and accountid=" + this.accountid;
            c = new System.Data.OleDb.OleDbCommand();
            c.CommandText = quryString;
            c.Connection = con;
            c.ExecuteNonQuery();
            MessageBox.Show("Cancel Successfully");

            con.Close();
        }

        public void LoadMe()
        {
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString =
    "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=acct.mdb;";
            con.Open();
            string quryString = "select * from Income where id=" + this.incomeId + " and accountid=" + this.accountid;
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(quryString, con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                datetb.Text = row["date"].ToString();
                datetb.Enabled = false;

                companytb.Text = row["company"].ToString();
                firstNametb.Text = row["firstname"].ToString();
                lastnametb.Text = row["lastname"].ToString();
                amounttb.Text = row["amount"].ToString();
                invoiceNotb.Text = row["invoiceNo"].ToString();
                description.Text = row["incomeNote"].ToString();
                paymentMethodcb.Text = row["paymentMethod"].ToString();
                mybankacctnotb.Text = row["bankAccountNo"].ToString();
                checkNotb.Text = row["checkNo"].ToString();
                myroutingnotb.Text = row["routingNo"].ToString();
                theirbankacctnotb.Text = row["theirbankAccountNo"].ToString();
                theirroutingnotb.Text = row["theirroutingNo"].ToString();
            }
        }

        public Button GetCloseButton()
        {
            return this.closebtn;
        }

        public Button GetCancelIncomeButton()
        {
            return this.cancelIncomebtn;
        }

        public Panel GetIncomePanel()
        {
            return this.incomepanel;
        }

        private bool IsFormatted(string amt)
        {
            decimal d;
            if (decimal.TryParse(amt, out d))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}