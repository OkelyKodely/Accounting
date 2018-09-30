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
    public partial class ExpensesAndIncome : Form
    {
        private int accountid = 0;

        public ExpensesAndIncome()
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
            string quryString = "select * from Expenses where accountid=" + this.accountid + " order by id desc";
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(quryString, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Expenses");
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "");
            dataGridView1.Columns.Add("paymentMethod", "Payment");
            dataGridView1.Columns.Add("company", "Company");
            dataGridView1.Columns.Add("firstName", "First Name");
            dataGridView1.Columns.Add("lastName", "Last Name");
            dataGridView1.Columns.Add("date", "Date");
            dataGridView1.Columns.Add("amount", "Amount");
            dataGridView1.Columns.Add("expenseNote", "Note");
            //set autosize mode
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //datagrid has calculated it's widths so we can store them
            for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
            {
                //store autosized widths
                int colw = dataGridView1.Columns[i].Width;
                //remove autosizing
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //set width to calculated by autosize
                dataGridView1.Columns[i].Width = colw;
            }
            int row = ds.Tables["Expenses"].Rows.Count - 1;
            for (int r = 0; r <= row; r++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[r].Cells[0].Value = ds.Tables["Expenses"].Rows[r].ItemArray[6];
                dataGridView1.Rows[r].Cells[1].Value = ds.Tables["Expenses"].Rows[r].ItemArray[8];
                dataGridView1.Rows[r].Cells[2].Value = ds.Tables["Expenses"].Rows[r].ItemArray[7];
                dataGridView1.Rows[r].Cells[3].Value = ds.Tables["Expenses"].Rows[r].ItemArray[0];
                dataGridView1.Rows[r].Cells[4].Value = ds.Tables["Expenses"].Rows[r].ItemArray[1];
                dataGridView1.Rows[r].Cells[5].Value = ds.Tables["Expenses"].Rows[r].ItemArray[2];
                dataGridView1.Rows[r].Cells[6].Value = ds.Tables["Expenses"].Rows[r].ItemArray[3];
                dataGridView1.Rows[r].Cells[7].Value = ds.Tables["Expenses"].Rows[r].ItemArray[5];
            }

            quryString = "select * from Income where accountid=" + this.accountid + " order by id desc";
            da = new System.Data.OleDb.OleDbDataAdapter(quryString, con);
            ds = new DataSet();
            da.Fill(ds, "Income");
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("id", "");
            dataGridView2.Columns.Add("paymentMethod", "Payment");
            dataGridView2.Columns.Add("company", "Company");
            dataGridView2.Columns.Add("firstName", "First Name");
            dataGridView2.Columns.Add("lastName", "Last Name");
            dataGridView2.Columns.Add("date", "Date");
            dataGridView2.Columns.Add("amount", "Amount");
            dataGridView2.Columns.Add("incomeNote", "Note");
            //set autosize mode
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //datagrid has calculated it's widths so we can store them
            for (int i = 0; i <= dataGridView2.Columns.Count - 1; i++)
            {
                //store autosized widths
                int colw = dataGridView2.Columns[i].Width;
                //remove autosizing
                dataGridView2.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //set width to calculated by autosize
                dataGridView2.Columns[i].Width = colw;
            }
            row = ds.Tables["Income"].Rows.Count - 1;
            for (int r = 0; r <= row; r++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[r].Cells[0].Value = ds.Tables["Income"].Rows[r].ItemArray[7];
                dataGridView2.Rows[r].Cells[1].Value = ds.Tables["Income"].Rows[r].ItemArray[10];
                dataGridView2.Rows[r].Cells[2].Value = ds.Tables["Income"].Rows[r].ItemArray[5];
                dataGridView2.Rows[r].Cells[3].Value = ds.Tables["Income"].Rows[r].ItemArray[0];
                dataGridView2.Rows[r].Cells[4].Value = ds.Tables["Income"].Rows[r].ItemArray[1];
                dataGridView2.Rows[r].Cells[5].Value = ds.Tables["Income"].Rows[r].ItemArray[2];
                dataGridView2.Rows[r].Cells[6].Value = ds.Tables["Income"].Rows[r].ItemArray[3];
                dataGridView2.Rows[r].Cells[7].Value = ds.Tables["Income"].Rows[r].ItemArray[6];
            }

            con.Close();
        }

        public Button GetAccountingListButton()
        {
            return this.accountingListbtn;
        }

        public Panel GetExpensesAndIncomePanel()
        {
            return this.expensesAndIncomePanel;
        }

        public DataGridView GetDataGrid()
        {
            return this.dataGridView1;
        }

        public DataGridView GetDataGrid2()
        {
            return this.dataGridView2;
        }

        private void expensesSearch_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString =
    "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=acct.mdb;";
            con.Open();
            string quryString = "select * from Expenses where checkNo = '"+checkSearch.Text.Replace("'","''")+"' and accountid=" + this.accountid;
            if(checkSearch.Text.Length == 0)
            {
                quryString = "select * from Expenses where theirroutingNo = '" + routingSearch.Text.Replace("'", "''") + "' and accountid=" + this.accountid;
            }
            if(checkSearch.Text.Length == 0)
            {
                if(routingSearch.Text.Length == 0)
                {
                    quryString = "select * from Expenses where accountid=" + this.accountid + " order by id desc";
                }
            }
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(quryString, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Expenses");
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "");
            dataGridView1.Columns.Add("paymentMethod", "Payment");
            dataGridView1.Columns.Add("company", "Company");
            dataGridView1.Columns.Add("firstName", "First Name");
            dataGridView1.Columns.Add("lastName", "Last Name");
            dataGridView1.Columns.Add("date", "Date");
            dataGridView1.Columns.Add("amount", "Amount");
            dataGridView1.Columns.Add("expenseNote", "Note");
            //set autosize mode
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //datagrid has calculated it's widths so we can store them
            for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
            {
                //store autosized widths
                int colw = dataGridView1.Columns[i].Width;
                //remove autosizing
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //set width to calculated by autosize
                dataGridView1.Columns[i].Width = colw;
            }
            int row = ds.Tables["Expenses"].Rows.Count - 1;
            for (int r = 0; r <= row; r++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[r].Cells[0].Value = ds.Tables["Expenses"].Rows[r].ItemArray[6];
                dataGridView1.Rows[r].Cells[1].Value = ds.Tables["Expenses"].Rows[r].ItemArray[8];
                dataGridView1.Rows[r].Cells[2].Value = ds.Tables["Expenses"].Rows[r].ItemArray[7];
                dataGridView1.Rows[r].Cells[3].Value = ds.Tables["Expenses"].Rows[r].ItemArray[0];
                dataGridView1.Rows[r].Cells[4].Value = ds.Tables["Expenses"].Rows[r].ItemArray[1];
                dataGridView1.Rows[r].Cells[5].Value = ds.Tables["Expenses"].Rows[r].ItemArray[2];
                dataGridView1.Rows[r].Cells[6].Value = ds.Tables["Expenses"].Rows[r].ItemArray[3];
                dataGridView1.Rows[r].Cells[7].Value = ds.Tables["Expenses"].Rows[r].ItemArray[5];
            }
        }

        private void incomeSearch_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString =
    "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=acct.mdb;";
            con.Open();
            string quryString = "select * from Income where checkNo = '" + incomecheckSearch.Text.Replace("'", "''") + "' and accountid=" + this.accountid;
            if (incomecheckSearch.Text.Length == 0)
            {
                quryString = "select * from Income where theirroutingNo = '" + incomeroutingSearch.Text.Replace("'", "''") + "' and accountid=" + this.accountid;
            }
            if (incomecheckSearch.Text.Length == 0)
            {
                if (incomeroutingSearch.Text.Length == 0)
                {
                    quryString = "select * from Income where accountid=" + this.accountid + " order by id desc";
                }
            }
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(quryString, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Income");
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("id", "");
            dataGridView2.Columns.Add("paymentMethod", "Payment");
            dataGridView2.Columns.Add("company", "Company");
            dataGridView2.Columns.Add("firstName", "First Name");
            dataGridView2.Columns.Add("lastName", "Last Name");
            dataGridView2.Columns.Add("date", "Date");
            dataGridView2.Columns.Add("amount", "Amount");
            dataGridView2.Columns.Add("incomeNote", "Note");
            //set autosize mode
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //datagrid has calculated it's widths so we can store them
            for (int i = 0; i <= dataGridView2.Columns.Count - 1; i++)
            {
                //store autosized widths
                int colw = dataGridView2.Columns[i].Width;
                //remove autosizing
                dataGridView2.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //set width to calculated by autosize
                dataGridView2.Columns[i].Width = colw;
            }
            int row = ds.Tables["Income"].Rows.Count - 1;
            for (int r = 0; r <= row; r++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[r].Cells[0].Value = ds.Tables["Income"].Rows[r].ItemArray[7];
                dataGridView2.Rows[r].Cells[1].Value = ds.Tables["Income"].Rows[r].ItemArray[10];
                dataGridView2.Rows[r].Cells[2].Value = ds.Tables["Income"].Rows[r].ItemArray[5];
                dataGridView2.Rows[r].Cells[3].Value = ds.Tables["Income"].Rows[r].ItemArray[0];
                dataGridView2.Rows[r].Cells[4].Value = ds.Tables["Income"].Rows[r].ItemArray[1];
                dataGridView2.Rows[r].Cells[5].Value = ds.Tables["Income"].Rows[r].ItemArray[2];
                dataGridView2.Rows[r].Cells[6].Value = ds.Tables["Income"].Rows[r].ItemArray[3];
                dataGridView2.Rows[r].Cells[7].Value = ds.Tables["Income"].Rows[r].ItemArray[6];
            }
        }
    }
}