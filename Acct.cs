using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Acct
{
    public partial class Acct : Form
    {
        private int accountid = 0;

        private double asset = 0.0;
        private int apId = 0;
        private int arId = 0;
        private int expenseId = 0;
        private int incomeId = 0;

        private IncomeForm incomeForm = new IncomeForm();
        private Panel incomepanel = null;
        private ExpensesForm expenseForm = new ExpensesForm();
        private Panel expensepanel = null;
        private NewAPForm newapform = new NewAPForm();
        private Panel newacctpayablepanel = null;
        private NewARForm newarform = new NewARForm();
        private Panel newacctreceivablepanel = null;
        private APForm apform = new APForm();
        private Panel acctpayablepanel = null;
        private ARForm arform = new ARForm();
        private Panel acctreceivablepanel = null;
        private WriteCheckForm writeCheckForm = new WriteCheckForm();
        private Panel writecheckpanel = null;
        private ReceivePaymentForm receivePaymentForm = new ReceivePaymentForm();
        private Panel receivepaymentpanel = null;
        private ExpensesAndIncome expensesincomeform = new ExpensesAndIncome();
        private Panel expensesincomepanel = null;
        private Accounts accounts = new Accounts();
        private Panel accountspanel = null;

        public Acct()
        {
            InitializeComponent();

            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.BackColor = Color.White;

            this.acctlistpanel.BackColor = Color.Transparent;

            AccountLoad();
 
            LoadForm();
        }

        public void LoadForm()
        {
            this.newapform.GetCloseButton().Click -= new EventHandler(BringBackAcctPanelAP);
            this.newapform.GetCloseButton().Click += new EventHandler(BringBackAcctPanelAP);
            this.newapform.SetAccountId(this.accountid);
            this.newarform.GetCloseButton().Click -= new EventHandler(BringBackAcctPanelAR);
            this.newarform.GetCloseButton().Click += new EventHandler(BringBackAcctPanelAR);
            this.newarform.SetAccountId(this.accountid);
            this.newarform.LoadMe();
            this.apform.GetCloseButton().Click -= new EventHandler(BringBackAcctPanel_AP);
            this.apform.GetCloseButton().Click += new EventHandler(BringBackAcctPanel_AP);
            this.apform.SetAccountId(this.accountid);
            this.apform.LoadMe();
            this.arform.GetCloseButton().Click -= new EventHandler(BringBackAcctPanel_AR);
            this.arform.GetCloseButton().Click += new EventHandler(BringBackAcctPanel_AR);
            this.arform.SetAccountId(this.accountid);
            this.arform.LoadMe();
            this.apform.GetDeleteButton().Click -= new EventHandler(DeleteAP);
            this.apform.GetDeleteButton().Click += new EventHandler(DeleteAP);
            this.arform.GetDeleteButton().Click -= new EventHandler(DeleteAR);
            this.arform.GetDeleteButton().Click += new EventHandler(DeleteAR);
            this.writeCheckForm.GetCloseButton().Click -= new EventHandler(BringBackAcctPanel_WC);
            this.writeCheckForm.GetCloseButton().Click += new EventHandler(BringBackAcctPanel_WC);
            this.writeCheckForm.GetMakeAPaymentButton().Click -= new EventHandler(PayBill);
            this.writeCheckForm.GetMakeAPaymentButton().Click += new EventHandler(PayBill);
            this.writeCheckForm.SetAccountId(this.accountid);
            this.apform.GetWriteCheckButton().Click -= new EventHandler(WriteCheck);
            this.apform.GetWriteCheckButton().Click += new EventHandler(WriteCheck);
            this.receivePaymentForm.GetCloseButton().Click -= new EventHandler(BringBackAcctPanel_RP);
            this.receivePaymentForm.GetCloseButton().Click += new EventHandler(BringBackAcctPanel_RP);
            this.receivePaymentForm.GetReceivePaymentButton().Click -= new EventHandler(ReceivePayment);
            this.receivePaymentForm.GetReceivePaymentButton().Click += new EventHandler(ReceivePayment);
            this.receivePaymentForm.SetAccountId(this.accountid);
            this.arform.GetReceivePaymentButton().Click -= new EventHandler(ReceiveAPayment);
            this.arform.GetReceivePaymentButton().Click += new EventHandler(ReceiveAPayment);
            this.expensesincomeform.GetAccountingListButton().Click -= new EventHandler(BringBackAcctPanel_EI);
            this.expensesincomeform.GetAccountingListButton().Click += new EventHandler(BringBackAcctPanel_EI);
            this.expensesincomeform.SetAccountId(this.accountid);
            this.expenseForm.GetCloseButton().Click -= new EventHandler(BringBackAcctPanel_DG);
            this.expenseForm.GetCloseButton().Click += new EventHandler(BringBackAcctPanel_DG);
            this.expenseForm.GetCancelExpenseButton().Click -= new EventHandler(CancelExpense);
            this.expenseForm.GetCancelExpenseButton().Click += new EventHandler(CancelExpense);
            this.expenseForm.SetAccountId(this.accountid);
            this.expenseForm.LoadMe();
            this.expensesincomeform.GetDataGrid().CellClick -= new System.Windows.Forms.DataGridViewCellEventHandler(viewExpense);
            this.expensesincomeform.GetDataGrid().CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(viewExpense);
            this.incomeForm.GetCloseButton().Click -= new EventHandler(BringBackAcctPanel_IF);
            this.incomeForm.GetCloseButton().Click += new EventHandler(BringBackAcctPanel_IF);
            this.incomeForm.GetCancelIncomeButton().Click -= new EventHandler(CancelIncome);
            this.incomeForm.GetCancelIncomeButton().Click += new EventHandler(CancelIncome);
            this.incomeForm.SetAccountId(this.accountid);
            this.incomeForm.LoadMe();
            this.expensesincomeform.GetDataGrid2().CellClick -= new System.Windows.Forms.DataGridViewCellEventHandler(viewIncome);
            this.expensesincomeform.GetDataGrid2().CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(viewIncome);
            this.accounts.GetCloseButton().Click -= new EventHandler(CloseAccounts);
            this.accounts.GetCloseButton().Click += new EventHandler(CloseAccounts);
            this.accounts.GetListBox().Click -= new EventHandler(OpenAcct);
            this.accounts.GetListBox().Click += new EventHandler(OpenAcct);
            this.accounts.GetCreateGotoButton().Click -= new EventHandler(DoOpenAcct);
            this.accounts.GetCreateGotoButton().Click += new EventHandler(DoOpenAcct);
            this.accounts.GetNewAccount().Click -= new EventHandler(ToggleNewAcct);
            this.accounts.GetNewAccount().Click += new EventHandler(ToggleNewAcct);

            this.Menu = this.file;

            MenuItem menuItem1 = new MenuItem();
            MenuItem account_t = new MenuItem();
            MenuItem exit_t = new MenuItem();

            menuItem1.Text = "File";
            account_t.Text = "Accounts";
            exit_t.Text = "Exit";

            file.MenuItems.Clear();
            file.MenuItems.Add(menuItem1);

            menuItem1.MenuItems.Add(account_t);
            menuItem1.MenuItems.Add(exit_t);

            account_t.Click += new EventHandler(OpenAccounts);
            exit_t.Click += new EventHandler(Exit);

            LoadApAr(null, null);
        }

        public void ToggleNewAcct(object sender, EventArgs e)
        {
            if (this.accounts.GetNewAccount().Checked)
            {
                this.accounts.ClearAccountFields();
            }
            else
            {
                this.accounts.PopulateAccountFields();
            }
        }

        public void CancelExpense(object sender, EventArgs e)
        {
            this.expenseForm.CancelExpense();
            this.expensesincomeform.LoadMe();
        }

        public void CancelIncome(object sender, EventArgs e)
        {
            this.incomeForm.CancelIncome();
            this.expensesincomeform.LoadMe();
        }

        public void DoOpenAcct(object sender, EventArgs e)
        {
            if (!this.accounts.GetNewAccount().Checked && this.accounts.GetTheAccountId() != 0)
            {
                this.accountid = this.accounts.GetTheAccountId();
                this.Controls.Clear();
                this.Controls.Add(this.acctlistpanel);
                LoadForm();
                this.Height = 630;
            }
            else if(this.accounts.GetNewAccount().Checked)
            {
                if (this.accounts.GetNewAccountName().Length > 0)
                {
                    this.accounts.CreateNewAccount();
                    this.accountid = this.accounts.GetTheAccountId();
                    this.Controls.Clear();
                    this.Controls.Add(this.acctlistpanel);
                    LoadForm();
                    this.Height = 630;
                }
                else
                {
                    MessageBox.Show("Account Name needs to be filled");
                }
            }
        }

        public void OpenAcct(object sender, EventArgs e)
        {
            this.accounts.PopulateAccountFields();
        }

        public void CloseAccounts(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(this.acctlistpanel);
            LoadApAr(null, null);
            this.Height = 630;
        }

        public void OpenAccounts(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(this.accounts.GetAccountsPanel());
            this.accounts.LoadMe();
            this.accountspanel = this.accounts.GetAccountsPanel();
            this.Height = 520;
        }

        public void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void AccountLoad()
        {
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
            int v = 0;
            int aid = 0;
            int rr = -1;
            for (int r = 0; r <= row; r++)
            {
                v = (int)ds.Tables["Accounts"].Rows[r].ItemArray[14];
                if(v == 1)
                {
                    aid = (int)ds.Tables["Accounts"].Rows[r].ItemArray[0];
                    rr = r;
                }
            }

            this.accountid = aid;

            con.Close();
        }
        
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            var brush = new LinearGradientBrush(this.ClientRectangle,
                    Color.White, Color.DarkGray, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }

        public void DeleteAP(object sender, EventArgs e)
        {
            this.apform.Delete(this.apId);
        }

        public void DeleteAR(object sender, EventArgs e)
        {
            this.arform.Delete(this.arId);
        }

        public void BringBackAcctPanel_IF(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.expensesincomepanel = this.expensesincomeform.GetExpensesAndIncomePanel();
            this.Controls.Add(this.expensesincomepanel);
            this.incomepanel = this.incomeForm.GetIncomePanel();
            this.Height = 630;
        }

        public void BringBackAcctPanel_DG(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.expensesincomepanel = this.expensesincomeform.GetExpensesAndIncomePanel();
            this.Controls.Add(this.expensesincomepanel);
            this.expensepanel = this.expenseForm.GetExpensePanel();
            this.Height = 630;
        }

        public void BringBackAcctPanelAP(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(this.acctlistpanel);
            this.newacctpayablepanel = this.newapform.GetNewAcctPayablePanel();
            LoadApAr(null, null);
            this.Height = 630;
        }

        public void BringBackAcctPanelAR(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(this.acctlistpanel);
            this.newacctreceivablepanel = this.newarform.GetNewAcctReceivablePanel();
            LoadApAr(null, null);
            this.Height = 630;
        }

        public void BringBackAcctPanel_AP(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(this.acctlistpanel);
            this.acctpayablepanel = this.apform.GetAcctPayablePanel();
            LoadApAr(null, null);
            this.Height = 630;
        }

        public void BringBackAcctPanel_AR(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(this.acctlistpanel);
            this.acctreceivablepanel = this.arform.GetAcctReceivablePanel();
            LoadApAr(null, null);
            this.Height = 630;
        }

        public void BringBackAcctPanel_WC(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(this.acctlistpanel);
            this.writecheckpanel = this.writeCheckForm.GetWriteCheckPanel();
            LoadApAr(null, null);
            this.Height = 630;
        }

        public void BringBackAcctPanel_EI(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(this.acctlistpanel);
            this.expensesincomepanel = this.expensesincomeform.GetExpensesAndIncomePanel();
            LoadApAr(null, null);
            this.Height = 630;
        }

        public void PayBill(object sender, EventArgs e)
        {
            this.writeCheckForm.MakeAPayment();
        }

        public void BringBackAcctPanel_RP(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(this.acctlistpanel);
            this.receivepaymentpanel = this.receivePaymentForm.GetReceivePaymentPanel();
            LoadApAr(null, null);
            this.Height = 630;
        }

        public void ReceivePayment(object sender, EventArgs e)
        {
            this.receivePaymentForm.ReceivePayment();
        }

        public void LoadApAr(object sender, EventArgs e)
        {
            this.asset = 0.00;
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString =
    "Provider=Microsoft.Jet.OLEDB.4.0;"
            + "Data Source=acct.mdb;";
            con.Open();
            string quryString = "select * from AcctAP where accountid=" + this.accountid + " order by id desc";
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(quryString, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "AcctAP");
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "");
            dataGridView1.Columns.Add("company", "Company");
            dataGridView1.Columns.Add("firstName", "First Name");
            dataGridView1.Columns.Add("lastName", "Last Name");
            dataGridView1.Columns.Add("date", "Date");
            dataGridView1.Columns.Add("amount", "Amount");
            //set autosize mode
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            int row = ds.Tables["AcctAP"].Rows.Count - 1;
            for (int r = 0; r <= row; r++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[r].Cells[0].Value = ds.Tables["AcctAP"].Rows[r].ItemArray[7];
                dataGridView1.Rows[r].Cells[1].Value = ds.Tables["AcctAP"].Rows[r].ItemArray[8];
                dataGridView1.Rows[r].Cells[2].Value = ds.Tables["AcctAP"].Rows[r].ItemArray[0];
                dataGridView1.Rows[r].Cells[3].Value = ds.Tables["AcctAP"].Rows[r].ItemArray[3];
                dataGridView1.Rows[r].Cells[4].Value = ds.Tables["AcctAP"].Rows[r].ItemArray[5];
                dataGridView1.Rows[r].Cells[5].Value = ds.Tables["AcctAP"].Rows[r].ItemArray[4];
            }

            quryString = "select * from AcctAR where accountid=" + this.accountid + " order by id desc";
            da = new System.Data.OleDb.OleDbDataAdapter(quryString, con);
            ds = new DataSet();
            da.Fill(ds, "AcctAR");
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("id", "");
            dataGridView2.Columns.Add("company", "Company");
            dataGridView2.Columns.Add("firstName", "First Name");
            dataGridView2.Columns.Add("lastName", "Last Name");
            dataGridView2.Columns.Add("date", "Date");
            dataGridView2.Columns.Add("amount", "Amount");
            //set autosize mode
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            row = ds.Tables["AcctAR"].Rows.Count - 1;
            for (int r = 0; r <= row; r++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[r].Cells[0].Value = ds.Tables["AcctAR"].Rows[r].ItemArray[8];
                dataGridView2.Rows[r].Cells[1].Value = ds.Tables["AcctAR"].Rows[r].ItemArray[6];
                dataGridView2.Rows[r].Cells[2].Value = ds.Tables["AcctAR"].Rows[r].ItemArray[0];
                dataGridView2.Rows[r].Cells[3].Value = ds.Tables["AcctAR"].Rows[r].ItemArray[1];
                dataGridView2.Rows[r].Cells[4].Value = ds.Tables["AcctAR"].Rows[r].ItemArray[2];
                dataGridView2.Rows[r].Cells[5].Value = ds.Tables["AcctAR"].Rows[r].ItemArray[4];
            }

            CalculateTotalAsset(con);

            con.Close();
        }

        private void CalculateTotalAsset(System.Data.OleDb.OleDbConnection con)
        {
            string quryString = "select * from Expenses where accountid=" + this.accountid + " order by id desc";
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(quryString, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Expenses");
            int row = ds.Tables["Expenses"].Rows.Count - 1;
            for (int r = 0; r <= row; r++)
            {
                this.asset = this.asset - Double.Parse(ds.Tables["Expenses"].Rows[r].ItemArray[3].ToString());
            }

            quryString = "select * from Income where accountid=" + this.accountid + " order by id desc";
            da = new System.Data.OleDb.OleDbDataAdapter(quryString, con);
            ds = new DataSet();
            da.Fill(ds, "Income");
            row = ds.Tables["Income"].Rows.Count - 1;
            for (int r = 0; r <= row; r++)
            {
                this.asset = this.asset + Double.Parse(ds.Tables["Income"].Rows[r].ItemArray[3].ToString());
            }

            this.balass.Text = "$" + String.Format("{0:0.00}", this.asset);
        }

        private void newapbtn_Click(object sender, EventArgs e)
        {
            this.newapform.LoadMe();
            this.Controls.Clear();
            this.Controls.Remove(this.acctlistpanel);
            this.newapform.GetNewAcctPayablePanel().BackColor = Color.Transparent;
            this.Controls.Add(this.newapform.GetNewAcctPayablePanel());
            this.Height = 400;
        }

        private void newarbtn_Click(object sender, EventArgs e)
        {
            this.newarform.LoadMe();
            this.Controls.Clear();
            this.Controls.Remove(this.acctlistpanel);
            this.newarform.GetNewAcctReceivablePanel().BackColor = Color.Transparent;
            this.Controls.Add(this.newarform.GetNewAcctReceivablePanel());
            this.Height = 400;
        }

        private void viewIncome(object sender, DataGridViewCellEventArgs e)
        {
            try {
                int incomeId = (int)this.expensesincomeform.GetDataGrid2().CurrentRow.Cells[0].Value;
                this.incomeForm.incomeId = incomeId;
                this.incomeId = incomeId;
                this.incomeForm.LoadMe();
                this.Controls.Clear();
                this.Controls.Remove(this.acctlistpanel);
                this.incomeForm.GetIncomePanel().BackColor = Color.Transparent;
                this.Controls.Add(this.incomeForm.GetIncomePanel());
                this.Height = 400;
            } catch (Exception ex) {
                string x = ex.Message;
            }
        }
        
        private void viewExpense(object sender, DataGridViewCellEventArgs e)
        {
            try {
                int expenseId = (int)this.expensesincomeform.GetDataGrid().CurrentRow.Cells[0].Value;
                this.expenseForm.expenseId = expenseId;
                this.expenseId = expenseId;
                this.expenseForm.LoadMe();
                this.Controls.Clear();
                this.Controls.Remove(this.acctlistpanel);
                this.expenseForm.GetExpensePanel().BackColor = Color.Transparent;
                this.Controls.Add(this.expenseForm.GetExpensePanel());
                this.Height = 400;
            } catch (Exception ex) {
                string x = ex.Message;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int apId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                this.apform.apId = apId;
                this.apId = apId;
                this.apform.LoadMe();
                this.Controls.Remove(this.acctlistpanel);
                this.apform.GetAcctPayablePanel().BackColor = Color.Transparent;
                this.Controls.Add(this.apform.GetAcctPayablePanel());
                this.Height = 400;
            } catch(Exception ex)
            {
                string x = ex.Message;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int arId = (int)dataGridView2.CurrentRow.Cells[0].Value;
                this.arform.arId = arId;
                this.arId = arId;
                this.arform.LoadMe();
                this.Controls.Remove(this.acctlistpanel);
                this.arform.GetAcctReceivablePanel().BackColor = Color.Transparent;
                this.Controls.Add(this.arform.GetAcctReceivablePanel());
                this.Height = 400;
            } catch(Exception ex)
            {
                string x = ex.Message;
            }
        }

        public void WriteCheck(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Remove(this.acctlistpanel);
            this.writeCheckForm.GetWriteCheckPanel().BackColor = Color.Transparent;
            this.Controls.Add(this.writeCheckForm.GetWriteCheckPanel());
            this.writeCheckForm.apId = this.apId;
            this.writeCheckForm.LoadMe();
            this.Height = 400;
        }
    
        public void ReceiveAPayment(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Remove(this.acctlistpanel);
            this.receivePaymentForm.GetReceivePaymentPanel().BackColor = Color.Transparent;
            this.Controls.Add(this.receivePaymentForm.GetReceivePaymentPanel());
            this.receivePaymentForm.arId = this.arId;
            this.receivePaymentForm.LoadMe();
            this.Height = 400;
        }

        private void expensesAndIncomebtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Remove(this.acctlistpanel);
            this.expensesincomeform.GetExpensesAndIncomePanel().BackColor = Color.Transparent;
            this.Controls.Add(this.expensesincomeform.GetExpensesAndIncomePanel());
            this.expensesincomeform.LoadMe();
            this.Height = 610;
        }
    }
}