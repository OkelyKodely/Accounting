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
    public partial class NewARForm : Form
    {
        private int accountid = 0;

        public NewARForm()
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
            datetb.Text = DateTime.Now.Date.ToString();
            datetb.Text = datetb.Text.Split(' ')[0];
            datetb.Enabled = false;

            timetb.Text = DateTime.Now.TimeOfDay.ToString();
            timetb.Enabled = false;

            companytb.Text = "";
            firstNametb.Text = "";
            lastnametb.Text = "";
            amounttb.Text = "";
            invoiceNotb.Text = "";
            description.Text = "";
        }

        public Button GetCloseButton()
        {
            return this.closebtn;
        }

        public Panel GetNewAcctReceivablePanel()
        {
            return this.newacctreceivablepanel;
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
                com.CommandText = "INSERT INTO AcctAR(accountid, company, firstName, lastName, [date], [time], amount, invoiceNo, description)VALUES(" + this.accountid + ", '"+companytb.Text.Replace("'","''")+"','" + firstNametb.Text.Replace("'","''") + "','" + lastnametb.Text.Replace("'","''") + "','" + datetb.Text + "','" + timetb.Text + "'," + amounttb.Text + ",'" + invoiceNotb.Text.Replace("'","''") + "','" + description.Text.Replace("'","''") + "')";
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