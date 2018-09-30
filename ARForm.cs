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
    public partial class ARForm : Form
    {
        private int accountid = 0;

        public int arId = 0;

        public ARForm()
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

                timetb.Text = row["time"].ToString();
                timetb.Enabled = false;

                companytb.Text = row["company"].ToString();
                firstNametb.Text = row["firstname"].ToString();
                lastnametb.Text = row["lastname"].ToString();
                amounttb.Text = row["amount"].ToString();
                invoiceNotb.Text = row["invoiceNo"].ToString();
                description.Text = row["description"].ToString();
            }
        }

        public Button GetCloseButton()
        {
            return this.closebtn;
        }

        public Button GetDeleteButton()
        {
            return this.deletebtn;
        }

        public Panel GetAcctReceivablePanel()
        {
            return this.acctreceivablepanel;
        }

        public Button GetReceivePaymentButton()
        {
            return this.receivePaymentbtn;
        }

        public void Delete(int arId)
        {
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString =
    "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=acct.mdb;";
            con.Open();
            System.Data.OleDb.OleDbCommand com = new System.Data.OleDb.OleDbCommand();
            com.Connection = con;
            com.CommandText = "delete from AcctAR where id=" + arId + " and accountid=" + this.accountid;
            com.ExecuteNonQuery();
            MessageBox.Show("Delete successfully");

            con.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (IsFormatted(amounttb.Text) &&
                (companytb.Text.Length > 0 ||
                firstNametb.Text.Length > 0 &&
                lastnametb.Text.Length > 0))
            {
                System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
                con.ConnectionString =
        "Provider=Microsoft.Jet.OLEDB.4.0;"
                + "Data Source=acct.mdb;";
                con.Open();
                System.Data.OleDb.OleDbCommand com = new System.Data.OleDb.OleDbCommand();
                com.Connection = con;
                com.CommandText = "Update AcctAR set company='"+companytb.Text.Replace("'","''")+"', firstName='" + firstNametb.Text.Replace("'","''") + "', lastName='" + lastnametb.Text.Replace("'","''") + "', [date]='" + datetb.Text + "', [time]='" + timetb.Text + "', amount=" + amounttb.Text + ", invoiceNo='" + invoiceNotb.Text.Replace("'","''") + "', description='" + description.Text.Replace("'","''") + "' where id=" + this.arId + " and accountid=" + this.accountid;
                com.ExecuteNonQuery();
                MessageBox.Show("Save successfully");

                con.Close();
            }
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