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
    public partial class ReceivePaymentForm : Form
    {
        private int accountid = 0;

        public int arId = 0;

        public ReceivePaymentForm()
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

        public Button GetReceivePaymentButton()
        {
            return this.receivePaymentbtn;
        }
        
        public Panel GetReceivePaymentPanel()
        {
            return this.receivePaymentPanel;
        }

        public void LoadMe()
        {
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString =
    "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=acct.mdb;";
            con.Open();
            string quryString = "select * from AcctAR where id=" + this.arId + " and accountid=" + this.accountid;
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
                incomeNotetb.Text = row["description"].ToString();
            }
        }

        public void ReceivePayment()
        {
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString =
    "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=acct.mdb;";
            con.Open();
            System.Data.OleDb.OleDbCommand com = new System.Data.OleDb.OleDbCommand();
            com.Connection = con;
            com.CommandText = "INSERT INTO Income(accountid, company, firstName, lastName, [date], amount, invoiceNo, incomeNote, paymentMethod, checkNo, bankAccountNo, routingNo, theirbankAccountNo, theirroutingNo)VALUES(" + this.accountid + ", '" + companytb.Text.Replace("'","''") + "','" + firstNametb.Text.Replace("'","''") + "','" + lastnametb.Text.Replace("'","''") + "','" + datetb.Text + "'," + amounttb.Text + ",'" + invoiceNotb.Text.Replace("'","''") + "', '"+incomeNotetb.Text.Replace("'","''")+"', '"+paymentMethodcb.Text.Replace("'","''")+"', '"+checkNotb.Text.Replace("'","''")+"', '"+mybankacctnotb.Text.Replace("'","''")+"', '"+myroutingnotb.Text.Replace("'","''")+"', '"+theirbankacctnotb.Text.Replace("'","''")+"', '"+theirroutingnotb.Text.Replace("'","''")+"')";
            com.ExecuteNonQuery();
            com.CommandText = "Delete From AcctAR Where id=" + this.arId + " and accountid=" + this.accountid;
            com.ExecuteNonQuery();
            MessageBox.Show("Done");

            con.Close();
        }
    }
}