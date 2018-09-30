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
    public partial class Accounts : Form
    {
        private int theaccountid = 0;

        public Accounts()
        {
            InitializeComponent();

            LoadMe();

            this.accountspanel.BackColor = Color.Transparent;
        }

        public void LoadMe()
        {
            List<string> _items = new List<string>();
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString =
    "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=acct.mdb;";
            con.Open();
            string quryString = "select * from Accounts order by id desc";
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(quryString, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Accounts");
            int row = ds.Tables["Accounts"].Rows.Count - 1;
            for (int r = 0; r <= row; r++)
            {
                _items.Add((int)ds.Tables["Accounts"].Rows[r].ItemArray[0] + "(" + ds.Tables["Accounts"].Rows[r].ItemArray[1].ToString() + ")");
            }
            openlistbox.DataSource = _items;
            ClearAccountFields();

            quryString = "select * from Accounts order by id desc";
            da = new System.Data.OleDb.OleDbDataAdapter(quryString, con);
            ds = new DataSet();
            da.Fill(ds, "Accounts");
            row = ds.Tables["Accounts"].Rows.Count - 1;
            int v = 0;
            int aid = 0;
            int rr = -1;
            for (int r = 0; r <= row; r++)
            {
                v = (int)ds.Tables["Accounts"].Rows[r].ItemArray[14];
                if (v == 1)
                {
                    aid = (int)ds.Tables["Accounts"].Rows[r].ItemArray[0];
                    rr = r;
                }
            }

            this.openlistbox.SelectedIndex = rr;

            this.theaccountid = aid;
            
            PopulateAccountFields();

            con.Close();
        }

        public void ClearAccountFields()
        {
            accountName.Text = "";
            firstName.Text = "";
            lastName.Text = "";
            company.Text = "";
            address.Text = "";
            city.Text = "";
            state.Text = "";
            country.Text = "";
            phone.Text = "";
            fax.Text = "";
            email.Text = "";
        }

        public CheckBox GetNewAccount()
        {
            return this.newAccount;
        }

        public void SetAccountId(int id)
        {
            this.theaccountid = id;
        }

        public void PopulateAccountFields()
        {
            if (openlistbox.SelectedValue == null)
                return;
            List<string> _items = new List<string>();
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString =
    "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=acct.mdb;";
            con.Open();
            string quryString = "select * from Accounts where id=" + openlistbox.SelectedValue.ToString().Substring(0,openlistbox.SelectedValue.ToString().IndexOf("("));
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(quryString, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Accounts");
            int row = ds.Tables["Accounts"].Rows.Count - 1;
            for (int r = 0; r <= row; r++)
            {
                accountName.Text = ds.Tables["Accounts"].Rows[r].ItemArray[1].ToString();
                firstName.Text = ds.Tables["Accounts"].Rows[r].ItemArray[2].ToString();
                lastName.Text = ds.Tables["Accounts"].Rows[r].ItemArray[3].ToString();
                company.Text = ds.Tables["Accounts"].Rows[r].ItemArray[6].ToString();
                address.Text = ds.Tables["Accounts"].Rows[r].ItemArray[7].ToString();
                city.Text = ds.Tables["Accounts"].Rows[r].ItemArray[8].ToString();
                state.Text = ds.Tables["Accounts"].Rows[r].ItemArray[9].ToString();
                country.Text = ds.Tables["Accounts"].Rows[r].ItemArray[10].ToString();
                phone.Text = ds.Tables["Accounts"].Rows[r].ItemArray[11].ToString();
                fax.Text = ds.Tables["Accounts"].Rows[r].ItemArray[12].ToString();
                email.Text = ds.Tables["Accounts"].Rows[r].ItemArray[13].ToString();
            }
            this.theaccountid = (int)Int64.Parse(openlistbox.SelectedValue.ToString().Substring(0, openlistbox.SelectedValue.ToString().IndexOf("(")));
            System.Data.OleDb.OleDbCommand c = new System.Data.OleDb.OleDbCommand();
            quryString = "update Accounts set [default]=0";
            c.CommandText = quryString;
            c.Connection = con;
            c.ExecuteNonQuery();
            c = new System.Data.OleDb.OleDbCommand();
            quryString = "update Accounts set [default]=1 where id=" + (int)Int64.Parse(openlistbox.SelectedValue.ToString().Substring(0, openlistbox.SelectedValue.ToString().IndexOf("(")));
            c.CommandText = quryString;
            c.Connection = con;
            c.ExecuteNonQuery();
            con.Close();
            this.newAccount.Checked = false;
        }

        public string GetNewAccountName()
        {
            return this.accountName.Text;
        }

        public void CreateNewAccount()
        {
            if (openlistbox.SelectedValue == null)
                return;
            List<string> _items = new List<string>();
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString =
    "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=acct.mdb;";
            con.Open();
            System.Data.OleDb.OleDbCommand c = new System.Data.OleDb.OleDbCommand();
            string quryString = "update Accounts set [default]=0";
            c.CommandText = quryString;
            c.Connection = con;
            c.ExecuteNonQuery();
            quryString = "insert into Accounts (accountName, firstName, lastName, createdDate, company, address, city, state, country, phone, fax, email, [default]) values ('" + accountName.Text + "', '" + firstName.Text + "', '" + lastName.Text + "', Date(), '" + company.Text + "', '" + address.Text + "', '" + city.Text + "', '" + state.Text + "', '" + country.Text + "', '" + phone.Text + "', '" + fax.Text + "', '" + email.Text + "', 1)";
            c = new System.Data.OleDb.OleDbCommand();
            c.CommandText = quryString;
            c.Connection = con;
            c.ExecuteNonQuery();
 
            quryString = "select max(id)+1 as accountid from Accounts";
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(quryString, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Accounts");
            int row = ds.Tables["Accounts"].Rows.Count - 1;
            for (int r = 0; r <= row; r++)
            {
                this.theaccountid = (int)Int64.Parse(ds.Tables["Accounts"].Rows[r].ItemArray[0].ToString());
            }

            con.Close();
        }

        public int GetTheAccountId()
        {
            return this.theaccountid;
        }

        public Panel GetAccountsPanel()
        {
            return this.accountspanel;
        }

        public Button GetCreateGotoButton()
        {
            return this.creategotobtn;
        }

        public Button GetCloseButton()
        {
            return this.closebtn;
        }

        public ListBox GetListBox()
        {
            return this.openlistbox;
        }
    }
}