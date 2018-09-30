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
    public partial class WriteCheckForm : Form
    {
        private int accountid = 0;

        public int apId = 0;

        public WriteCheckForm()
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

        public Button GetCloseButton()
        {
            return this.closebtn;
        }

        public Button GetMakeAPaymentButton()
        {
            return this.makeAPaymentbtn;
        }
        
        public Panel GetWriteCheckPanel()
        {
            return this.writeCheckPanel;
        }

        public void LoadMe()
        {
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString =
    "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=acct.mdb;";
            con.Open();
            string quryString = "select * from AcctAP where id=" + this.apId + " and accountid=" + this.accountid;
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(quryString, con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                datetb.Text = row["date"].ToString();
                datetb.Enabled = false;

                payeetb.Text = row["company"].ToString();
                firstNametb.Text = row["firstname"].ToString();
                lastnametb.Text = row["lastname"].ToString();
                amounttb.Text = row["amount"].ToString();
                invoiceNotb.Text = row["invoiceNo"].ToString();
                expenseNotetb.Text = row["description"].ToString();
            }
        }

        public void MakeAPayment()
        {
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString =
    "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=acct.mdb;";
            con.Open();
            System.Data.OleDb.OleDbCommand com = new System.Data.OleDb.OleDbCommand();
            com.Connection = con;
            com.CommandText = "Delete From AcctAP Where id=" + this.apId + " and accountid=" + this.accountid;
            com.ExecuteNonQuery();
            com.CommandText = "INSERT INTO Expenses(accountid, company, firstName, lastName, [date], amount, invoiceNo, expenseNote, paymentMethod, bankAccountNo, checkNo, routingNo, theirbankAccountNo, theirroutingNo)VALUES(" + this.accountid + ", '" + payeetb.Text.Replace("'","''") + "','" + firstNametb.Text.Replace("'","''") + "','" + lastnametb.Text.Replace("'","''") + "','" + datetb.Text + "'," + amounttb.Text + ",'" + invoiceNotb.Text.Replace("'","''") + "', '"+expenseNotetb.Text.Replace("'","''")+"', '"+paymentMethodcb.Text.Replace("'","''")+"', '"+mybankacctnotb.Text.Replace("'","''")+"', '"+checkNotb.Text.Replace("'","''")+"', '"+myroutingnotb.Text.Replace("'","''")+"', '"+theirbankacctnotb.Text.Replace("'","''")+"', '"+theirroutingnotb.Text.Replace("'","''")+"')";
            com.ExecuteNonQuery();
            MessageBox.Show("Done");

            con.Close();
        }

        private void theirbankacctnotb_TextChanged(object sender, EventArgs e)
        {

        }

        private void paymentMethodcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mybankacctnolbl_Click(object sender, EventArgs e)
        {

        }

        private void mybankacctnotb_TextChanged(object sender, EventArgs e)
        {

        }

        private void paymentMethodlbl_Click(object sender, EventArgs e)
        {

        }

        private void theirbankacctnolbl_Click(object sender, EventArgs e)
        {

        }
    }
}